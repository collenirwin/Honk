using Honk.Shared.Models;

namespace Honk.Client.Services;

/// <summary>
/// Performs operations relaing to application users.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Logs the user into the application.
    /// </summary>
    /// <param name="logInDto">Log in information to send to the server.</param>
    Task LogInAsync(LogInDto logInDto);

    /// <summary>
    /// Logs the user out of the application.
    /// </summary>
    Task LogOutAsync();

    /// <summary>
    /// Registers a new user for the application.
    /// </summary>
    /// <param name="registerDto">Registration information to send to the server.</param>
    Task RegisterAsync(RegisterDto registerDto);

    /// <summary>
    /// Gets information about the currently logged in user.
    /// </summary>
    /// <returns>User information.</returns>
    Task<UserDto> GetUserAsync();

    /// <summary>
    /// Changes the user's password to the one provided.
    /// </summary>
    /// <param name="changePasswordDto">Password change information to send to the server.</param>
    Task ChangePasswordAsync(ChangePasswordDto changePasswordDto);
}
