using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZaferTurizm.DataAccess.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passenger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "varchar(15)", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureCityId = table.Column<int>(type: "int", nullable: false),
                    ArrivalCityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_City_ArrivalCityId",
                        column: x => x.ArrivalCityId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Route_City_DepartureCityId",
                        column: x => x.DepartureCityId,
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    VehicleMakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    SeatCount = table.Column<int>(type: "int", nullable: false),
                    HasToilet = table.Column<bool>(type: "bit", nullable: false),
                    HasWifi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleDefinition_VehicleModel_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleDefinitionId = table.Column<int>(type: "int", nullable: false),
                    PlateNumber = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleDefinition_VehicleDefinitionId",
                        column: x => x.VehicleDefinitionId,
                        principalTable: "VehicleDefinition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BusTrip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusTrip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusTrip_Route_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Route",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusTrip_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusTripId = table.Column<int>(type: "int", nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_BusTrip_BusTripId",
                        column: x => x.BusTripId,
                        principalTable: "BusTrip",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ticket_Passenger_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passenger",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 6, "Ankara" },
                    { 7, "Antalya" },
                    { 16, "Bursa" },
                    { 34, "İstanbul" },
                    { 35, "İzmir" }
                });

            migrationBuilder.InsertData(
                table: "Passenger",
                columns: new[] { "Id", "FirstName", "Gender", "IdentityNumber", "LastName" },
                values: new object[,]
                {
                    { 1, "Tsubasa", (byte)2, "12345667874", "Ozora" },
                    { 2, "Sanae", (byte)1, "8764873564", "Ozora" },
                    { 3, "Taro", (byte)2, "3486384743", "Misaki" }
                });

            migrationBuilder.InsertData(
                table: "VehicleMake",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mercedes" },
                    { 2, "MAN" },
                    { 3, "Neoplan" },
                    { 4, "Otokar" },
                    { 5, "Volvo" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "Id", "ArrivalCityId", "DepartureCityId" },
                values: new object[,]
                {
                    { 1, 34, 35 },
                    { 2, 6, 34 },
                    { 3, 7, 34 },
                    { 4, 35, 6 }
                });

            migrationBuilder.InsertData(
                table: "VehicleModel",
                columns: new[] { "Id", "Name", "VehicleMakeId" },
                values: new object[,]
                {
                    { 1, "Travego", 1 },
                    { 2, "403", 1 },
                    { 3, "Tourismo", 1 },
                    { 4, "Lions", 2 },
                    { 5, "Fortuna", 2 },
                    { 6, "SL", 2 }
                });

            migrationBuilder.InsertData(
                table: "VehicleDefinition",
                columns: new[] { "Id", "HasToilet", "HasWifi", "SeatCount", "VehicleModelId", "Year" },
                values: new object[] { 1, false, true, 48, 1, 2020 });

            migrationBuilder.InsertData(
                table: "VehicleDefinition",
                columns: new[] { "Id", "HasToilet", "HasWifi", "SeatCount", "VehicleModelId", "Year" },
                values: new object[] { 2, false, true, 48, 1, 2021 });

            migrationBuilder.InsertData(
                table: "VehicleDefinition",
                columns: new[] { "Id", "HasToilet", "HasWifi", "SeatCount", "VehicleModelId", "Year" },
                values: new object[] { 3, false, false, 52, 5, 2019 });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "PlateNumber", "VehicleDefinitionId" },
                values: new object[,]
                {
                    { 1, "34 ABC 123", 1 },
                    { 2, "34 CDE 654", 1 },
                    { 3, "34 QWE 345", 2 },
                    { 4, "34 ZXC 987", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusTrip_RouteId",
                table: "BusTrip",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_BusTrip_VehicleId",
                table: "BusTrip",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_ArrivalCityId",
                table: "Route",
                column: "ArrivalCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_DepartureCityId",
                table: "Route",
                column: "DepartureCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_BusTripId",
                table: "Ticket",
                column: "BusTripId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerId",
                table: "Ticket",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleDefinitionId",
                table: "Vehicle",
                column: "VehicleDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDefinition_VehicleModelId",
                table: "VehicleDefinition",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_VehicleMakeId",
                table: "VehicleModel",
                column: "VehicleMakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "BusTrip");

            migrationBuilder.DropTable(
                name: "Passenger");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "VehicleDefinition");

            migrationBuilder.DropTable(
                name: "VehicleModel");

            migrationBuilder.DropTable(
                name: "VehicleMake");
        }
    }
}
