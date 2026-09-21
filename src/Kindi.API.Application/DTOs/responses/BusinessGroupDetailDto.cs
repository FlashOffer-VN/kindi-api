using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.responses;

/// <summary>Chi tiết nhóm: thông tin nhóm + thành viên + trạng thái của người đang xem.</summary>
public class BusinessGroupDetailDto : IMapFrom<BusinessGroup>
{
    public Guid Id { get; set; }
    public string? BusinessGroupCode { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public Guid? BusinessFieldId { get; set; }
    public string? BusinessFieldName { get; set; }

    public string? CoverImageUrl { get; set; }
    public bool RequiresApproval { get; set; }
    public bool IsActive { get; set; }

    public int MembersCount { get; set; }
    public int PostsCount { get; set; }
    public DateTime CreatedAt { get; set; }

    public GroupMemberStatus? MyMemberStatus { get; set; }
    public bool IsMember { get; set; }

    /// <summary>Người đang xem được đọc bài trong nhóm (thành viên đã duyệt) hay không.</summary>
    public bool CanViewPosts { get; set; }
    public bool IsAdmin { get; set; }

    public int PendingMembersCount { get; set; }
    public int PrivateRequestsCount { get; set; }

    public List<BusinessGroupMemberResponseDto> Members { get; set; } = new();

    public void Mapping(Profile profile)
        => profile.CreateMap<BusinessGroup, BusinessGroupDetailDto>()
            .ForMember(dest => dest.BusinessFieldName,
                opt => opt.MapFrom(src => src.BusinessField != null ? src.BusinessField.Name : src.BusinessFieldName))
            .ForMember(dest => dest.Members, opt => opt.Ignore());
}
