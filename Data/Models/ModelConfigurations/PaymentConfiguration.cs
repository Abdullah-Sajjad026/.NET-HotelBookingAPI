using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> entityBuilder)
    {
        entityBuilder.HasData(
            new Payment
            {
                PaymentId = 1,
                ReservationId = 1,
                PaymentBatchId = 1,
                Amount = 50.00m
            },
            new Payment
            {
                PaymentId = 2,
                ReservationId = 1,
                PaymentBatchId = 1,
                Amount = 50.00m
            },
            new Payment
            {
                PaymentId = 3,
                ReservationId = 2,
                PaymentBatchId = 2,
                Amount = 200.00m
            }
        );
    }
}