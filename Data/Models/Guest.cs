using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

public enum GuestAgeGroup
{
    Infant = 0,
    Child = 1,
    Adult = 2,
    Senior = 3
}

[Table("Guests")]
public class Guest
{
    public int GuestId { get; set; }
    // Foreign key to the User table by convention
    public int UserId { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Address { get; set; }

    public GuestAgeGroup AgeGroup { get { return Age switch { < 2 => GuestAgeGroup.Infant, < 18 => GuestAgeGroup.Child, < 60 => GuestAgeGroup.Adult, _ => GuestAgeGroup.Senior }; } }

    public int Age { get; set; }
    [ForeignKey("Country")]
    public int CountryId { get; set; }
    public int CountryStateId { get; set; }

    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual Country Country { get; set; }
    public virtual CountryState CountryState { get; set; }
    public virtual User User { get; set; }
}