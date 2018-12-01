﻿// <auto-generated />
using System;
using CineHubWebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CineHubWebApi.Migrations
{
    [DbContext(typeof(CineHubDBContext))]
    [Migration("20181201120743_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CineHubWebApi.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("ReferenceNumber");

                    b.Property<int>("SessionId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SessionId");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            ReferenceNumber = "B123",
                            SessionId = 1
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            ReferenceNumber = "Z253",
                            SessionId = 1
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 1,
                            ReferenceNumber = "P837",
                            SessionId = 2
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            ReferenceNumber = "S344",
                            SessionId = 3
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("PostCode");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Suburb");

                    b.HasKey("Id");

                    b.ToTable("Cinema");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hoyts Chadston",
                            PostCode = "3148",
                            State = "VIC",
                            StreetAddress = "1341 Dandenong Road",
                            Suburb = "Chadstone"
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Simon",
                            PhoneNumber = "012345678"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vaibhav",
                            PhoneNumber = "88887777"
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast");

                    b.Property<string>("Description");

                    b.Property<string>("Director");

                    b.Property<string>("Duration");

                    b.Property<string>("Name");

                    b.Property<decimal>("Rating");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "Liam Neeson, Vera Farmiga, Patrick Wilson, Jonathan Banks",
                            Description = "An Insurance Salesman/Ex-Cop is caught up in a criminal conspiracy during his daily commute home.",
                            Director = "Jaume Collet-Serra",
                            Duration = "105",
                            Name = "The Commuter",
                            Rating = 6.4m
                        },
                        new
                        {
                            Id = 2,
                            Cast = "Dylan O'Brien, Ki Hong Lee, Kaya Scodelario, Thomas Brodie-Sangster",
                            Description = "Young hero Thomas embarks on a mission to find a cure for a deadly disease known as 'The Flare'.",
                            Director = "Wes Ball",
                            Duration = "143",
                            Name = "Maze Runner: The Death Cure",
                            Rating = 6.3m
                        },
                        new
                        {
                            Id = 3,
                            Cast = "Vicky Krieps, Daniel Day-Lewis, Lesley Manville, Julie Vollono",
                            Description = "Set in 1950's London, Reynolds Woodcock is a renowned dressmaker whose fastidious life is disrupted by a young, strong-willed woman, Alma, who becomes his muse and lover.",
                            Director = "Paul Thomas Anderson",
                            Duration = "130",
                            Name = "Phantom Thread",
                            Rating = 7.4m
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Screen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("Screen");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 1,
                            Name = "Screen 1"
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 1,
                            Name = "Screen 2"
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number");

                    b.Property<string>("Row");

                    b.Property<int>("ScreenId");

                    b.HasKey("Id");

                    b.HasIndex("ScreenId");

                    b.ToTable("Seat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Number = 1,
                            Row = "A",
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 2,
                            Number = 2,
                            Row = "A",
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 3,
                            Number = 3,
                            Row = "A",
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 4,
                            Number = 1,
                            Row = "B",
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 5,
                            Number = 2,
                            Row = "B",
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 6,
                            Number = 3,
                            Row = "B",
                            ScreenId = 1
                        },
                        new
                        {
                            Id = 7,
                            Number = 1,
                            Row = "A",
                            ScreenId = 2
                        },
                        new
                        {
                            Id = 8,
                            Number = 2,
                            Row = "A",
                            ScreenId = 2
                        },
                        new
                        {
                            Id = 9,
                            Number = 3,
                            Row = "A",
                            ScreenId = 2
                        },
                        new
                        {
                            Id = 10,
                            Number = 1,
                            Row = "B",
                            ScreenId = 2
                        },
                        new
                        {
                            Id = 11,
                            Number = 2,
                            Row = "B",
                            ScreenId = 2
                        },
                        new
                        {
                            Id = 12,
                            Number = 3,
                            Row = "B",
                            ScreenId = 2
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.SeatReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingId");

                    b.Property<int>("SeatId");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("SeatId");

                    b.ToTable("SeatReservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookingId = 1,
                            SeatId = 4
                        },
                        new
                        {
                            Id = 2,
                            BookingId = 2,
                            SeatId = 5
                        },
                        new
                        {
                            Id = 3,
                            BookingId = 3,
                            SeatId = 2
                        },
                        new
                        {
                            Id = 4,
                            BookingId = 4,
                            SeatId = 3
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ScreenId");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("ScreenId");

                    b.ToTable("Session");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            Price = 20m,
                            ScreenId = 1,
                            Time = new DateTime(2018, 12, 25, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            Price = 15m,
                            ScreenId = 1,
                            Time = new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            Price = 20m,
                            ScreenId = 2,
                            Time = new DateTime(2018, 12, 25, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 1,
                            Price = 20m,
                            ScreenId = 1,
                            Time = new DateTime(2018, 12, 26, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 2,
                            Price = 15m,
                            ScreenId = 1,
                            Time = new DateTime(2018, 12, 26, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            MovieId = 3,
                            Price = 20m,
                            ScreenId = 2,
                            Time = new DateTime(2018, 12, 26, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CineHubWebApi.Models.Booking", b =>
                {
                    b.HasOne("CineHubWebApi.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CineHubWebApi.Models.Session", "Session")
                        .WithMany("Bookings")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CineHubWebApi.Models.Screen", b =>
                {
                    b.HasOne("CineHubWebApi.Models.Cinema", "Cinema")
                        .WithMany("Screens")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CineHubWebApi.Models.Seat", b =>
                {
                    b.HasOne("CineHubWebApi.Models.Screen", "Screen")
                        .WithMany("Seats")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CineHubWebApi.Models.SeatReservation", b =>
                {
                    b.HasOne("CineHubWebApi.Models.Booking", "Booking")
                        .WithMany("SeatReservations")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CineHubWebApi.Models.Seat", "Seat")
                        .WithMany("SeatReservations")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CineHubWebApi.Models.Session", b =>
                {
                    b.HasOne("CineHubWebApi.Models.Movie", "Movie")
                        .WithMany("Sessions")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CineHubWebApi.Models.Screen", "Screen")
                        .WithMany("Sessions")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}