using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class RemoveColumnVehicleIdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Vehicles_VehiculeId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_VehiculeId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "VehiculeId",
                table: "Devices");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculeId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2237), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7632), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2094), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(4088), new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7648), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7526), new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_VehiculeId",
                table: "Devices",
                column: "VehiculeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Vehicles_VehiculeId",
                table: "Devices",
                column: "VehiculeId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
