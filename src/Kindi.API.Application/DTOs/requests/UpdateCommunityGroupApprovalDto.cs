using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

/// <summary>Admin duyệt / từ chối mở hội nhóm.</summary>
public class UpdateCommunityGroupApprovalDto
{
    /// <summary>Chỉ nhận Approved (duyệt mở hội) hoặc Rejected (từ chối).</summary>
    public GroupApprovalStatus ApprovalStatus { get; set; }

    public string? RejectedReason { get; set; }
}
