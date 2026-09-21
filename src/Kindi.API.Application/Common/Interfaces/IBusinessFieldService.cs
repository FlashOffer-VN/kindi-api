using Kindi.API.Application.DTOs.Responses;

namespace Kindi.API.Application.Common.Interfaces;

public interface IBusinessFieldService
{
    Task<Guid> GetOrCreateBusinessFieldAsync(string name);
    Task<List<BusinessFieldDto>> GetActiveFieldsAsync();
}