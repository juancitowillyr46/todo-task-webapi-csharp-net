using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddColumnInRequestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationAddress",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginAddress",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5346), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5651), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 12, 11, 22, 23, 1, 885, DateTimeKind.Local).AddTicks(5687) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationAddress",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "OriginAddress",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5231), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5622), new DateTime(2023, 12, 6, 18, 46, 50, 357, DateTimeKind.Local).AddTicks(5620) });
        }
    }
}
