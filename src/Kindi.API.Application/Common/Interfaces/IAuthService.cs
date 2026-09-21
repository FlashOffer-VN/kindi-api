using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;

namespace Kindi.API.Application.Common.Interfaces;

public interface IAuthService
{
	Task<LoginResponse?> LoginAsync(LoginRequest request);
	Task LogoutAsync(string token);
	Task<LoginResponse?> RefreshTokenAsync(string token);
	Task<bool> ChangePasswordAsync(Guid userId, ChangePasswordRequest request);
	Task ForgotPasswordAsync(ForgotPasswordRequest request);
	Task<bool> ResetPasswordAsync(ResetPasswordRequest request);
	Task<UserInfoResponse?> GetUserByIdAsync(Guid userId);
}