using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface ICtvRegistrationService
{
	Task<CtvRegistrationResponseDto> CreateAsync(CreateCtvRegistrationDto dto);
	Task<PagedList<CtvRegistrationResponseDto>> GetPagedAsync(CtvRegistrationQueryDto query);
	Task<CtvRegistrationResponseDto> ApproveAsync(Guid id);
}