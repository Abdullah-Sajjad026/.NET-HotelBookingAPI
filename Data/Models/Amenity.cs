using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

[Table("Amenities")]
public class Amenity
{
    public int AmenityId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Room> Rooms { get; } = new List<Room>();
}