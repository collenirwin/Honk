using System.ComponentModel.DataAnnotations;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a tag for a photo or album.
/// </summary>
public class Tag : ITimeTracked
{
    /// <summary>
    /// Unique, case-insensive tag text.
    /// </summary>
    [Key]
    public string TagText { get; set; } = null!;

    /// <summary>
    /// Photos with this tag.
    /// </summary>
    public ICollection<Photo> Photos { get; set; } = null!;

    /// <summary>
    /// Albums with this tag.
    /// </summary>
    public ICollection<Album> Albums { get; set; } = null!;

    /// <inheritdoc />
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    public DateTime UpdatedOn { get; set; }
}
