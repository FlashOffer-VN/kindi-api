namespace Kindi.API.Domain.Enums;

/// <summary>
/// Loại nhóm:
/// - Industry: nhóm ngành do admin gom theo lĩnh vực kinh doanh (ai cũng thấy, admin duyệt thành viên).
/// - Community: hội nhóm do người dùng tự tạo theo chủ đề (admin duyệt việc mở hội, chủ hội duyệt thành viên).
/// </summary>
public enum BusinessGroupType
{
    Industry = 1,
    Community = 2
}
