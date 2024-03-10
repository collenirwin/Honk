namespace Honk.Shared.Models;

/// <summary>
/// Contains a single generic value.
/// </summary>
/// <param name="Value">Generic valud.</param>
public record ValueDto<TValue>(TValue Value);
