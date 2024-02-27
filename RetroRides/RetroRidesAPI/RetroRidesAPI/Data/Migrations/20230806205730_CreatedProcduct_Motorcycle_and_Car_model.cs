using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RetroRidesAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedProcduct_Motorcycle_and_Car_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentRun = table.Column<int>(type: "int", nullable: false),
                    EngineDisplacement = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Car_Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: true),
                    AlloyWheels = table.Column<bool>(type: "bit", nullable: true),
                    EntertainmentSystem = table.Column<bool>(type: "bit", nullable: true),
                    NavigationSystem = table.Column<bool>(type: "bit", nullable: true),
                    AirConditioning = table.Column<bool>(type: "bit", nullable: true),
                    BrakeSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABS = table.Column<bool>(type: "bit", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BluetoothConnectivity = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CurrentRun", "Description", "EngineDisplacement", "ImageUrl", "Manufacturer", "ModelName", "Price", "ProductType", "YearOfManufacture" },
                values: new object[,]
                {
                    { 1, 5621, "This is a sample product description.", 150, "sample-image-url-1.jpg", "Sample Manufacturer", "Sample Product 1", 1000L, "Product", new DateTime(2018, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(3893) },
                    { 2, 780, "This is another sample product description.", 250, "sample-image-url-2.jpg", "Another Manufacturer", "Sample Product 2", 1500L, "Product", new DateTime(2020, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(3901) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AirConditioning", "AlloyWheels", "CarType", "CurrentRun", "Description", "DriveType", "EngineDisplacement", "EntertainmentSystem", "ImageUrl", "Manufacturer", "ModelName", "NavigationSystem", "Price", "ProductType", "SeatingCapacity", "Car_Transmission", "YearOfManufacture" },
                values: new object[,]
                {
                    { 3, true, true, "Sedan", 4000, "This is a sample car description.", "Front-Wheel Drive", 2000, true, "sample-car-image-1.jpg", "Car Manufacturer", "Sample Car 1", true, 20000L, "Car", 5, "Automatic", new DateTime(2021, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4015) },
                    { 4, true, true, "Hatchback", 50000, "This is another sample car description.", "Rear-Wheel Drive", 1800, true, "sample-car-image-2.jpg", "Another Car Manufacturer", "Sample Car 2", false, 25000L, "Car", 4, "Manual", new DateTime(2022, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4021) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ABS", "BluetoothConnectivity", "BrakeSystem", "CurrentRun", "Description", "EngineDisplacement", "ImageUrl", "Manufacturer", "ModelName", "Price", "ProductType", "Transmission", "YearOfManufacture" },
                values: new object[,]
                {
                    { 5, true, false, "Disc", 12000, "This is a sample motorcycle description.", 1000, "sample-motorcycle-image-1.jpg", "Motorcycle Manufacturer", "Sample Motorcycle 1", 8000L, "Motorcycle", "Manual", new DateTime(2020, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4041) },
                    { 6, false, true, "Drum", 5000, "This is another sample motorcycle description.", 750, "sample-motorcycle-image-2.jpg", "Another Motorcycle Manufacturer", "Sample Motorcycle 2", 6000L, "Motorcycle", "Manual", new DateTime(2021, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4045) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
