using Microsoft.AspNetCore.Identity;

namespace HotelBookingAPI.Data.Models;

public class User : IdentityUser
{
    public bool IsActive { get; set; } = true;
    public DateTime LastLogin { get; set; }


    public ICollection<PaymentBatch> PaymentBatches { get; } = new List<PaymentBatch>();
    public ICollection<Guest> Guests { get; set; } = new List<Guest>();
}