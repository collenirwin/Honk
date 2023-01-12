using Honk.Shared.Models;

namespace Honk.Server.Models.Data;

/// <summary>
/// Base class for items that have control over who can view/operate on them.
/// </summary>
public abstract class BasePrivacyRestrictable : BaseModel, IPrivacyRestrictable
{
    /// <inheritdoc />
    public PrivacyLevel ViewPrivacy { get; set; }

    /// <inheritdoc />
    public ICollection<ApplicationUser> ViewUsers { get; set; } = null!;

    /// <inheritdoc />
    public PrivacyLevel ModificationPrivacy { get; set; }

    /// <inheritdoc />
    public ICollection<ApplicationUser> ModificationUsers { get; set; } = null!;

    /// <inheritdoc />
    public PrivacyLevel DeletionPrivacy { get; set; }

    /// <inheritdoc />
    public ICollection<ApplicationUser> DeletionUsers { get; set; } = null!;
}
