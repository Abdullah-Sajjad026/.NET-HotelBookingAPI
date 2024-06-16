using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[PrimaryKey(nameof(ReservationId), nameof(GuestId))]
public class ReservationGuest
{
    public int ReservationId { get; set; }
    public Reservation Reservation { get; set; }

    public int GuestId { get; set; }
    public Guest Guest { get; set; }
}