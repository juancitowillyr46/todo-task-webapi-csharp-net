﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoTask.Infrastructure.Database;


#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    [DbContext(typeof(TodoTaskDbContext))]
    [Migration("20231217051051_AlterTableRenameVehicleFixMigration")]
    partial class AlterTableRenameVehicleFixMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 933, DateTimeKind.Local).AddTicks(8479),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 933, DateTimeKind.Local).AddTicks(8490),
                            PersonId = 2,
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 933, DateTimeKind.Local).AddTicks(8488),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientLocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientLocations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(829),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(832),
                            Latitude = -1m,
                            Longitude = -2m,
                            Timestamp = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(827),
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(830)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DeviceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<int?>("VehiculeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehiculeId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9688),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9691),
                            Name = "Iphone Driver",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9690)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9694),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9697),
                            Name = "Iphone Client",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9696)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 932, DateTimeKind.Local).AddTicks(8345),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 932, DateTimeKind.Local).AddTicks(8354),
                            LicenseNumber = "",
                            PersonId = 1,
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 932, DateTimeKind.Local).AddTicks(8352),
                            UserId = 1,
                            VehicleId = 0
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DriverLocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<DateTime?>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("DriverLocations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(464),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(467),
                            DriverId = 1,
                            Latitude = -1m,
                            Longitude = -2m,
                            Timestamp = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(460),
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 935, DateTimeKind.Local).AddTicks(465)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.PersonEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9738),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9741),
                            DocumentNumber = "",
                            DocumentType = 0,
                            Email = "Driver@gmail.com",
                            FirstName = "Driver FirstName",
                            LastName = "Driver LastName",
                            SecondLastName = "Driver SecondLastName",
                            SecondName = "Driver SecondName",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9740)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9747),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9750),
                            DocumentNumber = "",
                            DocumentType = 0,
                            Email = "client@gmail.com",
                            FirstName = "Client FirstName",
                            LastName = "Client LastName",
                            SecondLastName = "Client SecondLastName",
                            SecondName = "Client SecondName",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9748)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.RequestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DestinationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DestinationLatitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("DestinationLongitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int?>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("OriginAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginLatitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("OriginLongitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DriverId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Blocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Blocked = false,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9410),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9431),
                            Email = "driver@gmail.com",
                            FullName = "User Driver",
                            Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9425),
                            UserName = "driver@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Blocked = false,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9441),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9443),
                            Email = "client@gmail.com",
                            FullName = "User Client",
                            Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 930, DateTimeKind.Local).AddTicks(9442),
                            UserName = "user@gmail.com"
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.VehicleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId")
                        .IsUnique();

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 934, DateTimeKind.Local).AddTicks(8924),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 10, 49, 934, DateTimeKind.Local).AddTicks(8936),
                            DeviceId = 1,
                            PlateNumber = "12345",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 10, 49, 934, DateTimeKind.Local).AddTicks(8934)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.PersonEntity", "Person")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.UserEntity", "User")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientLocationEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", "Client")
                        .WithMany("Locations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DeviceEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.VehicleEntity", "Vehicule")
                        .WithMany()
                        .HasForeignKey("VehiculeId");

                    b.Navigation("Vehicule");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.PersonEntity", "Person")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.VehicleEntity", "Vehicle")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.UserEntity", "User")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DriverLocationEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", "Driver")
                        .WithMany("Locations")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.RequestEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", "Client")
                        .WithMany("Requests")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", "Driver")
                        .WithMany("Requests")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Client");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.VehicleEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.DeviceEntity", "Device")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.VehicleEntity", "DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
