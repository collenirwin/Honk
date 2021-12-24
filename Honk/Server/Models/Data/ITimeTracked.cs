namespace Honk.Server.Models.Data;

/// <summary>
/// Has <see cref="CreatedOn"/> and <see cref="UpdatedOn"/> audit properties.
/// </summary>
public interface ITimeTracked
{
    /// <summary>
    /// Date this item was created.
    /// </summary>
    DateTime CreatedOn { get; set; }

    /// <summary>
    /// Date this item was last updated.
    /// </summary>
    DateTime UpdatedOn { get; set; }
}
