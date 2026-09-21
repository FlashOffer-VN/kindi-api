using Kindi.API.Application.DTOs.Requests;
using Kindi.API.Application.DTOs.Responses;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface ICompanyService
{
    Task<Company?> AddOrUpdateFromLegacyAsync(
        string? name,
        string? taxCode,
        string? address,
        string? website,
        Guid? businessFieldId = null,
        Kindi.API.Domain.Enums.BusinessType? businessType = null,
        Kindi.API.Domain.Enums.CompanySize? companySize = null);

    Task<CompanyResponseDto> CreateAsync(CreateCompanyDto request);
    Task<CompanyResponseDto> UpdateAsync(Guid id, UpdateCompanyDto request);
    Task<PagedList<CompanyResponseDto>> GetPagedAsync(int pageNumber, int pageSize, string? search = null);
    Task<CompanyResponseDto?> GetByIdAsync(Guid id);
}
