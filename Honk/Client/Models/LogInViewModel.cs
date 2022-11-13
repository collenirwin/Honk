using System.ComponentModel.DataAnnotations;

namespace Honk.Client.Models;

public class LogInViewModel
{
    [Display(Name = "Username or email address")]
    [Required]
    public string? UserName { get; set; }

    [Required]
    public string? Password { get; set; }
}
