using Kindi.API.Application.DTOs.Requests;
using Kindi.API.Application.DTOs.Responses;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface ICollaboratorService
{
    Task<CollaboratorResponseDto> CreateAsync(CreateCollaboratorDto request);
    Task<CollaboratorResponseDto> UpdateAsync(Guid id, UpdateCollaboratorDto request);
    Task<CollaboratorResponseDto> GetByIdAsync(Guid id);
    Task<PagedList<CollaboratorResponseDto>> GetPagedAsync(int page, int size, string? search = null);
    Task ApproveAsync(Guid id);
    Task RejectAsync(Guid id, string? reason = null);
    Task DeleteAsync(Guid id);
    Task RestoreAsync(Guid id);
}