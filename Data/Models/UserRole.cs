
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

[Table("UserRoles")]
public class UserRole
{
    [Key]
    public int RoleId { get; set; }
    [MaxLength(50)]
    public required string RoleName { get; set; }
    public bool IsActive { get; set; } = true;
    [MaxLength(255)]
    public required string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<User> Users { get; } = new List<User>();
}
