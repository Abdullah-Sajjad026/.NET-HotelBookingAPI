using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Data.Models;
public class HotelBookingDbContext : DbContext
{

    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options) : base(options) { }



}