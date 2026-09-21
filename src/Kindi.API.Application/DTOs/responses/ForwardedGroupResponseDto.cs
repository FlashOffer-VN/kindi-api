namespace Kindi.API.Application.DTOs.responses;

/// <summary>
/// Nhóm ngành đã có bài chuyển tiếp cho một bản ghi (yêu cầu mua chung / offer / yêu cầu tìm nhà cung cấp).
/// Dùng để cảnh báo admin trước khi gửi: nhóm đã có sẽ không gửi lại.
/// </summary>
public class ForwardedGroupResponseDto
{
    public Guid GroupId { get; set; }
    public string? GroupCode { get; set; }
    public string Name { get; set; } = string.Empty;
}
