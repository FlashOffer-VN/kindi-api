using Kindi.API.Application.DTOs.Responses;
using MediatR;

namespace Kindi.API.Application.Features.Reports.Queries;

/// <summary>
/// Truy vấn báo cáo thành viên (đối tác + cộng tác viên)
/// </summary>
public class GetMembersReportQuery : IRequest<MembersReportDto>
{
}