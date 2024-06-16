using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class RefundConfiguration : IEntityTypeConfiguration<Refund>
{
    public void Configure(EntityTypeBuilder<Refund> entityBuilder)
    {
        entityBuilder.HasData(
            new Refund
            {
                RefundId = 1,
                Amount = 50.00m,
                Description = "Refund for cancellation",
                PaymentId = 1,
                ProcessedByUserId = 1,
                RefundDate = DateTime.UtcNow,
                RefundMethodId = 1,
            }
        );
    }
}