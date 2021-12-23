namespace Honk.Shared.Models;

/// <summary>
/// Contains all information required for logging in.
/// </summary>
/// <param name="UserName">User's entered username.</param>
/// <param name="Password">User's entered password.</param>
public record LogInDto(string UserName, string Password);
