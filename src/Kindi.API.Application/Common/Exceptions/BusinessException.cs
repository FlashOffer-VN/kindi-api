// Application/Common/Exceptions/BusinessException.cs
namespace Kindi.API.Application.Common.Exceptions;

public class BusinessException : Exception
{
    public BusinessException() { }

    public BusinessException(string message) : base(message) { }

    public BusinessException(string message, Exception innerException)
        : base(message, innerException) { }
}