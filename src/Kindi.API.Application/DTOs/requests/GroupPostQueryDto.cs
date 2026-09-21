using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

/// <summary>Query bài đăng trong nhóm.</summary>
public class GroupPostQueryDto
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 20;
    public string? Search { get; set; }
    public GroupPostType? Type { get; set; }

    /// <summary>Chỉ lấy yêu cầu kín gửi admin (chỉ admin dùng được).</summary>
    public bool PrivateOnly { get; set; }
}
