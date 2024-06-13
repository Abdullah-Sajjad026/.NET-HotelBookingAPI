using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[PrimaryKey(nameof(RoomId), nameof(AmenityId))]
public class RoomAmenity
{
    public int RoomId { get; set; }

    public int AmenityId { get; set; }
}