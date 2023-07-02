using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZaferTurizm.DataAccess.Migrations
{
    public partial class TicketSeedDataAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "BusTripId", "PassengerId", "Price", "SeatNumber" },
                values: new object[] { 1, 1, 1, 500m, 10 });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "BusTripId", "PassengerId", "Price", "SeatNumber" },
                values: new object[] { 2, 2, 2, 550m, 10 });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "BusTripId", "PassengerId", "Price", "SeatNumber" },
                values: new object[] { 3, 3, 3, 650m, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
