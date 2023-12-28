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
    [Migration("20231215021741_AddTableUserMigration")]
    partial class AddTableUserMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.AssetEntity", b =>
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = false,
                            CreatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5084),
                            DeletedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5085),
                            Name = "Asset A",
                            Type = "AUTO",
                            UpdatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5085)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.AssetLocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssetId")
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

                    b.HasIndex("AssetId");

                    b.ToTable("AssetLocations");
                });

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

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(4939),
                            DeletedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(4950),
                            UpdatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(4948)
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
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DeviceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssetId")
                        .HasColumnType("int");

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

                    b.HasKey("Id");

                    b.HasIndex("AssetId")
                        .IsUnique();

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetId = 1,
                            CreatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5099),
                            DeletedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5100),
                            Name = "Device A",
                            UpdatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5099)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.RequestEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssetId")
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

                    b.Property<string>("OriginAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginLatitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("OriginLongitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("UserId");

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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
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
                            CreatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5118),
                            DeletedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5119),
                            Email = "juan.rodas.manez@gmail.com",
                            FirstName = "Juan",
                            LastName = "Rodas",
                            UpdatedAt = new DateTime(2023, 12, 14, 21, 17, 41, 103, DateTimeKind.Local).AddTicks(5118)
                        });
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.AssetLocationEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.AssetEntity", "Asset")
                        .WithMany("Locations")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientLocationEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", "Client")
                        .WithMany("Locations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.DeviceEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.AssetEntity", "Asset")
                        .WithOne("Device")
                        .HasForeignKey("TodoTask.Infrastructure.Persistence.Entities.DeviceEntity", "AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.RequestEntity", b =>
                {
                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.AssetEntity", "Asset")
                        .WithMany("Requests")
                        .HasForeignKey("AssetId");

                    b.HasOne("TodoTask.Infrastructure.Persistence.Entities.UserEntity", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.AssetEntity", b =>
                {
                    b.Navigation("Device");

                    b.Navigation("Locations");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.ClientEntity", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("TodoTask.Infrastructure.Persistence.Entities.UserEntity", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
