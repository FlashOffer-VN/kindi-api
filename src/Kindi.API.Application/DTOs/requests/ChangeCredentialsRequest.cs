namespace Kindi.API.Application.DTOs.requests
{
	/// <summary>
	/// Đổi tên đăng nhập + mật khẩu: dùng cho lần đăng nhập đầu tiên của tài khoản tạo từ form công khai
	/// và cho chức năng đổi thông tin đăng nhập ở trang người dùng.
	/// </summary>
	public class ChangeCredentialsRequest
	{
		public string CurrentPassword { get; set; } = string.Empty;
		public string NewUsername { get; set; } = string.Empty;
		public string NewPassword { get; set; } = string.Empty;
		public string ConfirmNewPassword { get; set; } = string.Empty;
	}
}
