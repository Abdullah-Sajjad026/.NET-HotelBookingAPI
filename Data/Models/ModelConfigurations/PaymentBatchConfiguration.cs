/*
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class PaymentBatchConfiguration : IEntityTypeConfiguration<PaymentBatch>
{
    public void Configure(EntityTypeBuilder<PaymentBatch> entityBuilder)
    {
        entityBuilder.HasData(
            new PaymentBatch
            {
                PaymentBatchId = 1,
                UserId = 1,
                PaymentDate = DateTime.UtcNow,
                TotalAmount = 100.00m,
                IsPaid = true,
            },
            new PaymentBatch
            {
                PaymentBatchId = 2,
                UserId = 1,
                PaymentDate = DateTime.UtcNow,
                TotalAmount = 200.00m,
                IsPaid = true,
            }
        );
    }
}
*/