/*
using HotelBookingAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class CountryStateConfiguration : IEntityTypeConfiguration<CountryState>
{
    public void Configure(EntityTypeBuilder<CountryState> typeBuilder)
    {
        typeBuilder.HasData(
            new CountryState
            {
                CountryStateId = 1,
                CountryId = 1,
                StateName = "California",
                StateCode = "CA"
            },
            new CountryState
            {
                CountryStateId = 2,
                CountryId = 1,
                StateName = "New York",
                StateCode = "NY"
            },
            new CountryState
            {
                CountryStateId = 3,
                CountryId = 2,
                StateName = "Ontario",
                StateCode = "ON"
            },
            new CountryState
            {
                CountryStateId = 4,
                CountryId = 2,
                StateName = "Quebec",
                StateCode = "QC"
            },
            new CountryState
            {
                CountryStateId = 5,
                CountryId = 3,
                StateName = "England",
                StateCode = "ENG"
            },
            new CountryState
            {
                CountryStateId = 6,
                CountryId = 3,
                StateName = "Scotland",
                StateCode = "SCT"
            },
            new CountryState
            {
                CountryStateId = 7,
                CountryId = 4,
                StateName = "Punjab",
                StateCode = "PB"
            },
            new CountryState
            {
                CountryStateId = 8,
                CountryId = 4,
                StateName = "Sindh",
                StateCode = "SD"
            }
        );
    }
}
*/