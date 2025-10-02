
using Microsoft.EntityFrameworkCore;
using RestaurantSharp.Domain.Models;
using RestaurantSharp.Infrastructure.Configuration;

namespace RestaurantSharp.Infrastructure;

public class RestaurantContext : DbContext
{
    public DbSet<Bill> Bills { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Table> Tables { get; set }

    public RestaurantContext(DbContextOptions options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BillConfiguration());
        modelBuilder.ApplyConfiguration(new BookingConfiguration());
        modelBuilder.ApplyConfiguration(new MenuItemConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }
}
