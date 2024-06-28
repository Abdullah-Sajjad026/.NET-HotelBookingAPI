/*
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class ReservationGuestConfiguration : IEntityTypeConfiguration<ReservationGuest>
{
    public void Configure(EntityTypeBuilder<ReservationGuest> entityBuilder)
    {
        entityBuilder.HasData(
            new ReservationGuest
            {
                ReservationId = 1,
                GuestId = 1
            },
            new ReservationGuest
            {
                ReservationId = 1,
                GuestId = 2
            },
            new ReservationGuest
            {
                ReservationId = 2,
                GuestId = 3
            }
        );
    }
}
*/