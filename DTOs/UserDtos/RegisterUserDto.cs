using System.ComponentModel.DataAnnotations;

namespace HotelBookingAPI.DTOs.UserDtos;
// public record RegisterUserDto(string Email, string Password, string FirstName, string LastName);

public class RegisterUserDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}