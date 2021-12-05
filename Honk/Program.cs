using Honk.Data;
using Honk.Models;
using Honk.Models.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var jwtConfig = new JwtConfig(
    Secret: builder.Configuration["JwtConfig:Secret"],
    Issuer: builder.Configuration["JwtConfig:Issuer"],
    Audience: builder.Configuration["JwtConfig:Audience"],
    DurationMinutes: int.Parse(builder.Configuration["JwtConfig:DurationMinutes"]));

builder.Services.AddSingleton(jwtConfig);

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
        options.Password = new PasswordOptions
        {
            RequireDigit = false,
            RequireNonAlphanumeric = false,
            RequireLowercase = false,
            RequireUppercase = false
        };

        options.User = new UserOptions
        {
            AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_"
        };
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services
    .AddDbContext<ApplicationDbContext>(options =>
         options.UseNpgsql(
             builder.Configuration.GetConnectionString("Default"),
             builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

builder.Services
    .AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig.Secret)),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = jwtConfig.Issuer,
            ValidAudience = jwtConfig.Audience
        };
    });

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
