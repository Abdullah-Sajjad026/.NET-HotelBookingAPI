
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HotelBookingAPI.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace HotelBookingAPI.Services.AuthenticationService;

public class AuthenticationService : IAuthenticationService
{

    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IConfiguration _configuration;

    public AuthenticationService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    public async Task<IdentityResult> RegisterUserAsync(User user, string password)
    {
        return await _userManager.CreateAsync(user, password);
    }

    public async Task<ClaimsPrincipal> AuthenticateUserAsync(string email, string password)
    {
        var user = await _userManager.FindByEmailAsync(email);

        if (user != null)
        {
            var passwordCheck = await _signInManager.CheckPasswordSignInAsync(user, password, false);

            if (passwordCheck.Succeeded)
            {
                // var claims = new List<Claim>
                // {
                //     new(ClaimTypes.Name, user.UserName),
                //     new(ClaimTypes.Email, user.Email),
                //     new Claim(ClaimTypes.NameIdentifier, user.Id)
                // };

                // var roles = await _userManager.GetRolesAsync(user);

                // foreach(var role in roles)
                // {
                //     claims.Add(new Claim(ClaimTypes.Role, role));
                // }

                // var claimsIdentity = new ClaimsIdentity(claims, "login");

                // return new ClaimsPrincipal(claimsIdentity);

                return await _signInManager.CreateUserPrincipalAsync(user);
            }
        }

        return null;
    }
    public string GenerateJwtToken(ClaimsPrincipal claimsPrincipal)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier).Value),
            new(JwtRegisteredClaimNames.Email, claimsPrincipal.FindFirst(ClaimTypes.Email).Value),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Issuer"],
            signingCredentials: creds,
            claims: claims,
            expires: DateTime.Now.AddDays(7)
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}