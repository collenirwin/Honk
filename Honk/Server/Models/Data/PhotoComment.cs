using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a comment on a photo.
/// </summary>
public class PhotoComment : BaseComment
{
    /// <summary>
    /// <see cref="Photo.Id"/> of the photo this comment is on.
    /// </summary>
    [ForeignKey(nameof(Photo))]
    public Guid PhotoId { get; set; }

    /// <summary>
    /// The photo this comment is on.
    /// </summary>
    public Photo? Photo { get; set; }
}
