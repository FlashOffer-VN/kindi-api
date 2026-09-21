using MediatR;
using Kindi.API.Application.DTOs.responses;

namespace Kindi.API.Application.Features.PurchaseRequests.Queries;

public class GetPurchaseRequestByIdQuery : IRequest<PurchaseRequestResponseDto>
{
	public Guid Id { get; set; }
}