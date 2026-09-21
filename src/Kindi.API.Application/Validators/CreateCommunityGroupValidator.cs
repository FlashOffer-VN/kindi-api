using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class CreateCommunityGroupValidator : AbstractValidator<CreateCommunityGroupDto>
{
    public CreateCommunityGroupValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(localizer["BusinessGroup_NameRequired"])
            .MinimumLength(3).WithMessage(localizer["BusinessGroup_NameMinLength"])
            .MaximumLength(200).WithMessage(localizer["BusinessGroup_NameMaxLength"]);

        RuleFor(x => x.Topic)
            .NotEmpty().WithMessage(localizer["BusinessGroup_TopicRequired"])
            .MinimumLength(3).WithMessage(localizer["BusinessGroup_TopicMinLength"])
            .MaximumLength(200).WithMessage(localizer["BusinessGroup_TopicMaxLength"]);

        RuleFor(x => x.Description)
            .MaximumLength(1000).WithMessage(localizer["BusinessGroup_DescriptionMaxLength"]);
    }
}
