using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class CreateBusinessGroupCommentValidator : AbstractValidator<CreateBusinessGroupCommentDto>
{
    public CreateBusinessGroupCommentValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Content)
            .NotEmpty().WithMessage(localizer["BusinessGroup_CommentRequired"])
            .MaximumLength(2000).WithMessage(localizer["BusinessGroup_CommentMaxLength"]);
    }
}
