using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

public enum RoomStatus
{
    Available = 1,
    UnderMaintenance = 2,
    Occupied = 3
}

[Table("Rooms")]
public class Room
{
    public int RoomId { get; set; }

    [MaxLength(50)]
    public int RoomNumber { get; set; }
    public int RoomTypeId { get; set; }

    [Precision(10, 2)]
    public decimal Price { get; set; }

    public string? BedType { get; set; }
    public string? ViewType { get; set; }

    [EnumDataType(typeof(RoomStatus))]
    public RoomStatus Status { get; set; } = RoomStatus.Available;

    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // A room belongs to a room type
    public required virtual RoomType RoomType { get; set; }

    // A room can have many amenities
    public virtual ICollection<RoomAmenity>? RoomAmenities { get; set; }
}