using CineHubWebApi.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace CineHubWebApi
{
    public class CineHubInitializer : CreateDatabaseIfNotExists<CineHubDBContext>
    {
        protected void Seed(CineHubDBContext context)
        {
            #region Default Movies

            IList<Movie> defaultMovies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Name = "The Commuter",
                    Director = "Jaume Collet-Serra",
                    Cast = "Liam Neeson, Vera Farmiga, Patrick Wilson, Jonathan Banks",
                    Duration = "105",
                    Description = "An Insurance Salesman/Ex-Cop is caught up in a criminal conspiracy during his daily commute home.",
                    Rating = 6.4m
                },

                new Movie()
                {
                    Id = 2,
                    Name = "Maze Runner: The Death Cure",
                    Director = "Wes Ball",
                    Cast = "Dylan O'Brien, Ki Hong Lee, Kaya Scodelario, Thomas Brodie-Sangster",
                    Duration = "143",
                    Description = "Young hero Thomas embarks on a mission to find a cure for a deadly disease known as 'The Flare'.",
                    Rating = 6.3m
                },

                new Movie()
                {
                    Id = 3,
                    Name = "Phantom Thread",
                    Director = "Paul Thomas Anderson",
                    Cast = "Vicky Krieps, Daniel Day-Lewis, Lesley Manville, Julie Vollono",
                    Duration = "130",
                    Description = "Set in 1950's London, Reynolds Woodcock is a renowned dressmaker whose fastidious life is disrupted by a young, strong-willed woman, Alma, who becomes his muse and lover.",
                    Rating = 7.4m
                }
            };

            #endregion

            #region Default Cinemas

            IList<Cinema> defaultCinemas = new List<Cinema>()
            {
                new Cinema()
                {
                    Id = 1,
                    Name = "Hoyts Chadston",
                    StreetAddress = "1341 Dandenong Road",
                    Suburb = "Chadstone",
                    State = "VIC",
                    PostCode = "3148"
                }
            };

            #endregion

            #region Default Screens

            IList<Screen> defaultScreens = new List<Screen>()
            {
                new Screen()
                {
                    Id = 1,
                    Name = "Screen 1",
                    CinemaId = 1
                },

                new Screen()
                {
                    Id = 2,
                    Name = "Screen 2",
                    CinemaId = 1
                }
            };

            #endregion

            #region Default Sessions

            IList<Session> defaultSessions = new List<Session>()
            {
                new Session()
                {
                    Id = 1,
                    MovieId = 1,
                    ScreenId = 1,
                    Price = 20,
                    Time = new DateTime(2018,12,25,20,0,0)
                },

                new Session()
                {
                    Id = 2,
                    MovieId = 2,
                    ScreenId = 1,
                    Price = 15,
                    Time = new DateTime(2018,12,25,23,0,0)
                },

                new Session()
                {
                    Id = 3,
                    MovieId = 3,
                    ScreenId = 2,
                    Price = 20,
                    Time = new DateTime(2018,12,25,20,0,0)
                },

                new Session()
                {
                    Id = 4,
                    MovieId = 1,
                    ScreenId = 1,
                    Price = 20,
                    Time = new DateTime(2018,12,26,20,0,0)
                },

                new Session()
                {
                    Id = 5,
                    MovieId = 2,
                    ScreenId = 1,
                    Price = 15,
                    Time = new DateTime(2018,12,26,23,0,0)
                },

                new Session()
                {
                    Id = 6,
                    MovieId = 3,
                    ScreenId = 2,
                    Price = 20,
                    Time = new DateTime(2018,12,26,20,0,0)
                }
            };

            #endregion

            #region Default Customers

            IList<Customer> defaultCustomer = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Simon",
                    PhoneNumber = "012345678"
                },

                new Customer()
                {
                    Id = 2,
                    Name = "Vaibhav",
                    PhoneNumber = "88887777"
                }

            };

            #endregion

            #region Default Bookings

            IList<Booking> defaultBooking = new List<Booking>()
            {
                new Booking()
                {
                    Id = 1,
                    CustomerId = 1,
                    ReferenceNumber = "B123",
                    SessionId = 1
                },
                new Booking()
                {
                    Id = 2,
                    CustomerId=2,
                    ReferenceNumber = "Z253",
                    SessionId = 1
                },
                new Booking()
                {
                    Id = 3,
                    CustomerId = 1,
                    ReferenceNumber = "P837",
                    SessionId = 2
                },
                new Booking()
                {
                    Id = 4,
                    CustomerId=2,
                    ReferenceNumber = "S344",
                    SessionId = 3
                }
            };

            #endregion

            #region Default Seats

            IList<Seat> defaultSeats = new List<Seat>()
            {
                new Seat()
                {
                    Id = 1,
                    Row = "A",
                    Number = 1,
                    ScreenId = 1
                },
                new Seat()
                {
                    Id = 2,
                    Row = "A",
                    Number = 2,
                    ScreenId = 1
                },
                new Seat()
                {
                    Id = 3,
                    Row = "A",
                    Number = 3,
                    ScreenId = 1
                },
                new Seat()
                {
                    Id = 4,
                    Row = "B",
                    Number = 1,
                    ScreenId = 1
                },
                new Seat()
                {
                    Id = 5,
                    Row = "B",
                    Number = 2,
                    ScreenId = 1
                },
                new Seat()
                {
                    Id = 6,
                    Row = "B",
                    Number = 3,
                    ScreenId = 1
                },
                new Seat()
                {
                    Id = 7,
                    Row = "A",
                    Number = 1,
                    ScreenId = 2
                },
                new Seat()
                {
                    Id = 8,
                    Row = "A",
                    Number = 2,
                    ScreenId = 2
                },
                new Seat()
                {
                    Id = 9,
                    Row = "A",
                    Number = 3,
                    ScreenId = 2
                },
                new Seat()
                {
                    Id = 10,
                    Row = "B",
                    Number = 1,
                    ScreenId = 2
                },
                new Seat()
                {
                    Id = 11,
                    Row = "B",
                    Number = 2,
                    ScreenId = 2
                },
                new Seat()
                {
                    Id = 12,
                    Row = "B",
                    Number = 3,
                    ScreenId = 2
                }
            };

            #endregion

            #region Default Seat Reservation

            IList<SeatReservation> defaultSeatReservation = new List<SeatReservation>()
            {
                new SeatReservation()
                {
                    Id = 1,
                    BookingId = 1,
                    SeatId = 4
                },
                new SeatReservation()
                {
                    Id = 2,
                    BookingId = 2,
                    SeatId = 5
                },
                new SeatReservation()
                {
                    Id = 3,
                    BookingId = 3,
                    SeatId = 2
                },
                new SeatReservation()
                {
                    Id = 4,
                    BookingId = 4,
                    SeatId = 3
                },
            };

            #endregion

            base.Seed(context);
        }
    }
}
