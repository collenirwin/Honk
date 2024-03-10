using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Base model for comments.
/// </summary>
public abstract class BaseComment : BaseModel
{
    /// <summary>
    /// The text of the comment.
    /// </summary>
    [Column("text")]
    public string Text { get; set; } = null!;

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the user who created this comment.
    /// </summary>
    [ForeignKey(nameof(CreatedBy))]
    [Column("created_by_user_id")]
    public string CreatedByUserId { get; set; } = null!;

    /// <summary>
    /// The user who created this comment.
    /// </summary>
    public ApplicationUser? CreatedBy { get; set; }
}
