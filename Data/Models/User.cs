
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[Table("Users")]
[Index(nameof(Email), IsUnique = true)]
public class User
{
    [Key]
    public int UserId { get; set; }
    public int RoleId { get; set; }
    [MaxLength(100)]
    public required string Email { get; set; }
    [MaxLength(255)]
    public required string PasswordHash { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastLogin { get; set; }

    // A user must be associated with a role
    public UserRole Role { get; set; }
    public ICollection<PaymentBatch> PaymentBatches { get; } = new List<PaymentBatch>();
}