using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AlterTableRenameVehicleFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_DeviceId",
                table: "Vehicles",
                newName: "IX_Vehicles_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(829), new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(827), new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 933, DateTimeKind.Local).AddTicks(8479), new DateTime(2023, 12, 17, 0, 10, 49, 933, DateTimeKind.Local).AddTicks(8490), new DateTime(2023, 12, 17, 0, 10, 49, 933, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(460), new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 932, DateTimeKind.Local).AddTicks(8345), new DateTime(2023, 12, 17, 0, 10, 49, 932, DateTimeKind.Local).AddTicks(8354), new DateTime(2023, 12, 17, 0, 10, 49, 932, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9747), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9431), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9443), new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 0, 10, 49, 934, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 12, 17, 0, 10, 49, 934, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 12, 17, 0, 10, 49, 934, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Vehicles_VehiculeId",
                table: "Devices",
                column: "VehiculeId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Vehicles_PersonId",
                table: "Drivers",
                column: "PersonId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Devices_DeviceId",
                table: "Vehicles",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Vehicles_VehiculeId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Vehicles_PersonId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Devices_DeviceId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_DeviceId",
                table: "Vehicle",
                newName: "IX_Vehicle_DeviceId");

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
    }
}
