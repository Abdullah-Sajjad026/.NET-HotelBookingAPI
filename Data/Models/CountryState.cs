
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;

[Table("CountryStates")]
[Index(nameof(StateCode), IsUnique = true)]
public class CountryState
{
    // Primary Key by convention
    public int CountryStateId { get; set; }
    [MaxLength(100)]
    public required string StateName { get; set; }
    [MaxLength(10)]
    public required string StateCode { get; set; }
    public int CountryId { get; set; }
    public virtual required Country Country { get; set; }
}