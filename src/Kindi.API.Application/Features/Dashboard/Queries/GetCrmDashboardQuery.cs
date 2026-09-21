using Kindi.API.Application.DTOs.Responses;
using MediatR;

namespace Kindi.API.Application.Features.Dashboard.Queries;

public class GetCrmDashboardQuery : IRequest<CrmDashboardStatsDto>
{
}
