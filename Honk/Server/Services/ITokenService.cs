using Honk.Server.Models.Data;

namespace Honk.Server.Services;

/// <summary>
/// Provides the capability to generate token strings.
/// </summary>
public interface ITokenService
{
    /// <summary>
    /// Generates a token string.
    /// </summary>
    /// <param name="user">User the token is for.</param>
    /// <returns>The generated token string.</returns>
    Task<string> GenerateTokenAsync(ApplicationUser user);
}
