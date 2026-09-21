using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface IPurchaseRequestService
{
	Task<PurchaseRequestResponseDto> CreateAsync(CreatePurchaseRequestDto request);
	Task<PagedList<PurchaseRequestResponseDto>> GetPagedAsync(PurchaseRequestQueryDto query);
	Task<PurchaseRequestStatusResponseDto> UpdateStatusAsync(Guid id, UpdatePurchaseRequestStatusDto dto);
}