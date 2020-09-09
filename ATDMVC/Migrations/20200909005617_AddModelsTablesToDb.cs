using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATDMVC.Migrations
{
    public partial class AddModelsTablesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    Intersection = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    CouncilDistrict = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Racks",
                columns: table => new
                {
                    RackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoice = table.Column<int>(nullable: false),
                    InstallDate = table.Column<DateTime>(nullable: false),
                    RacksInstalled = table.Column<int>(nullable: false),
                    RackTypeID = table.Column<int>(nullable: false),
                    RackColor = table.Column<string>(nullable: true),
                    LastInspectionDate = table.Column<DateTime>(nullable: false),
                    Condition = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racks", x => x.RackID);
                });

            migrationBuilder.CreateTable(
                name: "RackTypes",
                columns: table => new
                {
                    RackTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RackTypes", x => x.RackTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Repairs",
                columns: table => new
                {
                    RepairID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairType = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Condition = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    RepairDate = table.Column<DateTime>(nullable: false),
                    InspectionDate = table.Column<DateTime>(nullable: false),
                    NumberRemoved = table.Column<int>(nullable: false),
                    NumberInstalled = table.Column<int>(nullable: false),
                    RackID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairs", x => x.RepairID);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    RequestType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RackID = table.Column<int>(nullable: false),
                    NumberRacksRequested = table.Column<int>(nullable: false),
                    NumberRacksMarked = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    PreliminaryCheck = table.Column<DateTime>(nullable: false),
                    Marked = table.Column<DateTime>(nullable: false),
                    Fulfilled = table.Column<DateTime>(nullable: false),
                    DeniedRequest = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    Intersection = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    CouncilDistrict = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "RackTypes");

            migrationBuilder.DropTable(
                name: "Repairs");

            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
