namespace Kindi.API.Application.DTOs.Responses;

/// <summary>
/// Thông tin tài khoản vừa được tạo tự động từ form công khai (username user&lt;sđt&gt;, mật khẩu = SĐT)
/// để client hiển thị cho người đăng ký.
/// </summary>
public class AccountCredentialsDto
{
    /// <summary>Tài khoản vừa được tạo trong lượt đăng ký này.</summary>
    public bool IsNewAccount { get; set; }

    /// <summary>Tài khoản đã tồn tại trước đó (theo SĐT/email) nên không tạo mới.</summary>
    public bool AccountAlreadyExisted { get; set; }

    public string? Username { get; set; }

    /// <summary>true = mật khẩu khởi tạo chính là số điện thoại vừa nhập.</summary>
    public bool PasswordIsPhone { get; set; }
}
