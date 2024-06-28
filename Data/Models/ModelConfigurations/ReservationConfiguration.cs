/*
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> entityBuilder)
    {
        entityBuilder
            .HasMany(r => r.Guests)
            .WithMany(g => g.Reservations)
            .UsingEntity<ReservationGuest>(
               l => l.HasOne(r => r.Guest).WithMany().HasForeignKey(r => r.GuestId),
                r => r.HasOne(g => g.Reservation).WithMany().HasForeignKey(g => g.ReservationId)
            );

        entityBuilder.HasData(
            new Reservation
            {
                ReservationId = 1,
                RoomId = 1,
                BookingDate = DateTime.UtcNow,
                CheckInDate = DateTime.UtcNow.AddDays(1),
                CheckOutDate = DateTime.UtcNow.AddDays(3),
                NumberOfGuests = 2,
                Status = ReservationStatus.Reserved,
                UserId = 1
            },
            new Reservation
            {
                ReservationId = 2,
                RoomId = 2,
                BookingDate = DateTime.UtcNow,
                CheckInDate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(1)),
                CheckOutDate = DateTime.UtcNow.AddDays(2),
                NumberOfGuests = 1,
                Status = ReservationStatus.CheckedIn,
                UserId = 1
            },
            new Reservation
            {
                ReservationId = 3,
                RoomId = 3,
                BookingDate = DateTime.UtcNow,
                CheckInDate = DateTime.UtcNow.AddDays(2),
                CheckOutDate = DateTime.UtcNow.AddDays(4),
                NumberOfGuests = 3,
                Status = ReservationStatus.Cancelled,
                UserId = 1
            }
        );
    }
}
*/