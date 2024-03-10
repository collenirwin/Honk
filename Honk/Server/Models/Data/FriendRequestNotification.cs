using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a friend request notification.
/// </summary>
[Table("friend_request_notifications")]
public class FriendRequestNotification : BaseNotification
{
    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who is requesting to be friends with the <see cref="For"/> user.
    /// </summary>
    [ForeignKey(nameof(Requestor))]
    [Column("requestor_user_id")]
    public string RequestorUserId { get; set; } = null!;

    /// <summary>
    /// The user who is requesting to be friends with the <see cref="For"/> user.
    /// </summary>
    public ApplicationUser? Requestor { get; set; }
}
