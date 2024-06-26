using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

[Table("Payments")]
public class Payment
{
    public int PaymentId { get; set; }
    public int ReservationId { get; set; }
    public int PaymentBatchId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // [ForeignKey(nameof(ReservationId))]
    // public Reservation Reservation { get; set; }

    // [ForeignKey(nameof(PaymentBatchId))]
    // public PaymentBatch PaymentBatch { get; set; }

}