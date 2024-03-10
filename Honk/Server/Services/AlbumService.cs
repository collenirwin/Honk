using Honk.Server.Data;
using Honk.Server.Models.Data;
using Microsoft.EntityFrameworkCore;
using ToPage;
using ToPage.EFCore;

namespace Honk.Server.Services;

public class AlbumService
{
    private readonly ApplicationDbContext _context;

    public AlbumService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Album album)
    {
        _context.Set<Album>().Add(album);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Album album)
    {
        var oldAlbum = await GetAsync(album.Id)
            ?? throw new InvalidOperationException("Album to update not found.");

        // do not allow changes to CreatedByUserId
        album.CreatedByUserId = oldAlbum.CreatedByUserId;

        _context.Entry(oldAlbum).CurrentValues.SetValues(album);
        await _context.SaveChangesAsync();
    }

    public async Task<Album?> GetAsync(Guid id)
    {
        return await _context.Albums
            .Where(album => album.Id == id)
            .Include(album => album.Tags)
            .FirstOrDefaultAsync();
    }

    public async Task<IPageWithCounts<Album>> GetPageForUserAsync(string userId, int pageNumber, int itemsPerPage)
    {
        return await _context.Albums
            .Where(album => album.CreatedByUserId == userId)
            .Include(album => album.Tags)
            .OrderBy(album => album.Name)
            .ToPageWithCountsAsync(pageNumber, itemsPerPage);
    }

    public async Task DeleteAsync(Guid id)
    {
        var album = await GetAsync(id);

        if (album is not null)
        {
            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
        }
    }
}
