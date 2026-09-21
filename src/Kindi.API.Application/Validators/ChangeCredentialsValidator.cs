using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class ChangeCredentialsValidator : AbstractValidator<ChangeCredentialsRequest>
{
	public ChangeCredentialsValidator(IStringLocalizer<SharedResource> localizer)
	{
		RuleFor(x => x.CurrentPassword)
			.NotEmpty().WithMessage(localizer["PasswordRequired"]);

		RuleFor(x => x.NewUsername)
			.NotEmpty().WithMessage(localizer["UsernameRequired"])
			.MinimumLength(3).WithMessage(localizer["UsernameMinLength"])
			.MaximumLength(50).WithMessage(localizer["UsernameMaxLength"])
			.Matches("^[a-zA-Z0-9._-]+$").WithMessage(localizer["UsernameInvalid"]);

		RuleFor(x => x.NewPassword)
			.NotEmpty().WithMessage(localizer["PasswordRequired"])
			.MinimumLength(6).WithMessage(localizer["PasswordMinLength"])
			.MaximumLength(100).WithMessage(localizer["Collaborator_PasswordMaxLength"])
			.NotEqual(x => x.CurrentPassword).WithMessage(localizer["NewPasswordSameAsCurrent"]);

		RuleFor(x => x.ConfirmNewPassword)
			.Equal(x => x.NewPassword).WithMessage(localizer["Collaborator_PasswordMismatch"]);
	}
}
