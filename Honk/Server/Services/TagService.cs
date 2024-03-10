using Honk.Server.Data;
using Honk.Server.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Honk.Server.Services;

public class TagService
{
    private readonly ApplicationDbContext _context;

    public TagService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Tag tag)
    {
        tag.TagText = tag.TagText.ToLower();
        var existingTag = await GetAsync(tag.TagText);
        if (existingTag is not null)
        {
            _context.Set<Tag>().Add(tag);
            await _context.SaveChangesAsync();
        }
    }


    public async Task<Tag?> GetAsync(string tagText)
    {
        return await _context.Tags
            .Where(tag => tag.TagText == tagText)
            .FirstOrDefaultAsync();
    }

}
