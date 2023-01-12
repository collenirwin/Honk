namespace Honk.Shared.Models;

/// <summary>
/// Represents the level of privacy that is applied to a resource.
/// </summary>
public enum PrivacyLevel
{
    /// <summary>
    /// Only the creator of this item can view it.
    /// </summary>
    CreatorOnly,

    /// <summary>
    /// Only the creator and specific users can view this item.
    /// </summary>
    SpecificUsers,

    /// <summary>
    /// Only the creator and their friends can view this item.
    /// </summary>
    Friends,

    /// <summary>
    /// Anyone can view this item.
    /// </summary>
    Open
}
