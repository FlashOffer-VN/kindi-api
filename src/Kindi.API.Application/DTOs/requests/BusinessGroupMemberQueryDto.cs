using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

/// <summary>Query thành viên nhóm (admin).</summary>
public class BusinessGroupMemberQueryDto
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
    public string? Search { get; set; }
    public GroupMemberStatus? Status { get; set; }
}
