using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.responses;

public class BusinessGroupPostResponseDto : IMapFrom<BusinessGroupPost>
{
    public Guid Id { get; set; }
    public string? BusinessGroupPostCode { get; set; }
    public Guid BusinessGroupId { get; set; }

    public string? Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public GroupPostType Type { get; set; }

    public Guid? RefId { get; set; }
    public string? RefCode { get; set; }

    public bool IsPrivateToAdmin { get; set; }
    public bool IsPinned { get; set; }
    public bool IsHidden { get; set; }
    public int CommentsCount { get; set; }

    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public void Mapping(Profile profile)
        => profile.CreateMap<BusinessGroupPost, BusinessGroupPostResponseDto>()
            .ForMember(dest => dest.AuthorName,
                opt => opt.MapFrom(src => src.Author != null ? src.Author.FullName : string.Empty));
}
