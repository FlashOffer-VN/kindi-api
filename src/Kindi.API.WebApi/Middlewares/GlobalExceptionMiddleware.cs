using Kindi.API.Application.Common.Exceptions;
using Kindi.API.WebApi.Responses;
using System.Net;
using System.Text.Json;
using Kindi.API.Shared.Exceptions;

namespace Kindi.API.WebApi.Middlewares;

public class GlobalExceptionMiddleware
{
	private readonly RequestDelegate _next;
	private readonly ILogger<GlobalExceptionMiddleware> _logger;

	public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
	{
		_next = next;
		_logger = logger;
	}

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (NotFoundException ex)
        {
            _logger.LogWarning(ex, "Resource not found - Path: {Path}, Method: {Method}",
                context.Request.Path, context.Request.Method);
            await WriteExpectedAsync(context, StatusCodes.Status404NotFound, ex.Message);
        }
        // Các lỗi "có thể dự đoán" (vi phạm nghiệp vụ) trả 4xx kèm message đã bản địa hoá
        // thay vì 500 chung chung — trước đây chỉ NotFoundException được map.
        catch (KindiException ex)
        {
            _logger.LogWarning(ex, "{Code} - Path: {Path}", ex.StatusCode, context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status400BadRequest, ex.Message);
        }
        catch (BusinessException ex)
        {
            _logger.LogWarning(ex, "Business rule violated - Path: {Path}", context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status400BadRequest, ex.Message);
        }
        catch (BadRequestException ex)
        {
            _logger.LogWarning(ex, "Bad request - Path: {Path}", context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status400BadRequest, ex.Message);
        }
        catch (ValidationException ex)
        {
            _logger.LogWarning(ex, "Validation failed - Path: {Path}", context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status400BadRequest, ex.Message);
        }
        catch (ConflictException ex)
        {
            _logger.LogWarning(ex, "Conflict - Path: {Path}", context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status409Conflict, ex.Message);
        }
        catch (ForbiddenException ex)
        {
            _logger.LogWarning(ex, "Forbidden - Path: {Path}", context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status403Forbidden, ex.Message);
        }
        catch (UnauthorizedException ex)
        {
            _logger.LogWarning(ex, "Unauthorized - Path: {Path}", context.Request.Path);
            await WriteExpectedAsync(context, StatusCodes.Status401Unauthorized, ex.Message);
        }
        catch (Exception ex)
        {
            // Log đầy đủ thông tin
            _logger.LogError(ex, "❌ Unhandled exception - Path: {Path}, Method: {Method}, Query: {Query}, Body: {Body}",
                context.Request.Path,
                context.Request.Method,
                context.Request.QueryString.ToString(),
                await GetRequestBodyAsync(context.Request));

            await HandleExceptionAsync(context, ex);
        }
    }

    /// <summary>
    /// Trả response lỗi "có thể dự đoán" (4xx): message đã bản địa hoá nằm ở cả Message và Errors[0]
    /// để client hiển thị trực tiếp.
    /// </summary>
    private static async Task WriteExpectedAsync(HttpContext context, int statusCode, string message)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = statusCode;

        await context.Response.WriteAsJsonAsync(new ApiResponse<object>
        {
            Success = false,
            Message = message,
            Errors = new List<string> { message },
            Timestamp = DateTime.UtcNow
        });
    }

    private static async Task<string> GetRequestBodyAsync(HttpRequest request)
    {
        if (request.ContentLength == 0 || request.Body == null)
            return "N/A";

        request.EnableBuffering();
        var body = await new StreamReader(request.Body).ReadToEndAsync();
        request.Body.Position = 0;
        return body;
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
	{
		context.Response.ContentType = "application/json";
		context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

		var response = new ApiResponse<object>
		{
			Success = false,
			Message = "An error occurred while processing your request.",
			Errors = new List<string> { exception.Message },
			Timestamp = DateTime.UtcNow
		};

		await context.Response.WriteAsJsonAsync(response);
	}
}