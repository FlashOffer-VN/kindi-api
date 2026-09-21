using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

public class GetPostsQuery
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public PostType? Type { get; set; }
    public PrivacyType? Privacy { get; set; }
    public string? Tag { get; set; }
}