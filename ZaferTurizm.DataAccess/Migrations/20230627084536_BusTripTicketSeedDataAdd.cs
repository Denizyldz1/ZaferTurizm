using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZaferTurizm.DataAccess.Migrations
{
    public partial class BusTripTicketSeedDataAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusTrip",
                columns: new[] { "Id", "Date", "Price", "RouteId", "VehicleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 1, 1 },
                    { 2, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, 2, 2 },
                    { 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 650m, 3, 3 },
                    { 4, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 750m, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusTrip",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusTrip",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusTrip",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BusTrip",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
