using Honk.Client;
using Honk.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IdentityAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(
    sp => sp.GetRequiredService<IdentityAuthenticationStateProvider>());

var baseUri = new Uri(builder.HostEnvironment.BaseAddress);
var httpClientName = "Honk.ServerAPI";

builder.Services.AddHttpClient(httpClientName, client => client.BaseAddress = baseUri);
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(httpClientName));

builder.Services.AddScoped<AlbumService>();

await builder.Build().RunAsync();
