using System.Net.Mail;

namespace Honk.Shared.Utils;

/// <summary>
/// Contains utility method relating to email addresses.
/// </summary>
public static class Email
{
    /// <summary>
    /// Uses the <see cref="MailAddress"/> class to determine if the passed email is valid.
    /// </summary>
    /// <param name="email">Email address to check.</param>
    /// <returns><see langword="true"/> if the passed email is valid.</returns>
    public static bool IsValid(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        try
        {
            _ = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
