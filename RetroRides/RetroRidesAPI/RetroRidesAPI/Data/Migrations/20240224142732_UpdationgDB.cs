using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetroRidesAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdationgDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Products",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfManufacture",
                value: new DateTime(2019, 2, 24, 14, 27, 31, 826, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "YearOfManufacture",
                value: new DateTime(2021, 2, 24, 14, 27, 31, 826, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "YearOfManufacture",
                value: new DateTime(2022, 2, 24, 14, 27, 31, 826, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "YearOfManufacture",
                value: new DateTime(2023, 2, 24, 14, 27, 31, 826, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "YearOfManufacture",
                value: new DateTime(2021, 2, 24, 14, 27, 31, 826, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "YearOfManufacture",
                value: new DateTime(2022, 2, 24, 14, 27, 31, 826, DateTimeKind.Utc).AddTicks(1257));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearOfManufacture",
                value: new DateTime(2018, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "YearOfManufacture",
                value: new DateTime(2020, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "YearOfManufacture",
                value: new DateTime(2021, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "YearOfManufacture",
                value: new DateTime(2022, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "YearOfManufacture",
                value: new DateTime(2020, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "YearOfManufacture",
                value: new DateTime(2021, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4045));
        }
    }
}
