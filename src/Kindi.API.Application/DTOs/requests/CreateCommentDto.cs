using System.ComponentModel.DataAnnotations;

namespace Kindi.API.Application.DTOs.Requests;

public class CreateCommentDto
{
    [Required(ErrorMessage = "Content is required")]
    [MaxLength(1000, ErrorMessage = "Content cannot exceed 1000 characters")]
    public string Content { get; set; } = string.Empty;

    public Guid? ParentCommentId { get; set; }
}