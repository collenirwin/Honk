using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a notification for a comment on a photo.
/// </summary>
public class PhotoCommentNotification : BaseNotification
{
    /// <summary>
    /// <see cref="PhotoComment.Id"/> of the comment that triggered this notification.
    /// </summary>
    [ForeignKey(nameof(Comment))]
    public Guid CommentId { get; set; }

    /// <summary>
    /// The comment that triggered this notification.
    /// </summary>
    public PhotoComment? Comment { get; set; }
}
