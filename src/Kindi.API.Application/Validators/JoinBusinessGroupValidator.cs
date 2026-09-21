using FluentValidation;
using Kindi.API.Application.DTOs.requests;
using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Validators;

public class JoinBusinessGroupValidator : AbstractValidator<JoinBusinessGroupRequest>
{
    public JoinBusinessGroupValidator(IStringLocalizer<SharedResource> localizer)
    {
        // Khách chưa đăng nhập bắt buộc có Họ tên + SĐT — service kiểm tra theo trạng thái đăng nhập.
        RuleFor(x => x.FullName)
            .MaximumLength(100).WithMessage(localizer["BusinessGroup_FullNameMaxLength"]);

        RuleFor(x => x.Phone)
            .MaximumLength(15).WithMessage(localizer["BusinessGroup_PhoneMaxLength"]);

        RuleFor(x => x.Zalo)
            .MaximumLength(15).WithMessage(localizer["BusinessGroup_PhoneMaxLength"]);

        RuleFor(x => x.Email)
            .EmailAddress().WithMessage(localizer["BusinessGroup_EmailInvalid"])
            .MaximumLength(100).WithMessage(localizer["BusinessGroup_EmailMaxLength"])
            .When(x => !string.IsNullOrWhiteSpace(x.Email));

        RuleFor(x => x.Note)
            .MaximumLength(1000).WithMessage(localizer["BusinessGroup_NoteMaxLength"]);
    }
}
