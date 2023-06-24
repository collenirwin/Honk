using System.ComponentModel.DataAnnotations;

namespace Honk.Client.Models;

public class AlbumViewModel
{
    [Display(Name = "Title")]
    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public List<string> Tags { get; set; } = new List<string>();
}
