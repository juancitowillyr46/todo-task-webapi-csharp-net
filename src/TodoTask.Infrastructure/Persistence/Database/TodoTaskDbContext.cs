using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
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
            modelBuilder.Entity<UserEntity>()
                        .HasMany(a => a.Requests)
                        .WithOne(b => b.User)
                        .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<AssetEntity>()
                        .HasMany(a => a.Requests)
                        .WithOne(b => b.Asset)
                        .HasForeignKey(b => b.AssetId);

            modelBuilder.Entity<AssetEntity>()
                        .HasMany(a => a.Locations)
                        .WithOne(b => b.Asset)
                        .HasForeignKey(b => b.AssetId);

            modelBuilder.Entity<ClientEntity>()
                        .HasMany(a => a.Locations)
                        .WithOne(b => b.Client)
                        .HasForeignKey(b => b.ClientId);

            modelBuilder.Entity<AssetEntity>()
                        .Property(p => p.Type)
                        .HasConversion<string>();

            modelBuilder.Entity<RequestEntity>()
                        .Property(p => p.AssetId)
                        .IsRequired(false);

            modelBuilder.Entity<RequestEntity>()
                        .Property(p => p.Status)
                        .HasConversion<string>();

            modelBuilder.Entity<AssetEntity>()
                        .HasOne(d => d.Device)
                        .WithOne(d => d.Asset)
                        .HasForeignKey<DeviceEntity>(d => d.AssetId);

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

            modelBuilder.Entity<AssetLocationEntity>()
                        .Property(e => e.Latitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<AssetLocationEntity>()
                        .Property(e => e.Longitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<ClientLocationEntity>()
                        .Property(e => e.Latitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<ClientLocationEntity>()
                        .Property(e => e.Longitude)
                        .HasColumnType("decimal(18, 6)");

            modelBuilder.Entity<ClientEntity>().HasData(
                new ClientEntity { Id = 1 }
            );

            modelBuilder.Entity<AssetEntity>().HasData(
                new AssetEntity { Id = 1, Type = AssetTypeEnum.AUTO, Name = "Asset A" }
            );

            modelBuilder.Entity<DeviceEntity>().HasData(
               new DeviceEntity { Id = 1, AssetId = 1, Name = "Device A" }
           );

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity { Id = 1, FirstName = "Juan", LastName = "Rodas", Email = "juan.rodas.manez@gmail.com" }
            );

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

            
            
        }

        public DbSet<AssetEntity>? Assets { get; set; }
        public DbSet<DeviceEntity>? Devices { get; set; }
        public DbSet<UserEntity>? Users { get; set; }
        public DbSet<RequestEntity>? Requests { get; set; }
        public DbSet<AssetLocationEntity>? AssetLocations { get; set; }
        public DbSet<ClientLocationEntity>? ClientLocations { get; set; }
        public DbSet<ClientEntity>? Clients { get; set; }

    }
}
