using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[Table("RoomTypes")]
[Index(nameof(TypeName), IsUnique = true)]
public class RoomType
{
    public int RoomTypeId { get; set; }
    public required string TypeName { get; set; }
    public required string Description { get; set; }
    public string? AccessibilityFeatures { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public virtual ICollection<Room>? Rooms { get; set; }

}