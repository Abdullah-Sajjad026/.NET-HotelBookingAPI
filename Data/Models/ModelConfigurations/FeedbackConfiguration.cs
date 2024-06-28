/*
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> entityBuilder)
    {
        entityBuilder.HasData(
            new Feedback
            {
                FeedbackId = 1,
                ReservationId = 1,
                Rating = 5,
                Comment = "Great service!",
                GuestId = 1,
                FeedbackDate = DateTime.UtcNow
            },
            new Feedback
            {
                FeedbackId = 2,
                ReservationId = 2,
                GuestId = 2,
                Rating = 4,
                Comment = "Good service!",
                FeedbackDate = DateTime.UtcNow
            }
        );
    }
}
*/