using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

public class CreatePostRequest : IMapFrom<SocialPost>
{
    public string? Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public PostType Type { get; set; } = PostType.Post;
    public PrivacyType Privacy { get; set; } = PrivacyType.Public;
    public List<string> Tags { get; set; } = new();
    public List<string> Images { get; set; } = new();

    // For Question
    public bool IsAnswered { get; set; }

    // For Event
    public DateTime? EventDate { get; set; }
    public string? Location { get; set; }
    public int? MaxParticipants { get; set; }
    public bool? IsOnline { get; set; }

    // For Announcement
    public PriorityType? Priority { get; set; }
    public DateTime? PinnedUntil { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreatePostRequest, SocialPost>()
            .ForMember(dest => dest.PostTags, opt => opt.Ignore()); 
    }
}