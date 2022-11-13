using Microsoft.AspNetCore.Identity;

namespace Honk.Server.Models.Data;

/// <summary>
/// This application's <see cref="IdentityUser"/> class.
/// </summary>
public class ApplicationUser : IdentityUser, ITimeTracked
{
    /// <inheritdoc />
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    public DateTime UpdatedOn { get; set; }
}
