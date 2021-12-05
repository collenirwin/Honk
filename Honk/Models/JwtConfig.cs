namespace Honk.Models;

public record JwtConfig(string Secret, string Issuer, string Audience, int DurationMinutes);
