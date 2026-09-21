// src/Kindi.API.Application/DTOs/responses/GroupBuyingRequestResponseDto.cs
using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.responses;

public class GroupBuyingRequestResponseDto : IMapFrom<GroupBuyingRequest>
{
    public Guid Id { get; set; }
    public string? GroupBuyingRequestCode { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string? ProductLink { get; set; }             
    public int TargetPeopleCount { get; set; }
    public int CurrentPeopleCount { get; set; }
    public decimal? TargetPrice { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Zalo { get; set; }                     
    public string Email { get; set; } = string.Empty;     
    public string? Note { get; set; }
    public GroupBuyingStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }

    public void Mapping(Profile profile)
        => profile.CreateMap<GroupBuyingRequest, GroupBuyingRequestResponseDto>();
}