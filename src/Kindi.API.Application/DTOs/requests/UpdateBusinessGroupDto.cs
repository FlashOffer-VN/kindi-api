namespace Kindi.API.Application.DTOs.requests;

/// <summary>Admin cập nhật nhóm.</summary>
public class UpdateBusinessGroupDto
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public Guid? BusinessFieldId { get; set; }
    public string? BusinessFieldName { get; set; }

    public string? CoverImageUrl { get; set; }

    public bool RequiresApproval { get; set; } = true;

    public bool IsActive { get; set; } = true;
}
