using Honk.Server.Models;
using Honk.Server.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Honk.Server.Services;

/// <summary>
/// Handles creation and packaging of JWTs.
/// </summary>
public class JwtService : ITokenService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly JwtConfig _jwtConfig;

    public JwtService(UserManager<ApplicationUser> userManager, JwtConfig jwtConfig)
    {
        _userManager = userManager;
        _jwtConfig = jwtConfig;
    }

    /// <summary>
    /// Generates a JWT for the passed user for use in authorization.
    /// </summary>
    /// <param name="user">User to generate a token for.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="user"/> is null.</exception>
    /// <returns>The JWT string.</returns>
    public async Task<string> GenerateTokenAsync(ApplicationUser user)
    {
        ArgumentNullException.ThrowIfNull(user);

        var claims = (await _userManager.GetClaimsAsync(user))
            .Union(new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("uid", user.Id)
            });

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Secret));

        var token = new JwtSecurityToken(
            issuer: _jwtConfig.Issuer,
            audience: _jwtConfig.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_jwtConfig.DurationMinutes),
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha512));

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
