using Microsoft.AspNetCore.Identity;

namespace Honk.Server.Models.Data;

/// <summary>
/// This application's <see cref="IdentityUser"/> class.
/// </summary>
public class ApplicationUser : IdentityUser, ITimeTracked
{
    /// <summary>
    /// All of the user's friends.
    /// </summary>
    public ICollection<ApplicationUser> Friends { get; set; } = null!;

    /// <summary>
    /// Users this user has blocked.
    /// </summary>
    public ICollection<ApplicationUser> BlockedUsers { get; set; } = null!;

    /// <inheritdoc />
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    public DateTime UpdatedOn { get; set; }
}
