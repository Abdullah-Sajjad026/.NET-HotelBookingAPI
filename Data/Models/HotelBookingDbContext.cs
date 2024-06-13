using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;
public class HotelBookingDbContext : DbContext
{

    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options) : base(options) { }

    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<CountryState> CountryStates { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Amenity> Amenities { get; set; }
    public DbSet<RoomAmenity> RoomAmenities { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationGuest> ReservationGuests { get; set; }
    public DbSet<PaymentBatch> PaymentBatches { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Cancellation> Cancellations { get; set; }
    public DbSet<RefundMethod> RefundMethods { get; set; }
    public DbSet<Refund> Refunds { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }

    // onmodelconfiguring
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}