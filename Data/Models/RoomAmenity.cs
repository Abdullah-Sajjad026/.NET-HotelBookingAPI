using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[Table("RoomAmenities")]
[PrimaryKey(nameof(RoomId), nameof(AmenityId))]
public class RoomAmenity
{
    public int RoomId { get; set; }

    public Room Room { get; set; }

    public int AmenityId { get; set; }
    public Amenity Amenity { get; set; }
}
