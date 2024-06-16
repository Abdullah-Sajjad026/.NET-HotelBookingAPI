using HotelBookingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> entity)
    {
        entity
            .HasMany(r => r.Amenities)
            .WithMany(a => a.Rooms)
            .UsingEntity<RoomAmenity>(
                    l => l.HasOne(a => a.Amenity).WithMany(),
                    r => r.HasOne(b => b.Room).WithMany()
            );

        entity.HasData(
            new Room
            {
                RoomId = 1,
                RoomNumber = "101",
                RoomTypeId = 1,
                Price = 100,
                BedType = "Single",
                ViewType = "City",
                Status = RoomStatus.Available
            },
            new Room
            {
                RoomId = 2,
                RoomNumber = "102",
                RoomTypeId = 2,
                Price = 150,
                BedType = "Double",
                ViewType = "Sea",
                Status = RoomStatus.Available
            },
            new Room
            {
                RoomId = 3,
                RoomNumber = "103",
                RoomTypeId = 3,
                Price = 200,
                BedType = "King",
                ViewType = "Mountain",
                Status = RoomStatus.Available
            }
        );
    }
}