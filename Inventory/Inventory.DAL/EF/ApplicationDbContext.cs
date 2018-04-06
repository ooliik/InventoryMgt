using System;
using Inventory.BLL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.DAL.EF
{
    public class ApplicationDbContext<TUser, TRole, TKey> : IdentityDbContext<TUser, TRole, TKey>
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
    {
        private readonly ConnectionStringDto _connectionStringDto;

        // Table properties e.g
        // public virtual DbSet<Entity> TableName { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<StockKeepUnit> StockKeepUnits { get; set; }
        public virtual DbSet<ItemStockKeepUnit> ItemStockKeepUnits { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehousePlace> WarehousePlaces { get; set; }
        public virtual DbSet<ReceiveHeader> ReceiveHeaders { get; set; }
        public virtual DbSet<ReceiveLine> ReceiveLines { get; set; }

        public ApplicationDbContext(ConnectionStringDto connectionStringDto)
        {
            _connectionStringDto = connectionStringDto;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
          
            optionsBuilder.UseSqlServer(_connectionStringDto.ConnectionString); // for provider SQL Server 
            // optionsBuilder.UseMySql(_connectionStringDto.ConnectionString); //for provider My SQL 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ItemStockKeepUnit>()
                .HasKey(ba => new { ba.ItemID, ba.Code});

            modelBuilder.Entity<Category>()
                .HasKey(ba => new { ba.CategoryID });

            modelBuilder.Entity<Item>()
                .HasKey(ba => new { ba.ItemID });

            modelBuilder.Entity<StockKeepUnit>()
                .HasKey(ba => new { ba.Code});

            modelBuilder.Entity<Warehouse>()
                .HasKey(ba => new { ba.WarehouseName});

            modelBuilder.Entity<WarehousePlace>()
                .HasKey(ba => new { ba.WarehouseName, ba.WarehousePlaceName});

            modelBuilder.Entity<ReceiveHeader>()
                .HasKey(ba => new { ba.DocumentID });

            modelBuilder.Entity<ReceiveLine>()
                .HasKey(ba => new { ba.DocumentID, ba.PositionNumber});
        }
    }
}