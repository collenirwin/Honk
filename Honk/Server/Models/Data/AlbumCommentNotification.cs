using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a notification for a comment on an album.
/// </summary>
[Table("album_comment_notifications")]
public class AlbumCommentNotification : BaseNotification
{
    /// <summary>
    /// <see cref="AlbumComment.Id"/> of the comment that triggered this notification.
    /// </summary>
    [ForeignKey(nameof(Comment))]
    [Column("comment_id")]
    public Guid CommentId { get; set; }

    /// <summary>
    /// The comment that triggered this notification.
    /// </summary>
    public AlbumComment? Comment { get; set; }
}
