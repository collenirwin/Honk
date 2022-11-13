using Honk.Server.Models.Data;
using Honk.Server.Services;
using Honk.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Honk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumController : ControllerBase
{
    private readonly AlbumService _albumService;

    public AlbumController(AlbumService albumService)
    {
        _albumService = albumService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] AlbumDto album)
    {
        var albumModel = new Album
        {
            Name = album.Name,
            Description = album.Description
        };

        await _albumService.CreateAsync(albumModel);
        return Ok();
    }
}
