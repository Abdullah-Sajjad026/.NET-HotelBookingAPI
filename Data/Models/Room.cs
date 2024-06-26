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
    public string RoomNumber { get; set; }
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
    public RoomType RoomType { get; set; }

    // A room can have many amenities
    public ICollection<Amenity> Amenities { get; } = new List<Amenity>();
}