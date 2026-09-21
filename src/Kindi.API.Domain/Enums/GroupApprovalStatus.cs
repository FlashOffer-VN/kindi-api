namespace Kindi.API.Domain.Enums;

/// <summary>Trạng thái duyệt của hội nhóm do người dùng tạo.</summary>
public enum GroupApprovalStatus
{
    /// <summary>Chờ admin duyệt mở hội</summary>
    Pending = 1,
    Approved = 2,
    Rejected = 3
}
