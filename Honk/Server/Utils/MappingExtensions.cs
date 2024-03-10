using Honk.Server.Models.Data;
using Honk.Shared.Models;
using ToPage;

namespace Honk.Server.Utils;

public static class MappingExtensions
{
    public static AlbumDto ToDto(this Album album)
    {
        var dto = new AlbumDto(
            album.Name,
            album.Description,
            album.Tags
                .Select(tag => tag.TagText)
                .ToList());

        dto.Id = album.Id;

        return dto;
    }

    public static PageDto<TItem> ToDto<TItem>(this IPageWithCounts page, IEnumerable<TItem> items)
    {
        return new PageDto<TItem>(items, page.PageNumber, page.ItemCount, page.PageCount);
    }
}
