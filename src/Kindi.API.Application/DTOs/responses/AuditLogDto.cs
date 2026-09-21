using AutoMapper;
using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;

namespace Kindi.API.Application.DTOs.responses;

public class AuditLogDto : IMapFrom<AuditLog>
{
    public Guid Id { get; set; }
    public string EntityName { get; set; } = string.Empty;
    public Guid EntityId { get; set; }
    public string Action { get; set; } = string.Empty;
    public string? ActorId { get; set; }
    public string? ActorName { get; set; }
    public string? IpAddress { get; set; }
    public string? OperatingSystem { get; set; }
    public string? BrowserName { get; set; }
    public string? DeviceType { get; set; }
    public DateTime Timestamp { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string? ChangedProperties { get; set; }

    public void Mapping(Profile profile)
        => profile.CreateMap<AuditLog, AuditLogDto>();
}