using HotelBookingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
{
    public void Configure(EntityTypeBuilder<RoomType> entity)
    {
        entity.HasData(
            new RoomType
            {
                RoomTypeId = 1,
                TypeName = "Single",
                Description = "Single Bed",
                AccessibilityFeatures = "Wheelchair Accessible",
                IsActive = true
            },
            new RoomType
            {
                RoomTypeId = 2,
                TypeName = "Double",
                Description = "Double Bed",
                IsActive = true
            },
            new RoomType
            {
                RoomTypeId = 3,
                TypeName = "Suite",
                Description = "Suite",
                AccessibilityFeatures = "Accessible Bathroom, Wheelchair Accessible, Roll-in Shower",
                IsActive = true
            }
        );
    }
}