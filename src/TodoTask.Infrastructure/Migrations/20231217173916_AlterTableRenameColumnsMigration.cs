using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class AlterTableRenameColumnsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "Fullname");

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
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6568), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "DriverLocations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "Timestamp", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6443), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2251), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2112), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 17, 12, 39, 15, 890, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 12, 17, 12, 39, 15, 891, DateTimeKind.Local).AddTicks(5919) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Users",
                newName: "FullName");

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
        }
    }
}
