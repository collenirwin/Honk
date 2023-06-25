using Honk.Shared.Models;
using Honk.Shared.Utils;
using System.Net.Http.Json;

namespace Honk.Client.Services;

public class AlbumService
{
    private readonly HttpClient _httpClient;

    public AlbumService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Guid> CreateAsync(AlbumDto album)
    {
        var response = await _httpClient.PostAsJsonAsync("api/album/create", album);
        await response.EnsureSuccessWithMessageAsync();

        var dto = await response.Content.ReadFromJsonAsync<ValueDto<Guid>>();
        return dto!.Value;
    }

    public async Task UpdateAsync(Guid id, AlbumDto album)
    {
        var response = await _httpClient.PostAsJsonAsync($"api/album/update/{id}", album);
        await response.EnsureSuccessWithMessageAsync();
    }

    public async Task<AlbumDto> GetAsync(Guid id)
    {
        var response = await _httpClient.GetAsync($"api/album/get/{id}");
        response.EnsureSuccessStatusCode();

        var albumDto = await response.Content.ReadFromJsonAsync<AlbumDto>();
        return albumDto!;
    }

    public async Task DeleteAsync(Guid id)
    {
        var response = await _httpClient.DeleteAsync($"api/album/delete/{id}");
        await response.EnsureSuccessWithMessageAsync();
    }
}
