using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineHubWebApi.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Director { get; set; }

        public string Cast { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        public decimal Rating { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

    }

    public class Session
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int ScreenId { get; set; }

        public DateTime Time { get; set; }

        public Decimal Price { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Screen Screen { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }

    public class Cinema
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string Suburb { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public virtual ICollection<Screen> Screens { get; set; }
    }

    public class Screen
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }

    public class Booking
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; }

        public int CustomerId { get; set; }

        public int SessionId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Session Session { get; set; }

        public virtual ICollection<SeatReservation> SeatReservations { get; set; }
    }

    public class Seat
    {
        //eg H12. row H, number 12
        public int Id { get; set; }

        public string Row { get; set; }

        public int Number { get; set; }

        public int ScreenId { get; set; }

        public virtual Screen Screen { get; set; }

        public virtual ICollection<SeatReservation> SeatReservations { get; set; }
        
    }

    public class SeatReservation
    {
        public int Id { get; set; }

        public int SeatId { get; set; }

        public int BookingId { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
