using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Data.Models;

public enum CancellationStatus
{
    Pending,
    Approved,
    Rejected
}

public class Cancellation
{
    public int CancellationId { get; set; }
    public int ReservationId { get; set; }
    public DateTime CancellationDate { get; set; } = DateTime.UtcNow;
    public string Reason { get; set; }

    [EnumDataType(typeof(CancellationStatus))]
    public CancellationStatus Status { get; set; } = CancellationStatus.Pending;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CancellationFee { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Reservation Reservation { get; set; }
}