// Application/Validators/UpdatePurchaseRequestStatusValidator.cs
using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class UpdatePurchaseRequestStatusValidator : AbstractValidator<UpdatePurchaseRequestStatusDto>
{
	public UpdatePurchaseRequestStatusValidator(IStringLocalizer<SharedResource> localizer)
	{
		RuleFor(x => x.Status)
			.IsInEnum()
			.WithMessage(localizer["StatusInvalid"]);
	}
}