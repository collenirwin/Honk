namespace Honk.Shared.Models;

/// <summary>
/// Represents a user of the application.
/// </summary>
/// <param name="Id">Database primary key value for the application user record.</param>
/// <param name="UserName">User's username.</param>
/// <param name="Email">User's email address.</param>
/// <param name="CreatedOn">Date the user was created.</param>
public record UserDto(string Id, string UserName, string Email, DateTime CreatedOn);
