// Application/DTOs/responses/PurchaseRequestStatusResponseDto.cs
using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.responses;

public class PurchaseRequestStatusResponseDto : IMapFrom<PurchaseRequest>
{
	public Guid Id { get; set; }
	public string? PurchaseRequestCode { get; set; }
	public PurchaseRequestStatus Status { get; set; }
	public DateTime UpdatedAt { get; set; }

	public void Mapping(Profile profile)
		=> profile.CreateMap<PurchaseRequest, PurchaseRequestStatusResponseDto>();
}