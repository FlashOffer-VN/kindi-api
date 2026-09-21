namespace Kindi.API.Application.DTOs.requests;

/// <summary>Admin tạo nhóm theo lĩnh vực kinh doanh.</summary>
public class CreateBusinessGroupDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public Guid? BusinessFieldId { get; set; }
    public string? BusinessFieldName { get; set; }

    public string? CoverImageUrl { get; set; }

    /// <summary>true = thành viên mới phải được admin duyệt mới vào nhóm.</summary>
    public bool RequiresApproval { get; set; } = true;

    public bool IsActive { get; set; } = true;
}
