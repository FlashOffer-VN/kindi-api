using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class CreateBusinessGroupPostValidator : AbstractValidator<CreateBusinessGroupPostDto>
{
    public CreateBusinessGroupPostValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Title)
            .MaximumLength(200).WithMessage(localizer["BusinessGroup_PostTitleMaxLength"]);

        RuleFor(x => x.Content)
            .NotEmpty().WithMessage(localizer["BusinessGroup_PostContentRequired"])
            .MinimumLength(2).WithMessage(localizer["BusinessGroup_PostContentMinLength"])
            .MaximumLength(4000).WithMessage(localizer["BusinessGroup_PostContentMaxLength"]);

        RuleFor(x => x.RefCode)
            .MaximumLength(30).WithMessage(localizer["BusinessGroup_RefCodeMaxLength"]);
    }
}
