using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AlterTableRenameVehicleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Vehicules_VehiculeId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicules_Devices_DeviceId",
                table: "Vehicules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicules",
                table: "Vehicules");

            migrationBuilder.RenameTable(
                name: "Vehicules",
                newName: "Vehicle");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicules_DeviceId",
                table: "Vehicle",
                newName: "IX_Vehicle_DeviceId");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(8182), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(8177), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 833, DateTimeKind.Local).AddTicks(5944), new DateTime(2023, 12, 17, 0, 9, 36, 833, DateTimeKind.Local).AddTicks(5952), new DateTime(2023, 12, 17, 0, 9, 36, 833, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8263), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(7818), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(7814), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 832, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 12, 17, 0, 9, 36, 832, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 12, 17, 0, 9, 36, 832, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8300), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 12, 17, 0, 9, 36, 830, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 12, 17, 0, 9, 36, 834, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Vehicle_VehiculeId",
                table: "Devices",
                column: "VehiculeId",
                principalTable: "Vehicle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Vehicle_PersonId",
                table: "Drivers",
                column: "PersonId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Devices_DeviceId",
                table: "Vehicle",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Vehicle_VehiculeId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Vehicle_PersonId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Devices_DeviceId",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicules");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_DeviceId",
                table: "Vehicules",
                newName: "IX_Vehicules_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicules",
                table: "Vehicules",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1460) });

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

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1074), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1077), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1069), new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1076) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Vehicules_VehiculeId",
                table: "Devices",
                column: "VehiculeId",
                principalTable: "Vehicules",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicules_Devices_DeviceId",
                table: "Vehicules",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
