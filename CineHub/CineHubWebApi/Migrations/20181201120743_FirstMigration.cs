using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CineHubWebApi.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Cast = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CinemaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screen_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Row = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    ScreenId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_Screen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: false),
                    ScreenId = table.Column<int>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_Screen_ScreenId",
                        column: x => x.ScreenId,
                        principalTable: "Screen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReferenceNumber = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Session_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Session",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeatReservation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeatId = table.Column<int>(nullable: false),
                    BookingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatReservation_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatReservation_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name", "PostCode", "State", "StreetAddress", "Suburb" },
                values: new object[] { 1, "Hoyts Chadston", "3148", "VIC", "1341 Dandenong Road", "Chadstone" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Simon", "012345678" },
                    { 2, "Vaibhav", "88887777" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "Description", "Director", "Duration", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Liam Neeson, Vera Farmiga, Patrick Wilson, Jonathan Banks", "An Insurance Salesman/Ex-Cop is caught up in a criminal conspiracy during his daily commute home.", "Jaume Collet-Serra", "105", "The Commuter", 6.4m },
                    { 2, "Dylan O'Brien, Ki Hong Lee, Kaya Scodelario, Thomas Brodie-Sangster", "Young hero Thomas embarks on a mission to find a cure for a deadly disease known as 'The Flare'.", "Wes Ball", "143", "Maze Runner: The Death Cure", 6.3m },
                    { 3, "Vicky Krieps, Daniel Day-Lewis, Lesley Manville, Julie Vollono", "Set in 1950's London, Reynolds Woodcock is a renowned dressmaker whose fastidious life is disrupted by a young, strong-willed woman, Alma, who becomes his muse and lover.", "Paul Thomas Anderson", "130", "Phantom Thread", 7.4m }
                });

            migrationBuilder.InsertData(
                table: "Screen",
                columns: new[] { "Id", "CinemaId", "Name" },
                values: new object[] { 1, 1, "Screen 1" });

            migrationBuilder.InsertData(
                table: "Screen",
                columns: new[] { "Id", "CinemaId", "Name" },
                values: new object[] { 2, 1, "Screen 2" });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Number", "Row", "ScreenId" },
                values: new object[,]
                {
                    { 1, 1, "A", 1 },
                    { 2, 2, "A", 1 },
                    { 3, 3, "A", 1 },
                    { 4, 1, "B", 1 },
                    { 5, 2, "B", 1 },
                    { 6, 3, "B", 1 },
                    { 12, 3, "B", 2 },
                    { 11, 2, "B", 2 },
                    { 10, 1, "B", 2 },
                    { 9, 3, "A", 2 },
                    { 7, 1, "A", 2 },
                    { 8, 2, "A", 2 }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "MovieId", "Price", "ScreenId", "Time" },
                values: new object[,]
                {
                    { 4, 1, 20m, 1, new DateTime(2018, 12, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 20m, 2, new DateTime(2018, 12, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 15m, 1, new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 1, 20m, 1, new DateTime(2018, 12, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 15m, 1, new DateTime(2018, 12, 26, 23, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, 20m, 2, new DateTime(2018, 12, 26, 20, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "CustomerId", "ReferenceNumber", "SessionId" },
                values: new object[,]
                {
                    { 1, 1, "B123", 1 },
                    { 2, 2, "Z253", 1 },
                    { 3, 1, "P837", 2 },
                    { 4, 2, "S344", 3 }
                });

            migrationBuilder.InsertData(
                table: "SeatReservation",
                columns: new[] { "Id", "BookingId", "SeatId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 2, 5 },
                    { 3, 3, 2 },
                    { 4, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_SessionId",
                table: "Booking",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Screen_CinemaId",
                table: "Screen",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_ScreenId",
                table: "Seat",
                column: "ScreenId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservation_BookingId",
                table: "SeatReservation",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservation_SeatId",
                table: "SeatReservation",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_MovieId",
                table: "Session",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_ScreenId",
                table: "Session",
                column: "ScreenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeatReservation");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Screen");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}
