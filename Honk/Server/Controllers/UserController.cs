using Honk.Server.Models.Data;
using Honk.Server.Services;
using Honk.Shared.Models;
using Honk.Shared.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Honk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;

    public UserController(UserManager<ApplicationUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto model)
    {
        if (string.IsNullOrWhiteSpace(model?.UserName) ||
            string.IsNullOrWhiteSpace(model?.Email) ||
            string.IsNullOrWhiteSpace(model?.Password))
        {
            return BadRequest(Messages.InvalidDto);
        }

        if (!Email.IsValid(model.Email))
        {
            return BadRequest(Messages.InvalidEmail);
        }

        var user = new ApplicationUser
        {
            UserName = model.UserName,
            Email = model.Email
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            return Ok();
        }

        // return an internal server error (500) with all error descriptions, newline separated
        return StatusCode(500, string.Join("\n", result.Errors.Select(error => error.Description)));
    }

    [HttpPost("login")]
    public async Task<ActionResult<TokenDto>> LogIn([FromBody] LogInDto model)
    {
        if (string.IsNullOrWhiteSpace(model?.UserName) || string.IsNullOrWhiteSpace(model?.Password))
        {
            return BadRequest(Messages.InvalidDto);
        }

        var user = model.UserName.Contains('@')
            ? await _userManager.FindByEmailAsync(model.UserName)
            : await _userManager.FindByNameAsync(model.UserName);

        if (user is null)
        {
            return AuthenticationFailed(message: Messages.NoUserByThatName);
        }

        if (await _userManager.CheckPasswordAsync(user, model.Password))
        {
            return AuthenticationSuccessful(token: await _tokenService.GenerateTokenAsync(user));
        }

        return AuthenticationFailed(message: Messages.InvalidPassword);
    }

    private static TokenDto AuthenticationSuccessful(string token)
        => new(token, IsAuthenticated: true, Message: "Success.");

    private static TokenDto AuthenticationFailed(string message)
        => new(Token: null, IsAuthenticated: false, message);
}
