using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.responses;

/// <summary>Nhóm theo lĩnh vực kinh doanh (item trong danh sách).</summary>
public class BusinessGroupResponseDto : IMapFrom<BusinessGroup>
{
    public Guid Id { get; set; }
    public string? BusinessGroupCode { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public Guid? BusinessFieldId { get; set; }
    public string? BusinessFieldName { get; set; }

    /// <summary>Nhóm ngành (Industry) hay Hội nhóm (Community).</summary>
    public BusinessGroupType Type { get; set; }

    /// <summary>Chủ đề của hội nhóm (Community).</summary>
    public string? Topic { get; set; }

    public GroupApprovalStatus ApprovalStatus { get; set; }
    public string? RejectedReason { get; set; }

    /// <summary>Người đang xem có phải người tạo hội nhóm (chủ hội) hay không.</summary>
    public bool IsOwner { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public string? CoverImageUrl { get; set; }
    public bool RequiresApproval { get; set; }
    public bool IsActive { get; set; }

    public int MembersCount { get; set; }
    public int PostsCount { get; set; }
    public DateTime CreatedAt { get; set; }

    /// <summary>Trạng thái thành viên của người đang xem (null = chưa tham gia / chưa đăng nhập).</summary>
    public GroupMemberStatus? MyMemberStatus { get; set; }
    public bool IsMember { get; set; }

    /// <summary>Số yêu cầu vào nhóm đang chờ duyệt (chỉ admin thấy).</summary>
    public int PendingMembersCount { get; set; }

    /// <summary>Số yêu cầu kín gửi admin chưa xử lý (chỉ admin thấy).</summary>
    public int PrivateRequestsCount { get; set; }

    public void Mapping(Profile profile)
        => profile.CreateMap<BusinessGroup, BusinessGroupResponseDto>()
            .ForMember(dest => dest.BusinessFieldName,
                opt => opt.MapFrom(src => src.BusinessField != null ? src.BusinessField.Name : src.BusinessFieldName));
}
