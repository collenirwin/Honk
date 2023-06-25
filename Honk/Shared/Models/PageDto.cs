namespace Honk.Shared.Models;

/// <summary>
/// Contains a page of generic items, as well as page some metadata.
/// </summary>
/// <param name="Items">Enumerable of generic items.</param>
/// <param name="PageNumber">Current page number.</param>
/// <param name="ItemCount">Number of items available.</param>
/// <param name="PageCount">Number of pages available.</param>
public record PageDto<TItem>(IEnumerable<TItem> Items, int PageNumber, int ItemCount, int PageCount);
