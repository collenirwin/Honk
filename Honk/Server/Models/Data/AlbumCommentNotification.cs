using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a notification for a comment on an album.
/// </summary>
public class AlbumCommentNotification : BaseNotification
{
    /// <summary>
    /// <see cref="AlbumComment.Id"/> of the comment that triggered this notification.
    /// </summary>
    [ForeignKey(nameof(Comment))]
    public Guid CommentId { get; set; }

    /// <summary>
    /// The comment that triggered this notification.
    /// </summary>
    public AlbumComment? Comment { get; set; }
}
