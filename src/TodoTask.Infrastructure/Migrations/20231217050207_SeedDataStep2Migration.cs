using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class SeedDataStep2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLocations_Drivers_DriverId",
                table: "DriverLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Drivers_DriverId",
                table: "Requests");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "PersonId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 1, new DateTime(2023, 12, 17, 0, 2, 6, 62, DateTimeKind.Local).AddTicks(7550), null, new DateTime(2023, 12, 17, 0, 2, 6, 62, DateTimeKind.Local).AddTicks(7557), null, 2, new DateTime(2023, 12, 17, 0, 2, 6, 62, DateTimeKind.Local).AddTicks(7555), null, 2 });

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

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "LicenseNumber", "PersonId", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 1, new DateTime(2023, 12, 17, 0, 2, 6, 61, DateTimeKind.Local).AddTicks(7073), null, new DateTime(2023, 12, 17, 0, 2, 6, 61, DateTimeKind.Local).AddTicks(7082), null, "", 1, new DateTime(2023, 12, 17, 0, 2, 6, 61, DateTimeKind.Local).AddTicks(7080), null, 1 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLocations_Drivers_DriverId",
                table: "DriverLocations",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Drivers_DriverId",
                table: "Requests",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverLocations_Drivers_DriverId",
                table: "DriverLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Drivers_DriverId",
                table: "Requests");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3718), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3724), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3758), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3770), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 16, 23, 58, 15, 50, DateTimeKind.Local).AddTicks(9395), new DateTime(2023, 12, 16, 23, 58, 15, 50, DateTimeKind.Local).AddTicks(9414), new DateTime(2023, 12, 16, 23, 58, 15, 50, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.AddForeignKey(
                name: "FK_DriverLocations_Drivers_DriverId",
                table: "DriverLocations",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Drivers_DriverId",
                table: "Requests",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
