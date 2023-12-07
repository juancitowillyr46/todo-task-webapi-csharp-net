using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AlterColumnCoordinateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OriginLongitude",
                table: "Requests",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginLatitude",
                table: "Requests",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DestinationLongitude",
                table: "Requests",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DestinationLatitude",
                table: "Requests",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "ClientLocations",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "ClientLocations",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "AssetLocations",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "AssetLocations",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
                columns: new[] { "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6253), "Device A", new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 12, 5, 21, 58, 56, 116, DateTimeKind.Local).AddTicks(6267) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OriginLongitude",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginLatitude",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DestinationLongitude",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DestinationLatitude",
                table: "Requests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "ClientLocations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "ClientLocations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "AssetLocations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "AssetLocations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4971), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4972), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4837), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4987), null, new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 12, 5, 21, 30, 7, 590, DateTimeKind.Local).AddTicks(4998) });
        }
    }
}
