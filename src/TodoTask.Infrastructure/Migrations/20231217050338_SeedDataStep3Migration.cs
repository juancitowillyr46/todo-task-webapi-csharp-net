using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class SeedDataStep3Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClientLocations",
                columns: new[] { "Id", "ClientId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Latitude", "Longitude", "Timestamp", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, 1, new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1458), null, new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1461), null, -1m, -2m, new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1460), null });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 845, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 12, 17, 0, 3, 36, 845, DateTimeKind.Local).AddTicks(7221), new DateTime(2023, 12, 17, 0, 3, 36, 845, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2948), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.InsertData(
                table: "DriverLocations",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DriverId", "Latitude", "Longitude", "Timestamp", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1074), null, new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1077), null, 1, -1m, -2m, new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1069), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1076), null });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 844, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 12, 17, 0, 3, 36, 844, DateTimeKind.Local).AddTicks(5830), new DateTime(2023, 12, 17, 0, 3, 36, 844, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2588), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 846, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 12, 17, 0, 3, 36, 846, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 12, 17, 0, 3, 36, 846, DateTimeKind.Local).AddTicks(9125) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 62, DateTimeKind.Local).AddTicks(7550), new DateTime(2023, 12, 17, 0, 2, 6, 62, DateTimeKind.Local).AddTicks(7557), new DateTime(2023, 12, 17, 0, 2, 6, 62, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 61, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 12, 17, 0, 2, 6, 61, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 12, 17, 0, 2, 6, 61, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(4729), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(4736), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(4739), new DateTime(2023, 12, 17, 0, 2, 6, 60, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 2, 6, 63, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 12, 17, 0, 2, 6, 63, DateTimeKind.Local).AddTicks(8517), new DateTime(2023, 12, 17, 0, 2, 6, 63, DateTimeKind.Local).AddTicks(8515) });
        }
    }
}
