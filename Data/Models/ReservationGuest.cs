
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

[Table("ReservationGuests")]
public class ReservationGuest
{
    public int ReservationGuestId { get; set; }
    public int ReservationId { get; set; }
    public int GuestId { get; set; }

    public virtual Reservation Reservation { get; set; }
    public virtual Guest Guest { get; set; }
}