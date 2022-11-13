using Honk.Shared.Models;
using Honk.Shared.Utils;
using System.Net.Http.Json;

namespace Honk.Client.Services;

/// <summary>
/// Performs operations relaing to application users.
/// </summary>
public class UserService : IUserService
{
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <inheritdoc />
    public async Task LogInAsync(LogInDto logInDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/user/login", logInDto);
        await response.EnsureSuccessWithMessageAsync();
    }

    /// <inheritdoc />
    public async Task LogOutAsync()
    {
        var result = await _httpClient.PostAsync("api/user/logout", content: null);
        result.EnsureSuccessStatusCode();
    }

    /// <inheritdoc />
    public async Task RegisterAsync(RegisterDto registerDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/user/register", registerDto);
        await response.EnsureSuccessWithMessageAsync();
    }

    /// <inheritdoc />
    public async Task<UserDto> GetUserAsync()
    {
        var response = await _httpClient.GetAsync("api/user/current");
        response.EnsureSuccessStatusCode();

        var userDto = await response.Content.ReadFromJsonAsync<UserDto>();
        return userDto!;
    }

    /// <inheritdoc />
    public async Task ChangePasswordAsync(ChangePasswordDto changePasswordDto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/user/changepassword", changePasswordDto);
        await response.EnsureSuccessWithMessageAsync();
    }
}
