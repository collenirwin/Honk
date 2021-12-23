namespace Honk.Shared.Models;

/// <summary>
/// Contains all information required for registering as a new user.
/// </summary>
/// <param name="UserName">User's entered username.</param>
/// <param name="Email">User's entered email address.</param>
/// <param name="Password">User's entered password.</param>
public record RegisterDto(string UserName, string Email, string Password) : LogInDto(UserName, Password);
