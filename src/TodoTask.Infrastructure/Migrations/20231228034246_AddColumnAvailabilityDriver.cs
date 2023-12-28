using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddColumnAvailabilityDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Vehicles");

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Drivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7644), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7645), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7643), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(5943), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(5946), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7514), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7515), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7512), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9992), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9994), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9843), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 12, 27, 22, 42, 45, 940, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(6936), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(6939), new DateTime(2023, 12, 27, 22, 42, 45, 941, DateTimeKind.Local).AddTicks(6938) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Drivers");

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(3090), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 291, DateTimeKind.Local).AddTicks(8610), new DateTime(2023, 12, 27, 20, 23, 7, 291, DateTimeKind.Local).AddTicks(8619), new DateTime(2023, 12, 27, 20, 23, 7, 291, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2131), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2134), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 291, DateTimeKind.Local).AddTicks(1667), new DateTime(2023, 12, 27, 20, 23, 7, 291, DateTimeKind.Local).AddTicks(1678), new DateTime(2023, 12, 27, 20, 23, 7, 291, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(1762), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(1771), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 12, 27, 20, 23, 7, 290, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(1454), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(1462), new DateTime(2023, 12, 27, 20, 23, 7, 292, DateTimeKind.Local).AddTicks(1460) });
        }
    }
}
