// Application/DTOs/requests/UpdatePurchaseRequestStatusDto.cs
using Kindi.API.Domain.Enums;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;

namespace Kindi.API.Application.DTOs.requests;

public class UpdatePurchaseRequestStatusDto : IMapFrom<PurchaseRequest>
{
	public PurchaseRequestStatus Status { get; set; }
}