namespace Honk.Shared.Utils;

/// <summary>
/// Contains extension methods for <see cref="HttpResponseMessage"/> objects.
/// </summary>
public static class HttpResponseMessageExtensions
{
    /// <summary>
    /// Throws an exception that includes the <see cref="HttpResponseMessage.Content"/> if
    /// <see cref="HttpResponseMessage.IsSuccessStatusCode"/> is false.
    /// </summary>
    /// <param name="response">HTTP response.</param>
    /// <exception cref="HttpRequestException">
    /// Thrown when <see cref="HttpResponseMessage.IsSuccessStatusCode"/> is false.
    /// The message is set to the response content.
    /// </exception>
    public static async Task EnsureSuccessWithMessageAsync(this HttpResponseMessage response)
    {
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(
                await response.Content.ReadAsStringAsync(),
                inner: null,
                response.StatusCode);
        }
    }
}
