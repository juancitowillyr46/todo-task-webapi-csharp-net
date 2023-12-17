using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddFixUserEntityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Users",
                newName: "FullName");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "Fullname");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(739), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(740), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(738), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1649), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(616), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(614), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(5772), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1665), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1666), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1668), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1669), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1492), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1497), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(23), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 12, 17, 18, 6, 41, 564, DateTimeKind.Local).AddTicks(25) });
        }
    }
}
