using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Kindi.API.Domain.Enums;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class UpdateGroupMemberStatusValidator : AbstractValidator<UpdateGroupMemberStatusDto>
{
    public UpdateGroupMemberStatusValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.Status)
            .Must(status => status == GroupMemberStatus.Active || status == GroupMemberStatus.Rejected)
            .WithMessage(localizer["BusinessGroup_MemberStatusInvalidMessage"]);

        RuleFor(x => x.RejectionReason)
            .NotEmpty().WithMessage(localizer["BusinessGroup_RejectionReasonRequired"])
            .MaximumLength(500).WithMessage(localizer["BusinessGroup_RejectionReasonMaxLength"])
            .When(x => x.Status == GroupMemberStatus.Rejected);
    }
}
