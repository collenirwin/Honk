using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Base class for notifications.
/// </summary>
public abstract class BaseNotification : BaseModel
{
    /// <summary>
    /// Has the user read the notification?
    /// </summary>
    public bool Read { get; set; }

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who this notification is for.
    /// </summary>
    [ForeignKey(nameof(For))]
    public string ForUserId { get; set; } = null!;

    /// <summary>
    /// The user who this notification is for.
    /// </summary>
    public ApplicationUser? For { get; set; }
}
