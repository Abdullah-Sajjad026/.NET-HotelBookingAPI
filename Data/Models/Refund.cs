using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

public enum RefundStatus
{
    Pending,
    Approved,
    Rejected
}

[Table("Refunds")]
public class Refund
{
    public int RefundId { get; set; }
    public int RefundMethodId { get; set; }
    public int PaymentId { get; set; }

    [ForeignKey(nameof(User))]
    public int ProcessedByUserId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }
    public DateTime RefundDate { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public RefundMethod RefundMethod { get; set; }
    public Payment Payment { get; set; }
    public User ProcessedByUser { get; set; }
}