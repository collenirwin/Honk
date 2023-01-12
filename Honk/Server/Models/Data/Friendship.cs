using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// Represents a pair of users who are friends.
/// </summary>
[Index(nameof(User1Id), nameof(User2Id), IsUnique = true)]
public class Friendship : BaseModel
{
    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the first user.
    /// </summary>
    [ForeignKey(nameof(User1))]
    public string User1Id { get; set; } = null!;

    /// <summary>
    /// The first user.
    /// </summary>
    public ApplicationUser? User1 { get; set; }

    /// <summary>
    /// <see cref="ApplicationUser.Id"/> of the second user.
    /// </summary>
    [ForeignKey(nameof(User2))]
    public string User2Id { get; set; } = null!;

    /// <summary>
    /// The second user.
    /// </summary>
    public ApplicationUser? User2 { get; set; }
}
