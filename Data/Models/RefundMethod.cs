namespace HotelBookingAPI.Data.Models;

public class RefundMethod
{
    public int RefundMethodId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}