using Honk.Server.Data;
using Honk.Server.Models.Data;

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
}
