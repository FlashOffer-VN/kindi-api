using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.DTOs.responses;
using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Interfaces;
using Kindi.API.Domain.Models;

namespace Kindi.API.Application.Common.Interfaces;

public interface IAuditLogQueryService
{
    Task<PagedList<AuditLogDto>> GetEntityLogsAsync(AuditLogQueryDto query, CancellationToken cancellationToken = default);

    Task<AuditLogDto?> GetEntityLogByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<PagedList<AuthAuditLogDto>> GetAuthLogsAsync(AuthAuditLogQueryDto query, CancellationToken cancellationToken = default);

    Task<AuthAuditLogDto?> GetAuthLogByIdAsync(Guid id, CancellationToken cancellationToken = default);
}