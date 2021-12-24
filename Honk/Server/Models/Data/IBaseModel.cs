namespace Honk.Server.Models.Data;

/// <summary>
/// The base interface contract for data models.
/// </summary>
public interface IBaseModel : ITimeTracked
{
    /// <summary>
    /// Unique identifier for this item.
    /// </summary>
    public Guid Id { get; set; }
}
