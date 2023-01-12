using Honk.Shared.Models;

namespace Honk.Server.Models.Data;

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
