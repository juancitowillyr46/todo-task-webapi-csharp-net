using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddColumAvailabilityAssetMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Assets",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Assets");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6122), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6267) });
        }
    }
}
