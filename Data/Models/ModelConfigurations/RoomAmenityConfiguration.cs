using HotelBookingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class RoomAmenityConfiguration : IEntityTypeConfiguration<RoomAmenity>
{
    public void Configure(EntityTypeBuilder<RoomAmenity> entityBuilder)
    {
        entityBuilder.HasData(
            new RoomAmenity
            {
                RoomId = 1,
                AmenityId = 1
            },
            new RoomAmenity
            {
                RoomId = 1,
                AmenityId = 2
            },
            new RoomAmenity
            {
                RoomId = 1,
                AmenityId = 3
            },
            new RoomAmenity
            {
                RoomId = 2,
                AmenityId = 4
            },
            new RoomAmenity
            {
                RoomId = 2,
                AmenityId = 5
            },
            new RoomAmenity
            {
                RoomId = 2,
                AmenityId = 6
            },
            new RoomAmenity
            {
                RoomId = 3,
                AmenityId = 7
            },
            new RoomAmenity
            {
                RoomId = 3,
                AmenityId = 8
            }
        );
    }
}