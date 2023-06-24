using EntityFramework.Exceptions.Common;
using Honk.Server.Models.Data;
using Honk.Server.Services;
using Honk.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
    [Authorize]
    public async Task<IActionResult> Create([FromBody] AlbumDto album)
    {
        var albumModel = new Album
        {
            Name = album.Name,
            Description = album.Description,
            CreatedByUserId = User.FindFirstValue(ClaimTypes.NameIdentifier)!
        };

        try
        {
            await _albumService.CreateAsync(albumModel);
            return Ok(new ValueDto<Guid>(albumModel.Id));
        }
        catch (UniqueConstraintException)
        {
            return StatusCode(500, $"Album \"{album.Name}\" already exists.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost("update/{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Update(Guid id, [FromBody] AlbumDto album)
    {
        var albumModel = new Album
        {
            Id = id,
            Name = album.Name,
            Description = album.Description
        };

        try
        {
            await _albumService.UpdateAsync(albumModel);
            return Ok();
        }
        catch (UniqueConstraintException)
        {
            return StatusCode(500, $"Album \"{album.Name}\" already exists.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("get/{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Get(Guid id)
    {
        var album = await _albumService.GetAsync(id);

        if (album is null)
        {
            return NotFound();
        }

        var dto = new AlbumDto(
            album.Name,
            album.Description,
            album.Tags
                .Select(tag => tag.TagText)
                .ToList());

        return Ok(dto);
    }
}
