namespace Honk.Shared.Models;

/// <summary>
/// Contains all information required for changing a user's password.
/// </summary>
/// <param name="OldPassword">User's entered old password.</param>
/// <param name="NewPassword">User's entered new password.</param>
public record ChangePasswordDto(string OldPassword, string NewPassword);
