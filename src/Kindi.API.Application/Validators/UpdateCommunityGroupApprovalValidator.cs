using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Kindi.API.Domain.Enums;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class UpdateCommunityGroupApprovalValidator : AbstractValidator<UpdateCommunityGroupApprovalDto>
{
    public UpdateCommunityGroupApprovalValidator(IStringLocalizer<SharedResource> localizer)
    {
        RuleFor(x => x.ApprovalStatus)
            .Must(status => status == GroupApprovalStatus.Approved || status == GroupApprovalStatus.Rejected)
            .WithMessage(localizer["BusinessGroup_ApprovalStatusInvalidMessage"]);

        RuleFor(x => x.RejectedReason)
            .NotEmpty().WithMessage(localizer["BusinessGroup_RejectionReasonRequired"])
            .MaximumLength(500).WithMessage(localizer["BusinessGroup_RejectionReasonMaxLength"])
            .When(x => x.ApprovalStatus == GroupApprovalStatus.Rejected);
    }
}
