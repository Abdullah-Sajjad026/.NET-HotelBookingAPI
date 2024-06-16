using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public static IList<Guest> Guests =
    [
       new Guest
            {
                GuestId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com",
                Phone = "1234567890",
                Address = "1234 Elm St",
                Age = 25,
                CountryStateId = 1
            },
            new Guest
            {
                GuestId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "janedoe@example.com",
                Phone = "0987654321",
                Address = "5678 Oak St",
                Age = 30,
                CountryStateId = 2
            },
            new Guest
            {
                GuestId = 3,
                FirstName = "Alice",
                LastName = "Smith",
                Email = "alicesmith@example.com",
                Phone = "1357924680",
                Address = "2468 Pine St",
                Age = 35,
                CountryStateId = 3
            }
    ];

    public void Configure(EntityTypeBuilder<Guest> entityBuilder)
    {
        entityBuilder.HasData(
            Guests
        );
    }
}