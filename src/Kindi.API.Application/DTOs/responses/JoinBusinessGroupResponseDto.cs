using Kindi.API.Application.DTOs.Responses;
using Kindi.API.Domain.Enums;

namespace Kindi.API.Application.DTOs.responses;

/// <summary>
/// Kết quả xin vào nhóm. Nếu là khách chưa có tài khoản, hệ thống tạo tài khoản từ
/// thông tin liên hệ (username user&lt;sđt&gt;, mật khẩu = SĐT) và trả về trong <see cref="Account"/>.
/// </summary>
public class JoinBusinessGroupResponseDto
{
    public Guid MemberId { get; set; }
    public GroupMemberStatus Status { get; set; }
    public int MembersCount { get; set; }
    public bool RequiresApproval { get; set; }
    public bool IsGroupActive { get; set; }

    public AccountCredentialsDto? Account { get; set; }

    public string Message { get; set; } = string.Empty;
}
