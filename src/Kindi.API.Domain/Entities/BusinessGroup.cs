using Kindi.API.Domain.Enums;

namespace Kindi.API.Domain.Entities;

/// <summary>
/// Nhóm các đối tác cùng lĩnh vực kinh doanh để admin gửi thông tin/offer/yêu cầu
/// phù hợp và thành viên trao đổi với nhau.
/// </summary>
public class BusinessGroup : BaseEntity
{
	public string? BusinessGroupCode { get; set; }

	/// <summary>Nhóm ngành (admin gom theo lĩnh vực) hay Hội nhóm (người dùng tự tạo theo chủ đề).</summary>
	public BusinessGroupType Type { get; set; } = BusinessGroupType.Industry;
	public string Name { get; set; } = string.Empty;
	public string? Description { get; set; }

	/// <summary>Lĩnh vực kinh doanh của nhóm (tái sử dụng BusinessField đang quản lý tập trung).</summary>
	public Guid? BusinessFieldId { get; set; }
	public string? BusinessFieldName { get; set; }

	/// <summary>Chủ đề của hội nhóm (chỉ dùng cho Type = Community).</summary>
	public string? Topic { get; set; }

	/// <summary>Trạng thái duyệt mở hội (Community). Nhóm ngành luôn Approved.</summary>
	public GroupApprovalStatus ApprovalStatus { get; set; } = GroupApprovalStatus.Approved;

	/// <summary>Lý do admin từ chối mở hội.</summary>
	public string? RejectedReason { get; set; }

	public string? CoverImageUrl { get; set; }

	/// <summary>true = vào nhóm phải được admin duyệt (mặc định), false = vào ngay.</summary>
	public bool RequiresApproval { get; set; } = true;

	public bool IsActive { get; set; } = true;

	public int MembersCount { get; set; }
	public int PostsCount { get; set; }

	public Guid? CreatedByUserId { get; set; }

	// Navigation
	public virtual BusinessField? BusinessField { get; set; }
	public virtual User? CreatedByUser { get; set; }
	public virtual ICollection<BusinessGroupMember> Members { get; set; } = new List<BusinessGroupMember>();
	public virtual ICollection<BusinessGroupPost> Posts { get; set; } = new List<BusinessGroupPost>();
}
