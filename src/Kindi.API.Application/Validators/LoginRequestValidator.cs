using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
	public LoginRequestValidator(IStringLocalizer<SharedResource> localizer)
	{
		RuleFor(x => x.Username)
			.NotEmpty().WithMessage(localizer["UsernameRequired"])
			.MinimumLength(3).WithMessage(localizer["UsernameMinLength"])
			.MaximumLength(50).WithMessage(localizer["UsernameMaxLength"]);

		RuleFor(x => x.Password)
			.NotEmpty().WithMessage(localizer["PasswordRequired"])
			.MinimumLength(6).WithMessage(localizer["PasswordMinLength"]);
	}
}