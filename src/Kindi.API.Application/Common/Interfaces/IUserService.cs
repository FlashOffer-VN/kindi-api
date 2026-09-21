using Kindi.API.Domain.Entities;

namespace Kindi.API.Application.Common.Interfaces;

public interface IUserService
{
    Task<Guid> GetOrCreateUserAsync(string fullName, string phone, string? email = null);
    Task<Guid> GetOrCreateUserWithPhonePasswordAsync(string fullName, string phone, string? email = null);
    Task<User?> GetCurrentUserAsync();
}