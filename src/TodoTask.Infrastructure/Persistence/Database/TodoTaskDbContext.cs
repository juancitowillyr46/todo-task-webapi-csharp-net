using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TodoTask.Domain.Enums;
using TodoTask.Infrastructure.Persistence.Entities;

namespace TodoTask.Infrastructure.Persistence.Database
{
    public class TodoTaskDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4701OER\\SQLEXPRESS;Database=TrackerAssets;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        public TodoTaskDbContext()
        {
        }

        public TodoTaskDbContext(DbContextOptions<TodoTaskDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureUser(modelBuilder);
            ConfigureDevice(modelBuilder);
            ConfigurePerson(modelBuilder);
            ConfigureDriver(modelBuilder);
            ConfigureClient(modelBuilder);
            ConfigureVehicle(modelBuilder);
            ConfigureRequest(modelBuilder);
            ConfigureDriverLocation(modelBuilder);
            ConfigureClientLocation(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

        }
        private static void ConfigureClientLocation(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ClientLocationEntity>()
                        .Property(e => e.Latitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<ClientLocationEntity>()
                        .Property(e => e.Longitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<ClientLocationEntity>().HasData(
                new ClientLocationEntity
                {
                    Id = 1,
                    ClientId = 1,
                    Latitude = -1,
                    Longitude = -2,
                }
            );

        }
        private static void ConfigureDriverLocation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DriverLocationEntity>()
                        .Property(e => e.Latitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<DriverLocationEntity>()
                        .Property(e => e.Longitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<DriverLocationEntity>().HasData(
                            new DriverLocationEntity
                            {
                                Id = 1,
                                DriverId = 1,
                                Latitude = -1,
                                Longitude = -2,
                            }
                        );
        }
        private static void ConfigureDriver(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DriverEntity>()
                        .HasOne(c => c.Person)
                        .WithOne()
                        .HasForeignKey<DriverEntity>(c => c.PersonId);

            modelBuilder.Entity<DriverEntity>()
                        .HasOne(c => c.User)
                        .WithOne()
                        .HasForeignKey<DriverEntity>(c => c.UserId);

            modelBuilder.Entity<DriverEntity>()
                        .HasMany(a => a.Locations)
                        .WithOne(b => b.Driver)
                        .HasForeignKey(b => b.DriverId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DriverEntity>()
                        .HasMany(a => a.Requests)
                        .WithOne(b => b.Driver)
                        .HasForeignKey(b => b.DriverId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DriverEntity>()
                        .HasOne(d => d.Vehicle)
                        .WithOne(v => v.Driver)
                        .HasForeignKey<VehicleEntity>(v => v.DriverId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DriverEntity>().HasData(
                            new DriverEntity
                            {
                                Id = 1,
                                UserId = 1,
                                PersonId = 1,
                            }
                        );

        }
        private static void ConfigureClient(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientEntity>()
                        .HasOne(c => c.User)
                        .WithOne()
                        .HasForeignKey<ClientEntity>(c => c.UserId);

            modelBuilder.Entity<ClientEntity>()
                        .HasOne(c => c.Person)
                        .WithOne()
                        .HasForeignKey<ClientEntity>(c => c.PersonId);

            modelBuilder.Entity<ClientEntity>()
                        .HasMany(a => a.Locations)
                        .WithOne(b => b.Client)
                        .HasForeignKey(b => b.ClientId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClientEntity>()
                        .HasMany(a => a.Requests)
                        .WithOne(b => b.Client)
                        .HasForeignKey(b => b.ClientId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClientEntity>().HasData(
                            new ClientEntity
                            {
                                Id = 1,
                                UserId = 2,
                                PersonId = 2,
                            }
                        );
        }
        private static void ConfigurePerson(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonEntity>().HasData(
                new PersonEntity
                {
                    Id = 1,
                    Firstname = "Driver FirstName",
                    Secondname = "Driver SecondName",
                    Lastname = "Driver LastName",
                    SecondLastname = "Driver SecondLastName",
                    Email = "Driver@gmail.com"
                },
                new PersonEntity
                {
                    Id = 2,
                    Firstname = "Client FirstName",
                    Secondname = "Client SecondName",
                    Lastname = "Client LastName",
                    SecondLastname = "Client SecondLastName",
                    Email = "client@gmail.com"
                }
            );
        }
        private static void ConfigureDevice(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceEntity>().HasData(
                new DeviceEntity
                {
                    Id = 1,
                    Name = "Iphone Driver",
                },
                new DeviceEntity
                {
                    Id = 2,
                    Name = "Iphone Client",
                }
            );
        }
        private static void ConfigureRequest(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<RequestEntity>()
                        .Property(p => p.Status)
                        .HasConversion<string>();

            modelBuilder.Entity<RequestEntity>()
                        .Property(e => e.DestinationLatitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<RequestEntity>()
                        .Property(e => e.DestinationLongitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<RequestEntity>()
                        .Property(e => e.OriginLatitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<RequestEntity>()
                        .Property(e => e.OriginLongitude)
                        .HasColumnType("decimal(18, 6)");

            //modelBuilder.Entity<RequestEntity>().HasData(
            //                new RequestEntity
            //                {
            //                    Id = 1,
            //                    ClientId = 1,
            //                    DriverId = 1,
            //                    OriginAddress = "OriginAddress",
            //                    OriginLatitude = -1,
            //                    OriginLongitude = -2,
            //                    DestinationAddress = "DestinationAddress",
            //                    DestinationLatitude = -3,
            //                    DestinationLongitude = -4,
            //                    Status = RequestStatusEnum.PENDING,
            //                }
            //            );
        }
        private static void ConfigureVehicle(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleEntity>()
                        .HasOne(v => v.Device)
                        .WithOne()
                        .HasForeignKey<VehicleEntity>(v => v.DeviceId);

            modelBuilder.Entity<VehicleEntity>().HasData(
                            new VehicleEntity
                            {
                                Id = 1,
                                PlateNumber = "12345",
                                DeviceId = 1,
                            }
                        );
        }
        private static void ConfigureUser(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserEntity>()
            //            .HasOne(c => c.Client)
            //            .WithOne()
            //            .HasForeignKey<ClientEntity>(c => c.UserId);

            //modelBuilder.Entity<UserEntity>()
            //            .HasOne(c => c.Driver)
            //            .WithOne()
            //            .HasForeignKey<DriverEntity>(c => c.UserId);

            modelBuilder.Entity<UserEntity>().HasData(
                            new UserEntity
                            {
                                Id = 1,
                                Email = "driver@gmail.com",
                                Fullname = "User Driver",
                                Blocked = false,
                                Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",// Prueba
                                Username = "driver@gmail.com",
                            },
                            new UserEntity
                            {
                                Id = 2,
                                Email = "client@gmail.com",
                                Fullname = "User Client",
                                Blocked = false,
                                Password = "$2y$10$IXH.x1KE5WHLLAC4Njsy4.tZjWVXB6L2JwZ5UHuWpLmwEQUO2qIxW",// Prueba
                                Username = "user@gmail.com",
                            }
                        );
        }

        public DbSet<PersonEntity>? Persons { get; set; }
        public DbSet<DriverEntity>? Drivers { get; set; }
        public DbSet<ClientEntity>? Clients { get; set; }
        public DbSet<UserEntity>? Users { get; set; }
        public DbSet<DeviceEntity>? Devices { get; set; }
        public DbSet<RequestEntity>? Requests { get; set; }
        public DbSet<VehicleEntity>? Vehicles { get; set; }
        public DbSet<DriverLocationEntity>? DriverLocations { get; set; }
        public DbSet<ClientLocationEntity>? ClientLocations { get; set; }
        

    }
}
