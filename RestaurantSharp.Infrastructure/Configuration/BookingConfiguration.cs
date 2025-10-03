using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantSharp.Domain.Models;

namespace RestaurantSharp.Infrastructure.Configuration;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.BookingName).HasMaxLength(100);
        builder.Property(x => x.NumberOfGuests).HasMaxLength(8);
        builder.HasOne(x => x.Table);
    }
}
