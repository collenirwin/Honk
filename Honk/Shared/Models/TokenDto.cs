namespace Honk.Shared.Models;

/// <summary>
/// Contains a token string, and information passed from the issuer.
/// </summary>
/// <param name="Token">The token string.</param>
/// <param name="IsAuthenticated">Is the audience authenticated?</param>
/// <param name="Message">Message from the issuer.</param>
public record TokenDto(string? Token, bool IsAuthenticated, string? Message = null);
