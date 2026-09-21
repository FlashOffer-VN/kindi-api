using Kindi.API.Domain.Entities;

namespace Kindi.API.Application.Common.Interfaces;

public interface IUserService
{
    Task<Guid> GetOrCreateUserAsync(string fullName, string phone, string? email = null);
    Task<Guid> GetOrCreateUserWithPhonePasswordAsync(string fullName, string phone, string? email = null);
    Task<User?> GetCurrentUserAsync();

    /// <summary>
    /// Tìm user theo SĐT hoặc email (không tạo mới). Dùng để biết form công khai
    /// có tạo tài khoản mới hay dùng lại tài khoản đã có.
    /// </summary>
    Task<User?> FindByPhoneOrEmailAsync(string? phone, string? email);

    /// <summary>Tìm user theo Id (chưa xoá).</summary>
    Task<User?> FindByIdAsync(Guid userId);
}