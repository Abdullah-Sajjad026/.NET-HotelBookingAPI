
using HotelBookingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {

            builder.HasData(
                new UserRole
                {
                    RoleId = 1,
                    RoleName = "Admin",
                    Description = "Admin role has full access to all resources",
                },
                new UserRole
                {
                    RoleId = 2,
                    RoleName = "User",
                    Description = "User role has limited access to resources",
                }
            );

        }
    }
}