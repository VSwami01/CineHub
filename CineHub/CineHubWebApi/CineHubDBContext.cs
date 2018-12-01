
using CineHubWebApi.Models;
using Microsoft.EntityFrameworkCore;


namespace CineHubWebApi
{
    public class CineHubDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CineHubDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasOne<Movie>(s => s.Movie)
                .WithMany(m => m.Sessions)
                .HasForeignKey(s => s.MovieId);
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasOne<Screen>(s => s.Screen)
                .WithMany(m => m.Sessions)
                .HasForeignKey(s => s.ScreenId);
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.HasOne<Cinema>(s => s.Cinema)
                .WithMany(m => m.Screens)
                .HasForeignKey(s => s.CinemaId);
            });


            modelBuilder.Entity<Seat>(entity =>
            {
                entity.HasOne<Screen>(s => s.Screen)
                .WithMany(m => m.Seats)
                .HasForeignKey(s => s.ScreenId);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasOne<Customer>(b => b.Customer)
                .WithMany(m => m.Bookings)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasOne<Session>(s => s.Session)
                .WithMany(m => m.Bookings)
                .HasForeignKey(s => s.SessionId)
                .OnDelete(DeleteBehavior.Restrict); 
            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity.HasOne<Screen>(s => s.Screen)
                .WithMany(m => m.Seats)
                .HasForeignKey(s => s.ScreenId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SeatReservation>(entity =>
            {
                entity.HasOne<Seat>(s => s.Seat)
                .WithMany(m => m.SeatReservations)
                .HasForeignKey(s => s.SeatId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SeatReservation>(entity =>
            {
                entity.HasOne<Booking>(s => s.Booking)
                .WithMany(m => m.SeatReservations)
                .HasForeignKey(s => s.BookingId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Seed();
        }
    }
}
