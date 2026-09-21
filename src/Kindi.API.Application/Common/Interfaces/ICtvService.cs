using Kindi.API.Application.DTOs.Requests;
using Kindi.API.Application.DTOs.Responses;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface ICtvService
{
    Task<PagedList<CtvResponseDto>> GetPagedAsync(CtvFilterRequest filter);
    Task<CtvDetailResponseDto?> GetDetailAsync(Guid id);
    Task<CtvResponseDto> ApproveAsync(Guid id);
    Task<CtvResponseDto> RejectAsync(Guid id);
    Task<PagedList<CtvResponseDto>> GetPagedDeletedAsync(int pageNumber, int pageSize, string? search = null);
    Task DeleteAsync(Guid id);
    Task<CtvResponseDto> RestoreAsync(Guid id);
}