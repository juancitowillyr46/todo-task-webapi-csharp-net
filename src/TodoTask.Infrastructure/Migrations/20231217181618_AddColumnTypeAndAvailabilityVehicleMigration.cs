using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddColumnTypeAndAvailabilityVehicleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "DeletedAt", "Type", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1543), 1, new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1542) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6568), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6443), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2251), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2112), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(5919) });
        }
    }
}
