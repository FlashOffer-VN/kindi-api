using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

/// <summary>Admin duyệt / từ chối yêu cầu vào nhóm.</summary>
public class UpdateGroupMemberStatusDto
{
    /// <summary>Chỉ nhận Active (duyệt) hoặc Rejected (từ chối).</summary>
    public GroupMemberStatus Status { get; set; }

    public string? RejectionReason { get; set; }
}
