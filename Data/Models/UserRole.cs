
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace HotelBookingAPI.Data.Models;

[Table("UserRoles")]
public class UserRole : IdentityRole
{
    public bool IsActive { get; set; } = true;

    [MaxLength(255)]
    public required string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
