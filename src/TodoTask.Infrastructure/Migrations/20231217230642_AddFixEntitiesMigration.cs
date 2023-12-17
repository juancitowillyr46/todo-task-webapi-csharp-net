using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AddFixEntitiesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "Secondname",
                table: "Persons",
                newName: "SecondName");

            migrationBuilder.RenameColumn(
                name: "SecondLastname",
                table: "Persons",
                newName: "SecondLastName");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Persons",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Persons",
                newName: "FirstName");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "DeletedAt", "Gender", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1665), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1666), 1, new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "Gender", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1668), new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1669), 1, new DateTime(2023, 12, 17, 18, 6, 41, 563, DateTimeKind.Local).AddTicks(1668) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "SecondName",
                table: "Persons",
                newName: "Secondname");

            migrationBuilder.RenameColumn(
                name: "SecondLastName",
                table: "Persons",
                newName: "SecondLastname");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Persons",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Persons",
                newName: "Firstname");

            migrationBuilder.UpdateData(
                table: "ClientLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7475), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7472), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7633), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7634), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7654), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7506), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7522), new DateTime(2023, 12, 17, 16, 31, 27, 158, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 12, 17, 16, 31, 27, 159, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles",
                column: "DriverId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                table: "Vehicles",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
