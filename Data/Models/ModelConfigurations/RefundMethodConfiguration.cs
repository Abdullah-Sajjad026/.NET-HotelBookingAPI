using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingAPI.Data.Models.ModelConfigurations;

public class RefundMethodConfiguration : IEntityTypeConfiguration<RefundMethod>
{
    public void Configure(EntityTypeBuilder<RefundMethod> entityBuilder)
    {
        entityBuilder.HasData(
            new RefundMethod
            {
                RefundMethodId = 1,
                Name = "Bank Transfer",
                Description = "Refund via bank transfer",

            },
            new RefundMethod
            {
                RefundMethodId = 2,
                Name = "Credit Card",
                Description = "Refund via credit card",
            }
        );
    }
}