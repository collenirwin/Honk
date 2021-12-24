using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents an album of photos.
/// </summary>
public class Album : BaseModel
{
    /// <summary>
    /// The name of the album.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Optional description of the album.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who created the album.
    /// </summary>
    [ForeignKey(nameof(CreatedBy))]
    public Guid CreatedByUserId { get; set; }

    /// <summary>
    /// User who created the album.
    /// </summary>
    public ApplicationUser? CreatedBy { get; set; }

    public Album(string name) => Name = name;
}
