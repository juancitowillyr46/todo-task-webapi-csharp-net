using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class SeedDataStep1Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Name", "UpdatedAt", "UpdatedBy", "VehiculeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3715), null, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3718), null, "Iphone Driver", new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3716), null, null },
                    { 2, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3721), null, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3724), null, "Iphone Client", new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3722), null, null }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DocumentNumber", "DocumentType", "Email", "FirstName", "LastName", "SecondLastName", "SecondName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3758), null, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3761), null, "", 0, "Driver@gmail.com", "Driver FirstName", "Driver LastName", "Driver SecondLastName", "Driver SecondName", new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3760), null },
                    { 2, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3767), null, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3770), null, "", 0, "client@gmail.com", "Client FirstName", "Client LastName", "Client SecondLastName", "Client SecondName", new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3768), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Blocked", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "FullName", "Password", "UpdatedAt", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3416), null, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3435), null, "driver@gmail.com", "User Driver", "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW", new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3430), null, "driver@gmail.com" },
                    { 2, false, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3443), null, new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3446), null, "client@gmail.com", "User Client", "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW", new DateTime(2023, 12, 16, 23, 58, 15, 47, DateTimeKind.Local).AddTicks(3445), null, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DeviceId", "PlateNumber", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2023, 12, 16, 23, 58, 15, 50, DateTimeKind.Local).AddTicks(9395), null, new DateTime(2023, 12, 16, 23, 58, 15, 50, DateTimeKind.Local).AddTicks(9414), null, 1, "12345", new DateTime(2023, 12, 16, 23, 58, 15, 50, DateTimeKind.Local).AddTicks(9410), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
