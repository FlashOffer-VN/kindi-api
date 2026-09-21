namespace Kindi.API.Domain.Enums;

/// <summary>
/// Trạng thái của một người trong nhóm mua chung.
/// </summary>
public enum GroupBuyingParticipantStatus
{
	/// <summary>Đang tham gia — được tính vào số người hiện tại của nhóm.</summary>
	Joined = 1,

	/// <summary>Đã hủy tham gia — giữ lại bản ghi để đối soát, không tính vào số người.</summary>
	Cancelled = 2
}
