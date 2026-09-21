using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface IGroupBuyingRequestService
{
	Task<GroupBuyingRequestResponseDto> CreateAsync(CreateGroupBuyingRequestDto request);
	Task<PagedList<GroupBuyingRequestResponseDto>> GetPagedAsync(GetGroupBuyingRequestsQueryDto query);
}