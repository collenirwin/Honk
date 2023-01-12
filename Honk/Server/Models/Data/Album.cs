using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents an album of photos.
/// </summary>
[Index(nameof(Name), nameof(CreatedByUserId), IsUnique = true)]
public class Album : BasePrivacyRestrictable
{
    /// <summary>
    /// The name of the album.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Optional description of the album.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who created the album.
    /// </summary>
    [ForeignKey(nameof(CreatedBy))]
    public string CreatedByUserId { get; set; } = null!;

    /// <summary>
    /// User who created the album.
    /// </summary>
    public ApplicationUser? CreatedBy { get; set; }

    /// <summary>
    /// Tags on this album.
    /// </summary>
    public ICollection<Tag> Tags { get; set; } = null!;

    /// <summary>
    /// Comments on this album.
    /// </summary>
    public ICollection<Comment> Comments { get; set; } = null!;
}
