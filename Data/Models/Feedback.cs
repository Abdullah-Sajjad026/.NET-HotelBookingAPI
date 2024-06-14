using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

public class Feedback
{
    public int FeedbackId { get; set; }
    public int ReservationId { get; set; }

    public int GuestId { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    public string Comment { get; set; }
    public DateTime FeedbackDate { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;

    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Reservation Reservation { get; set; }

    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Guest Guest { get; set; }
}