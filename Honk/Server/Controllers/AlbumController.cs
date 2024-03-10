using EntityFramework.Exceptions.Common;
using Honk.Server.Models.Data;
using Honk.Server.Services;
using Honk.Server.Utils;
using Honk.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToPage;

namespace Honk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlbumController : ControllerBase
{
    private readonly AlbumService _albumService;
    private readonly TagService _tagService;

    public AlbumController(AlbumService albumService, TagService tagService)
    {
        _albumService = albumService;
        _tagService = tagService;
    }

    [HttpPost("create")]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] AlbumDto album)
    {
        var tagInserts = new List<Task>();
        foreach (var tagText in album.Tags)
        {
            var tag = new Tag
            {
                TagText = tagText,
            };
            tagInserts.Add(_tagService.CreateAsync(tag));
        }
        

        var albumModel = new Album
        {
            Name = album.Name,
            Description = album.Description,
            CreatedByUserId = User.FindFirstValue(ClaimTypes.NameIdentifier)!
        };

        try
        {
            await _albumService.CreateAsync(albumModel);
            await Task.WhenAll(tagInserts);

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

        var dto = album.ToDto();
        return Ok(dto);
    }

    [HttpGet("get-own/{pageNumber}")]
    public async Task<IActionResult> GetOwn(int pageNumber, [FromQuery] int itemsPerPage)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var page = await _albumService.GetPageForUserAsync(userId!, pageNumber, itemsPerPage);
        var dtoPage = page.ToDto(page.Items.Select(album => album.ToDto()));

        return Ok(dtoPage);
    }

    [HttpDelete("delete/{id:guid}")]
    [Authorize]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _albumService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
