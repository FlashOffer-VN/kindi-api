using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

/// <summary>Query danh sách nhóm cho admin.</summary>
public class AdminBusinessGroupQueryDto
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? Search { get; set; }
    public Guid? BusinessFieldId { get; set; }
    public bool? IsActive { get; set; }

    /// <summary>true = chỉ nhóm đang có yêu cầu vào nhóm chờ duyệt.</summary>
    public bool HasPendingMembers { get; set; }
    /// <summary>true = chỉ nhóm đang có yêu cầu kín gửi admin chờ xử lý.</summary>
    public bool HasPrivateRequests { get; set; }
}
