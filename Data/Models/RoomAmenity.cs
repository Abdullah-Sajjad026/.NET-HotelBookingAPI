using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

[Table("RoomAmenities")]
public class RoomAmenity
{
    public int RoomId { get; set; }
    public Room Room { get; set; }

    public int AmenityId { get; set; }
    public Amenity Amenity { get; set; }
}
