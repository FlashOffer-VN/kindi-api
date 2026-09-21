using Kindi.API.Shared.Exceptions;
using Kindi.API.Shared.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Shared.Exceptions;

public static class CollaboratorException
{
    public static KindiException NotFound(IStringLocalizer<ExceptionMessages> localizer, Guid id)
        => new KindiException(
            statusCode: "COLLABORATOR_NOT_FOUND",
            message: localizer["Collaborator_NotFound", id],
            additionalData: new { Id = id }
        );

    public static KindiException EmailAlreadyExists(IStringLocalizer<ExceptionMessages> localizer, string email)
        => new KindiException(
            statusCode: "COLLABORATOR_EMAIL_EXISTS",
            message: localizer["Collaborator_EmailAlreadyExists", email],
            additionalData: new { Email = email }
        );

    public static KindiException PhoneAlreadyExists(IStringLocalizer<ExceptionMessages> localizer, string phone)
        => new KindiException(
            statusCode: "COLLABORATOR_PHONE_EXISTS",
            message: localizer["Collaborator_PhoneAlreadyExists", phone],
            additionalData: new { Phone = phone }
        );

    public static KindiException UserAlreadyExists(IStringLocalizer<ExceptionMessages> localizer, Guid userId)
        => new KindiException(
            statusCode: "COLLABORATOR_USER_EXISTS",
            message: localizer["Collaborator_UserAlreadyExists", userId],
            additionalData: new { UserId = userId }
        );

    public static KindiException ParentNotFound(IStringLocalizer<ExceptionMessages> localizer, Guid parentId)
        => new KindiException(
            statusCode: "COLLABORATOR_PARENT_NOT_FOUND",
            message: localizer["Collaborator_ParentNotFound", parentId],
            additionalData: new { ParentId = parentId }
        );

    public static KindiException ParentNotApproved(IStringLocalizer<ExceptionMessages> localizer, Guid parentId)
        => new KindiException(
            statusCode: "COLLABORATOR_PARENT_NOT_APPROVED",
            message: localizer["Collaborator_ParentNotApproved", parentId],
            additionalData: new { ParentId = parentId }
        );

    public static KindiException LevelExceeded(IStringLocalizer<ExceptionMessages> localizer, int maxLevel)
        => new KindiException(
            statusCode: "COLLABORATOR_LEVEL_EXCEEDED",
            message: localizer["Collaborator_LevelExceeded", maxLevel],
            additionalData: new { MaxLevel = maxLevel }
        );

    public static KindiException CircularReference(IStringLocalizer<ExceptionMessages> localizer, Guid parentId)
        => new KindiException(
            statusCode: "COLLABORATOR_CIRCULAR_REFERENCE",
            message: localizer["Collaborator_CircularReference", parentId],
            additionalData: new { ParentId = parentId }
        );
}