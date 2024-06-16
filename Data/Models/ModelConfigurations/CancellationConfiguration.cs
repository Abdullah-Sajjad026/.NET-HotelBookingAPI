using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class CancellationConfiguration : IEntityTypeConfiguration<Cancellation>
{
    public void Configure(EntityTypeBuilder<Cancellation> entityBuilder)
    {
        entityBuilder.HasData(
            new Cancellation
            {
                CancellationId = 1,
                ReservationId = 1,
                CancellationDate = DateTime.UtcNow,
                CancellationFee = 50.00m,
                Reason = "Change of plans",
                Status = CancellationStatus.Pending
            }
        );
    }
}