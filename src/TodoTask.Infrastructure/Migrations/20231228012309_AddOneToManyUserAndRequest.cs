using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddOneToManyUserAndRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Clients_ClientId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Requests",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_ClientId",
                table: "Requests",
                newName: "IX_Requests_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Requests",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                newName: "IX_Requests_ClientId");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4681), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(7481), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(7497), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2077), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2081), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2082), new DateTime(2023, 12, 17, 18, 9, 16, 296, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(3862), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(3865), new DateTime(2023, 12, 17, 18, 9, 16, 297, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Clients_ClientId",
                table: "Requests",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
