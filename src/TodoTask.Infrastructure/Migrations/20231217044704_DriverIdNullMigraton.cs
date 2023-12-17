﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    public partial class DriverIdNullMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
