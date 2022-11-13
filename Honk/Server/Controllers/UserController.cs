using Honk.Server.Models.Data;
using Honk.Shared.Models;
using Honk.Shared.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Honk.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public UserController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
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
            // log the user in after a successful registration
            return await LogIn(new(model.UserName, model.Password));
        }

        // return an internal server error (500) with all error descriptions, newline separated
        return StatusCode(500, string.Join("\n", result.Errors.Select(error => error.Description)));
    }

    [HttpPost("login")]
    public async Task<IActionResult> LogIn([FromBody] LogInDto model)
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
            return Unauthorized(Messages.NoUserByThatName);
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, lockoutOnFailure: false);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: true);

            var _ = User;

            return Ok();
        }

        return Unauthorized(Messages.InvalidPassword);
    }

    [HttpPost("logout")]
    public async Task<IActionResult> LogOut()
    {
        await _signInManager.SignOutAsync();
        return Ok();
    }

    [HttpGet("current")]
    [Authorize]
    public async Task<ActionResult<UserDto>> Current()
    {
        var user = await _userManager.GetUserAsync(User);

        return new UserDto(user.Id, user.UserName, user.Email, user.CreatedOn);
    }

    [HttpPost("changepassword")]
    [Authorize]
    public async Task<IActionResult> ChangePassword(ChangePasswordDto model)
    {
        if (string.IsNullOrWhiteSpace(model?.OldPassword) || string.IsNullOrWhiteSpace(model?.NewPassword))
        {
            return BadRequest(Messages.InvalidDto);
        }

        var user = await _userManager.GetUserAsync(User);
        var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

        if (result.Succeeded)
        {
            return Ok();
        }

        // return an internal server error (500) with all error descriptions, newline separated
        return StatusCode(500, string.Join("\n", result.Errors.Select(error => error.Description)));
    }
}
