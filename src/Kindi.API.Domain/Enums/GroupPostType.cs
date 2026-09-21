namespace Kindi.API.Domain.Enums;

/// <summary>Loại bài trong nhóm.</summary>
public enum GroupPostType
{
	/// <summary>Thảo luận thường của thành viên / admin</summary>
	Discussion = 1,
	/// <summary>Admin gửi offer (báo giá) vào nhóm</summary>
	Offer = 2,
	/// <summary>Admin gửi yêu cầu mua chung vào nhóm</summary>
	GroupBuyingRequest = 3,
	/// <summary>Admin gửi yêu cầu tìm nhà cung cấp vào nhóm</summary>
	SupplierRequest = 4,
	/// <summary>Thông báo chung của admin</summary>
	Announcement = 5
}
