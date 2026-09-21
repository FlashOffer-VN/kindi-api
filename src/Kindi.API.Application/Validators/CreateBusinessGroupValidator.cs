using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class CreateBusinessGroupValidator : AbstractValidator<CreateBusinessGroupDto>
{
    public CreateBusinessGroupValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(localizer["BusinessGroup_NameRequired"])
            .MinimumLength(3).WithMessage(localizer["BusinessGroup_NameMinLength"])
            .MaximumLength(200).WithMessage(localizer["BusinessGroup_NameMaxLength"]);

        RuleFor(x => x.Description)
            .MaximumLength(1000).WithMessage(localizer["BusinessGroup_DescriptionMaxLength"]);

        RuleFor(x => x.CoverImageUrl)
            .MaximumLength(500).WithMessage(localizer["BusinessGroup_CoverUrlMaxLength"]);
    }
}
