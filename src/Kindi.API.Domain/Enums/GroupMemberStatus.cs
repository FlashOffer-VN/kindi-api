namespace Kindi.API.Domain.Enums;

/// <summary>Trạng thái thành viên nhóm: vào nhóm phải có tài khoản, admin duyệt thì mới Active.</summary>
public enum GroupMemberStatus
{
	Pending = 1,
	Active = 2,
	Rejected = 3,
	Left = 4
}
