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
    [Migration("20231217181618_AddColumnTypeAndAvailabilityVehicleMigration")]
    partial class AddColumnTypeAndAvailabilityVehicleMigration
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
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(7723),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(7725),
                            PersonId = 2,
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(7724),
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
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2237),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2238),
                            Latitude = -1m,
                            Longitude = -2m,
                            Timestamp = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2236),
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2238)
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
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7632),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7633),
                            Name = "Iphone Driver",
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7633)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7634),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7635),
                            Name = "Iphone Client",
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7635)
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
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(4088),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(4093),
                            LicenseNumber = "",
                            PersonId = 1,
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 12, DateTimeKind.Local).AddTicks(4092),
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
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2093),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2094),
                            DriverId = 1,
                            Latitude = -1m,
                            Longitude = -2m,
                            Timestamp = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2091),
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(2093)
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

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secondname")
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
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7648),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7649),
                            DocumentNumber = "",
                            DocumentType = 0,
                            Email = "Driver@gmail.com",
                            Firstname = "Driver FirstName",
                            Lastname = "Driver LastName",
                            SecondLastname = "Driver SecondLastName",
                            Secondname = "Driver SecondName",
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7649)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7651),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7652),
                            DocumentNumber = "",
                            DocumentType = 0,
                            Email = "client@gmail.com",
                            Firstname = "Client FirstName",
                            Lastname = "Client LastName",
                            SecondLastname = "Client SecondLastName",
                            Secondname = "Client SecondName",
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7652)
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

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Blocked = false,
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7511),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7521),
                            Email = "driver@gmail.com",
                            Fullname = "User Driver",
                            Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7518),
                            Username = "driver@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Blocked = false,
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7525),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7526),
                            Email = "client@gmail.com",
                            Fullname = "User Client",
                            Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 11, DateTimeKind.Local).AddTicks(7525),
                            Username = "user@gmail.com"
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.VehicleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

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

                    b.Property<int>("Type")
                        .HasColumnType("int");

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
                            Availability = false,
                            CreatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1540),
                            DeletedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1543),
                            DeviceId = 1,
                            PlateNumber = "12345",
                            Type = 1,
                            UpdatedAt = new DateTime(2023, 12, 17, 13, 16, 18, 13, DateTimeKind.Local).AddTicks(1542)
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
