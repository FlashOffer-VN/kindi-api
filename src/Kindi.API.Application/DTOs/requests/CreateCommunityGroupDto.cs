namespace Kindi.API.Application.DTOs.requests;

/// <summary>
/// Người dùng tự tạo hội nhóm theo chủ đề. Hội phải được admin duyệt mở,
/// sau đó chủ hội tự duyệt thành viên và trao đổi riêng trong hội.
/// </summary>
public class CreateCommunityGroupDto
{
    public string Name { get; set; } = string.Empty;

    /// <summary>Chủ đề của hội (ví dụ: Bán hàng online, Đầu tư cá nhân...).</summary>
    public string Topic { get; set; } = string.Empty;

    public string? Description { get; set; }
}
