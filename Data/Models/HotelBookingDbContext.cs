using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;
public class HotelBookingDbContext : IdentityDbContext<User>
{

    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options) : base(options) { }

    public DbSet<UserRole> UserRoles { get; set; }
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Room>()
            .HasMany(x => x.Amenities)
            .WithMany(x => x.Rooms)
            .UsingEntity<RoomAmenity>(
                x => x.HasOne(x => x.Amenity).WithMany().HasForeignKey(x => x.AmenityId),
                x => x.HasOne(x => x.Room).WithMany().HasForeignKey(x => x.RoomId)
            ).HasKey(x => new { x.RoomId, x.AmenityId });

        modelBuilder.Entity<Reservation>()
            .HasMany(x => x.Guests)
            .WithMany(s => s.Reservations)
            .UsingEntity<ReservationGuest>(
                x => x.HasOne(a => a.Guest).WithMany().HasForeignKey(a => a.GuestId),
                x => x.HasOne(a => a.Reservation).WithMany().HasForeignKey(a => a.ReservationId)
            ).HasKey(x => new { x.ReservationId, x.GuestId });


        // modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
        // modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
        // modelBuilder.ApplyConfiguration<CountryState>(new CountryStateConfiguration());
        // modelBuilder.ApplyConfiguration<RoomType>(new RoomTypeConfiguration());
        // modelBuilder.ApplyConfiguration<Room>(new RoomConfiguration());
        // modelBuilder.ApplyConfiguration<Amenity>(new AmenityConfiguration());
        // modelBuilder.ApplyConfiguration<RoomAmenity>(new RoomAmenityConfiguration());
        // modelBuilder.ApplyConfiguration<Guest>(new GuestConfiguration());
        // modelBuilder.ApplyConfiguration<Reservation>(new ReservationConfiguration());
        // modelBuilder.ApplyConfiguration<ReservationGuest>(new ReservationGuestConfiguration());
        // modelBuilder.ApplyConfiguration<PaymentBatch>(new PaymentBatchConfiguration());
        // modelBuilder.ApplyConfiguration<Payment>(new PaymentConfiguration());
        // modelBuilder.ApplyConfiguration<Cancellation>(new CancellationConfiguration());
        // modelBuilder.ApplyConfiguration<RefundMethod>(new RefundMethodConfiguration());
        // modelBuilder.ApplyConfiguration<Refund>(new RefundConfiguration());
        // modelBuilder.ApplyConfiguration<Feedback>(new FeedbackConfiguration());

    }
}