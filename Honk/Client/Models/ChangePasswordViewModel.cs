using System.ComponentModel.DataAnnotations;

namespace Honk.Client.Models;

public class ChangePasswordViewModel
{
    [Display(Name = "Current password")]
    [Required]
    public string? OldPassword { get; set; }

    [Display(Name = "New password")]
    [Required]
    public string? NewPassword { get; set; }
}
