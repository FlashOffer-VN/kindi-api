using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface ISocialService
{
    Task<PagedList<PostResponse>> GetPostsAsync(GetPostsQuery query);
    Task<PostResponse> GetPostByIdAsync(Guid id);
    Task<PostResponse> CreatePostAsync(CreatePostRequest request);
    Task<PostResponse> UpdatePostAsync(Guid id, UpdatePostRequest request);
    Task<bool> DeletePostAsync(Guid id);

    Task<PagedList<PostResponse>> GetPendingPostsAsync(int pageNumber, int pageSize);
    Task<PagedList<PostResponse>> GetAdminPostsAsync(string? status, string? search, DateTime? fromDate, DateTime? toDate, int pageNumber, int pageSize);

    Task<PostResponse> RestorePostAsync(Guid id);

    Task<PostResponse> ApprovePostAsync(Guid id);
    Task<PostResponse> RejectPostAsync(Guid id, string? reason = null);

    Task<PostResponse> PinPostAsync(Guid id);
    Task<PostResponse> UnpinPostAsync(Guid id);
}