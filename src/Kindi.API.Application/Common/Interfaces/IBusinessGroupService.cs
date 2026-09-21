using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface IBusinessGroupService
{
    // ===== Công khai / thành viên =====
    Task<PagedList<BusinessGroupResponseDto>> GetPublicPagedAsync(BusinessGroupQueryDto query);
    Task<BusinessGroupDetailDto> GetPublicByIdAsync(Guid id);
    Task<JoinBusinessGroupResponseDto> JoinAsync(Guid id, JoinBusinessGroupRequest request);
    Task LeaveAsync(Guid id);

    Task<PagedList<BusinessGroupPostResponseDto>> GetPostsAsync(Guid groupId, GroupPostQueryDto query);
    Task<BusinessGroupPostResponseDto> CreatePostAsync(Guid groupId, CreateBusinessGroupPostDto request);
    Task DeletePostAsync(Guid groupId, Guid postId);

    Task<PagedList<BusinessGroupCommentResponseDto>> GetCommentsAsync(Guid postId, GroupCommentQueryDto query);
    Task<BusinessGroupCommentResponseDto> CreateCommentAsync(Guid postId, CreateBusinessGroupCommentDto request);
    Task DeleteCommentAsync(Guid postId, Guid commentId);

    // ===== Quản trị =====
    Task<PagedList<BusinessGroupResponseDto>> GetAdminPagedAsync(AdminBusinessGroupQueryDto query);
    Task<BusinessGroupDetailDto> GetAdminByIdAsync(Guid id);
    Task<BusinessGroupResponseDto> CreateAsync(CreateBusinessGroupDto request);
    Task<BusinessGroupResponseDto> UpdateAsync(Guid id, UpdateBusinessGroupDto request);
    Task DeleteAsync(Guid id);

    Task<PagedList<BusinessGroupMemberResponseDto>> GetMembersAsync(Guid id, BusinessGroupMemberQueryDto query);
    Task<BusinessGroupMemberResponseDto> UpdateMemberStatusAsync(Guid id, Guid memberId, UpdateGroupMemberStatusDto request);
    Task RemoveMemberAsync(Guid id, Guid memberId);
    Task<BusinessGroupPostResponseDto> UpdatePostAsync(Guid groupId, Guid postId, UpdateBusinessGroupPostDto request);
}
