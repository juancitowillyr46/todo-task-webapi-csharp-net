using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddTableUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Blocked",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondLastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5099), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5118) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blocked",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecondLastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

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
    }
}
