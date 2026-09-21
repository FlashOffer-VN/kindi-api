namespace Kindi.API.Application.DTOs.requests;

/// <summary>Admin cập nhật bài trong nhóm (ghim / ẩn / sửa nội dung).</summary>
public class UpdateBusinessGroupPostDto
{
    public string? Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public bool IsPinned { get; set; }
    public bool IsHidden { get; set; }
}
