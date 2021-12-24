using System.ComponentModel.DataAnnotations;

namespace Honk.Server.Models.Data;

/// <summary>
/// The base class of all data models.
/// </summary>
public class BaseModel : IBaseModel
{
    /// <inheritdoc />
    [Key]
    public Guid Id { get; set; }

    /// <inheritdoc />
    public DateTime CreatedOn { get; set; }

    /// <inheritdoc />
    public DateTime UpdatedOn { get; set; }
}
