namespace Honk.Server.Models;

/// <summary>
/// Contains configuration properties for JWT.
/// </summary>
/// <param name="Secret">Secret for use in the IssuerSigningKey.</param>
/// <param name="Issuer">Value for ValidIssuer.</param>
/// <param name="Audience">Value for ValidAudience.</param>
/// <param name="DurationMinutes">Duration the token is valid, in minutes.</param>
public record JwtConfig(string Secret, string Issuer, string Audience, int DurationMinutes);
