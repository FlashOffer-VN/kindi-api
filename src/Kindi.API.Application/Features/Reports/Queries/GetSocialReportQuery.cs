using Kindi.API.Application.DTOs.Responses;
using MediatR;

namespace Kindi.API.Application.Features.Reports.Queries;

/// <summary>
/// Truy vấn báo cáo hoạt động mạng xã hội
/// </summary>
public class GetSocialReportQuery : IRequest<SocialReportDto>
{
    /// <summary>Giới hạn số bài viết nổi bật (mặc định 10)</summary>
    public int TopPostCount { get; set; } = 10;
}