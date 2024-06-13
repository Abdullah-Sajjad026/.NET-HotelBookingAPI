using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

public enum ReservationStatus
{
    Reserved = 1,
    CheckedIn = 2,
    CheckedOut = 3,
    Cancelled = 4

}

[Table("Reservations")]
public class Reservation
{
    public int ReservationId { get; set; }
    public int RoomId { get; set; }

    [Comment("The user who made the reservation")]
    public int UserId { get; set; }

    public DateTime BookingDate { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int NumberOfGuests { get; set; }

    [EnumDataType(typeof(ReservationStatus))]
    public ReservationStatus Status { get; set; } = ReservationStatus.Reserved;

    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


}