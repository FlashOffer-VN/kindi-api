namespace Kindi.API.Application.DTOs.requests;

public class CreateBusinessGroupCommentDto
{
    public string Content { get; set; } = string.Empty;
    public Guid? ParentCommentId { get; set; }
}
