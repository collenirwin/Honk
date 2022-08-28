using Honk.Shared.Models;
using System.Net.Http.Json;

namespace Honk.Client.Services;

public class AlbumService
{
    private readonly HttpClient _httpClient;

    public AlbumService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task CreateAsync(AlbumDto album)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Album/create", album);
        response.EnsureSuccessStatusCode();
    }
}
