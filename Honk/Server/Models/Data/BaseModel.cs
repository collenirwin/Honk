using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honk.Server.Models.Data;

/// <summary>
/// The base class of all data models.
/// </summary>
public class BaseModel : IBaseModel
{
    /// <inheritdoc />
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    /// <inheritdoc />
    [Column("created_on")]
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    [Column("updated_on")]
    public DateTime UpdatedOn { get; set; }
}
