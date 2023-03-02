using AirlineCompanyWebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirlineCompanyWebApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options) 
        { 
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelRental> HotelRental { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().Property(p => p.CarPricePerDay).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<CarRental>().Property(p => p.RentalPrice).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Flight>().Property(p => p.Price).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Hotel>().Property(p => p.HotelPricePerNight).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<HotelRental>().Property(p => p.RentalPrice).HasColumnType("decimal(18,4)");
        }
    }
}
