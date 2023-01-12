using Honk.Shared.Models;

namespace Honk.Server.Models.Data;

/// <summary>
/// Has view, modification, and deletion privacy settings.
/// </summary>
public interface IPrivacyRestrictable
{
    /// <summary>
    /// Level of privacy applied to viewing this item.
    /// </summary>
    PrivacyLevel ViewPrivacy { get; set; }

    /// <summary>
    /// Users who can view this item when <see cref="ViewPrivacy"/> is set to
    /// <see cref="PrivacyLevel.SpecificUsers"/>.
    /// </summary>
    ICollection<ApplicationUser> ViewUsers { get; set; }

    /// <summary>
    /// Level of privacy applied to modification operations on this item.
    /// </summary>
    PrivacyLevel ModificationPrivacy { get; set; }

    /// <summary>
    /// Users who can perform modification operations on this item when <see cref="ModificationPrivacy"/> is set to
    /// <see cref="PrivacyLevel.SpecificUsers"/>.
    /// </summary>
    ICollection<ApplicationUser> ModificationUsers { get; set; }

    /// <summary>
    /// Level of privacy applied to deletion operations on this item.
    /// </summary>
    PrivacyLevel DeletionPrivacy { get; set; }

    /// <summary>
    /// Users who can perform deletion operations on this item when <see cref="DeletionPrivacy"/> is set to
    /// <see cref="PrivacyLevel.SpecificUsers"/>.
    /// </summary>
    ICollection<ApplicationUser> DeletionUsers { get; set; }
}
