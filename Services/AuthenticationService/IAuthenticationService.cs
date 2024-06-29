using System.Security.Claims;
using HotelBookingAPI.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace HotelBookingAPI.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        public Task<IdentityResult> RegisterUserAsync(User user, string password);

        public Task<ClaimsPrincipal> AuthenticateUserAsync(string email, string password);

        public string GenerateJwtToken(ClaimsPrincipal claimsPrincipal);
    }
}