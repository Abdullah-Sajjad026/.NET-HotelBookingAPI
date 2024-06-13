
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[Table("Countries")]
[Index(nameof(CountryCode), IsUnique = true)]
public class Country
{
    // Primary Key by convention
    public int CountryId { get; set; }
    [MaxLength(100)]
    public required string CountryName { get; set; }
    [MaxLength(10)]
    public required string CountryCode { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<CountryState>? States { get; } = new List<CountryState>();
}