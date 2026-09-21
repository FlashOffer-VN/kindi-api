using Kindi.API.Domain.Enums;

namespace Kindi.API.Domain.Entities;

/// <summary>
/// Nhóm các đối tác cùng lĩnh vực kinh doanh để admin gửi thông tin/offer/yêu cầu
/// phù hợp và thành viên trao đổi với nhau.
/// </summary>
public class BusinessGroup : BaseEntity
{
	public string? BusinessGroupCode { get; set; }
	public string Name { get; set; } = string.Empty;
	public string? Description { get; set; }

	/// <summary>Lĩnh vực kinh doanh của nhóm (tái sử dụng BusinessField đang quản lý tập trung).</summary>
	public Guid? BusinessFieldId { get; set; }
	public string? BusinessFieldName { get; set; }

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
