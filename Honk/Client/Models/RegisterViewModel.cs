using System.ComponentModel.DataAnnotations;

namespace Honk.Client.Models;

public class RegisterViewModel
{
    [Display(Name = "Username")]
    [Required]
    public string? UserName { get; set; }

    [EmailAddress]
    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    [Display(Name = "Confirm password")]
    [Required]
    [Compare(nameof(Password), ErrorMessage = "Password mismatch.")]
    public string? ConfirmedPassword { get; set; }
}
