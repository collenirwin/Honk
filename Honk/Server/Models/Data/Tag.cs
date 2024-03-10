using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a tag for a photo or album.
/// </summary>
[Table("tags")]
public class Tag : ITimeTracked
{
    /// <summary>
    /// Unique, case-insensive tag text.
    /// </summary>
    [Key]
    [Column("tag_text")]
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
    [Column("created_on")]
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    [Column("updated_on")]
    public DateTime UpdatedOn { get; set; }
}
