
using HotelBookingAPI.Data.Models;
using HotelBookingAPI.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.HasData(new User
        {
            UserId = 1,
            RoleId = 1, // Assuming RoleId 1 exists
            Email = "admin@jabsihotels.com",
            PasswordHash = PasswordHasher.HashPassword("AdminPassword"), // Replace "AdminPassword" with actual admin password
        }
        );
    }
}