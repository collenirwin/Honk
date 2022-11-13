using Honk.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Honk.Client.Services;

// Note: it looks like AuthenticationStateProvider isn't in the newest version of 
// Microsoft.AspNetCore.Components.Authorization... we may want to have a look at the newest version's method of
// keeping authentication state

/// <summary>
/// Custom identity authentication state provider.
/// </summary>
public class IdentityAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly AuthenticationState _anonymous = new(new ClaimsPrincipal(new ClaimsIdentity()));
    private readonly IUserService _userService;
    private UserDto? _cachedUser;

    /// <summary>
    /// Name of the authentication type used.
    /// </summary>
    public const string AuthenticationType = "Identity";

    public IdentityAuthenticationStateProvider(IUserService userService)
    {
        _userService = userService;
    }

    /// <inheritdoc />
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var user = await GetUserAsync();

            if (user is not null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(nameof(user.Id), user.Id)
                };

                var identity = new ClaimsIdentity(claims, AuthenticationType);

                return new AuthenticationState(new ClaimsPrincipal(identity));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception thrown during authentication state check: {ex.Message}");
        }

        return _anonymous;
    }

    /// <summary>
    /// Logs the user into the application.
    /// </summary>
    /// <param name="logInDto">Log in information to send to the server.</param>
    public async Task LogInAsync(LogInDto logInDto)
    {
        await _userService.LogInAsync(logInDto);
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    /// <summary>
    /// Logs the user out of the application.
    /// </summary>
    public async Task LogOutAsync()
    {
        await _userService.LogOutAsync();
        _cachedUser = null;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    /// <summary>
    /// Registers a new user for the application.
    /// </summary>
    /// <param name="registerDto">Registration information to send to the server.</param>
    public async Task RegisterAsync(RegisterDto registerDto)
    {
        await _userService.RegisterAsync(registerDto);
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    private async Task<UserDto> GetUserAsync()
    {
        _cachedUser ??= await _userService.GetUserAsync();
        return _cachedUser;
    }
}
