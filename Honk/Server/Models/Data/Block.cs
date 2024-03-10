using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a pair of users. One user has blocked the other.
/// </summary>
[Table("blocks")]
public class Block : BaseModel
{
    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who blocked the other user.
    /// </summary>
    [ForeignKey(nameof(BlockedBy))]
    [Column("blocked_by_user_id")]
    public string BlockedByUserId { get; set; } = null!;

    /// <summary>
    /// The user who is blocking the other user.
    /// </summary>
    public ApplicationUser? BlockedBy { get; set; }

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who is being blocked.
    /// </summary>
    [ForeignKey(nameof(Blocked))]
    [Column("blocked_user_id")]
    public string BlockedUserId { get; set; } = null!;

    /// <summary>
    /// The user who is being blocked.
    /// </summary>
    public ApplicationUser? Blocked { get; set; }
}
