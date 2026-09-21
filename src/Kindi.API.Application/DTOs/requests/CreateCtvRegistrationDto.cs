using Kindi.API.Application.Common.Mappings;
using Kindi.API.Domain.Entities;
using AutoMapper;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.requests;

public class CreateCtvRegistrationDto : IMapFrom<Collaborator>
{
	public string FullName { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public string? Zalo { get; set; }
	public string? Email { get; set; }
	public SalesChannel? SalesChannel { get; set; }
	public string? Experience { get; set; }

	public void Mapping(Profile profile)
		=> profile.CreateMap<CreateCtvRegistrationDto, Collaborator>();
}