/*
using HotelBookingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> typeBuilder)
    {
        typeBuilder.HasData(
            new Country
            {
                CountryId = 1,
                CountryName = "United States",
                CountryCode = "US"
            },
            new Country
            {
                CountryId = 2,
                CountryName = "Canada",
                CountryCode = "CA"
            },
            new Country
            {
                CountryId = 3,
                CountryName = "United Kingdom",
                CountryCode = "UK"
            },
               new Country
               {
                   CountryId = 4,
                   CountryName = "Pakistan",
                   CountryCode = "PK"
               }
        );
    }
}
*/