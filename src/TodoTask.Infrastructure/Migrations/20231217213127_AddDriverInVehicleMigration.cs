using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddDriverInVehicleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Vehicles_PersonId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Drivers");

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7475), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7472), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7654), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7506), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7522), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles",
                column: "DriverId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(1992), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(1996), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 12, 17, 15, 10, 13, 652, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 12, 17, 15, 10, 13, 653, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Vehicles_PersonId",
                table: "Drivers",
                column: "PersonId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
