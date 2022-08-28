using System.ComponentModel.DataAnnotations;

namespace Honk.Client.Models;

public class AlbumViewModel
{
    [Display(Name = "Album name")]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Album description")]
    public string? Description { get; set; }
}
