
using HotelBookingAPI.Data.Models;
using HotelBookingAPI.DTOs.UserDtos;
using HotelBookingAPI.Services.AuthenticationService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    private readonly IAuthenticationService _authenticationService;

    public UserController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterUserAsync([FromBody] RegisterUserDto registerModal)
    {
        var user = new User
        {
            Email = registerModal.Email,
            UserName = registerModal.Email,
        };

        var result = await _authenticationService.RegisterUserAsync(user, registerModal.Password);

        if (result.Succeeded)
        {
            return Ok();
        }

        return BadRequest(result.Errors);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginUserAsync(string email, string password)
    {
        var principal = await _authenticationService.AuthenticateUserAsync(email, password);

        if (principal != null)
        {
            var token = _authenticationService.GenerateJwtToken(principal);
            return Ok(token);
        }

        return Unauthorized(
            new
            {
                message = "Invalid email or password"
            }
        );
    }

    [Authorize]
    [HttpGet("profile")]
    public IActionResult GetUserProfile()
    {
        return Ok(User.Identity.Name);
    }
}