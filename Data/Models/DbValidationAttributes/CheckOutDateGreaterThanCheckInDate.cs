
using System.ComponentModel.DataAnnotations;
using HotelBookingAPI.Data.Models;

namespace HotelBookingAPI.Shared.DbValidationAttributes;

public class CheckOutDateGreaterThanCheckInDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var reservation = (Reservation)validationContext.ObjectInstance;

        if (reservation.CheckOutDate <= reservation.CheckInDate)
        {
            return new ValidationResult("Check-out date must be greater than check-in date.");
        }

        return ValidationResult.Success;
    }
}
