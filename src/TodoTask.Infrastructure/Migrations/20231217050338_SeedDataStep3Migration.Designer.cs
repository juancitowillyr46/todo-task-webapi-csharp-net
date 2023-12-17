﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoTask.Infrastructure.Persistence.Database;

#nullable disable

namespace TodoTask.Infrastructure.Migrations
{
    [DbContext(typeof(TodoTaskDbContext))]
    [Migration("20231217050338_SeedDataStep3Migration")]
    partial class SeedDataStep3Migration
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 845, DateTimeKind.Local).AddTicks(7209),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 845, DateTimeKind.Local).AddTicks(7221),
                            PersonId = 2,
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 845, DateTimeKind.Local).AddTicks(7217),
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1458),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1461),
                            Latitude = -1m,
                            Longitude = -2m,
                            Timestamp = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1456),
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1460)
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2948),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2951),
                            Name = "Iphone Driver",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2949)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2954),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2957),
                            Name = "Iphone Client",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2955)
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 844, DateTimeKind.Local).AddTicks(5817),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 844, DateTimeKind.Local).AddTicks(5830),
                            LicenseNumber = "",
                            PersonId = 1,
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 844, DateTimeKind.Local).AddTicks(5826),
                            UserId = 1
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1074),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1077),
                            DriverId = 1,
                            Latitude = -1m,
                            Longitude = -2m,
                            Timestamp = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1069),
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 847, DateTimeKind.Local).AddTicks(1076)
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2993),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2996),
                            DocumentNumber = "",
                            DocumentType = 0,
                            Email = "Driver@gmail.com",
                            FirstName = "Driver FirstName",
                            LastName = "Driver LastName",
                            SecondLastName = "Driver SecondLastName",
                            SecondName = "Driver SecondName",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2994)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(3002),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(3004),
                            DocumentNumber = "",
                            DocumentType = 0,
                            Email = "client@gmail.com",
                            FirstName = "Client FirstName",
                            LastName = "Client LastName",
                            SecondLastName = "Client SecondLastName",
                            SecondName = "Client SecondName",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(3003)
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
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2570),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2588),
                            Email = "driver@gmail.com",
                            FullName = "User Driver",
                            Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2583),
                            UserName = "driver@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Blocked = false,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2598),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2600),
                            Email = "client@gmail.com",
                            FullName = "User Client",
                            Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 843, DateTimeKind.Local).AddTicks(2599),
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

                    b.ToTable("Vehicules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 846, DateTimeKind.Local).AddTicks(9116),
                            DeletedAt = new DateTime(2023, 12, 17, 0, 3, 36, 846, DateTimeKind.Local).AddTicks(9130),
                            DeviceId = 1,
                            PlateNumber = "12345",
                            UpdatedAt = new DateTime(2023, 12, 17, 0, 3, 36, 846, DateTimeKind.Local).AddTicks(9125)
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

                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.UserEntity", "User")
                        .WithOne()
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.DriverEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("User");
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