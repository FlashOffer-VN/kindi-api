using FluentValidation;
using Kindi.API.Application.DTOs.Requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class CreateCommentValidator : AbstractValidator<CreateCommentDto>
{
    public CreateCommentValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Content)
            .NotEmpty().WithMessage(localizer["SocialComment_ContentRequired"])
            .MaximumLength(1000).WithMessage(localizer["SocialComment_ContentMaxLength"]);
    }
}