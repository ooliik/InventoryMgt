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
       
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<StockKeepUnit> StockKeepUnits { get; set; }
        public virtual DbSet<ItemStockKeepUnit> ItemStockKeepUnits { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehousePlace> WarehousePlaces { get; set; }
        public virtual DbSet<ReceiveHeader> ReceiveHeaders { get; set; }
        public virtual DbSet<ReceiveLine> ReceiveLines { get; set; }
        public virtual DbSet<ReleaseHeader> ReleaseHeaders { get; set; }
        public virtual DbSet<ReleaseLine> ReleaseLines { get; set; }
        public virtual DbSet<WarehouseEntry> WarhouseEntries { get; set; }
        public virtual DbSet<InventoryHeader> InventoryHeaders { get; set; }
        public virtual DbSet<InventoryLine> InventoryLines { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

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

            modelBuilder.Entity<Customer>()
               .HasKey(ba => new { ba.CustomerID });

            modelBuilder.Entity<Vendor>()
                .HasKey(ba => new { ba.VendorID });

            modelBuilder.Entity<WarehousePlace>()
                .HasKey(ba => new { ba.WarehouseName, ba.WarehousePlaceName});

            modelBuilder.Entity<ReceiveHeader>()
                .HasKey(ba => new { ba.DocumentID });

            modelBuilder.Entity<ReceiveLine>()
                .HasKey(ba => new { ba.DocumentID, ba.PositionNumber});

            modelBuilder.Entity<ReleaseHeader>()
                .HasKey(ba => new { ba.DocumentID});

            modelBuilder.Entity<ReleaseLine>()
                .HasKey(ba => new { ba.DocumentID, ba.PositionNumber});

            modelBuilder.Entity<WarehouseEntry>()
                .HasKey(ba => new { ba.EntryNumber});

            modelBuilder.Entity<InventoryHeader>()
                .HasKey(ba => new { ba.DocumentID});

            modelBuilder.Entity<InventoryLine>()
                .HasKey(ba => new { ba.DocumentID, ba.PositionNumber});


            modelBuilder.Entity<Category>()
                .HasOne(ba => ba.Warehouse)
                .WithMany(ba => ba.Categories)
                .HasForeignKey(ba => ba.DefaultWarehouse);

            modelBuilder.Entity<Item>()
                .HasOne(ba => ba.Category)
                .WithMany(ba => ba.Items)
                .HasForeignKey(ba => ba.CategoryID);

            modelBuilder.Entity<ItemStockKeepUnit>()
                .HasOne(ba => ba.Item)
                .WithMany(b => b.ItemStockKeepUnits)
                .HasForeignKey(ba => ba.ItemID);

            modelBuilder.Entity<ItemStockKeepUnit>()
               .HasOne(ba => ba.StockKeepUnit)
                .WithMany(b => b.ItemStockKeepUnits)
                .HasForeignKey(ba => ba.Code);

            modelBuilder.Entity<WarehouseEntry>()
                 .HasOne(ba => ba.Item)
                 .WithMany(ba => ba.WarehouseEntries)
                 .HasForeignKey(ba => ba.ItemID);

            modelBuilder.Entity<WarehouseEntry>()
                 .HasOne(ba => ba.Warehouse)
                 .WithMany(ba => ba.WarehouseEntries)
                 .HasForeignKey(ba => ba.WarehouseNumber);

            modelBuilder.Entity<WarehouseEntry>()
                .HasOne(ba => ba.StockKeepUnit)
                .WithMany(ba => ba.WarehouseEntries)
                .HasForeignKey(ba => ba.KeepUnit);

            modelBuilder.Entity<ReleaseLine>()
                .HasOne(ba => ba.ReleaseHeader)
                .WithMany(ba => ba.ReleaseLines)
                .HasForeignKey(ba => ba.DocumentID);

            modelBuilder.Entity<ReleaseLine>()
                .HasOne(ba => ba.Item)
                .WithMany(ba => ba.ReleaseLines)
                .HasForeignKey(ba => ba.ItemID);

            modelBuilder.Entity<ReleaseLine>()
                .HasOne(ba => ba.StockKeepUnitt)
                .WithMany(ba => ba.ReleaseLines)
                .HasForeignKey(ba => ba.StockKeepUnit);

            modelBuilder.Entity<ReleaseLine>()
                .HasOne(ba => ba.Warehouse)
                .WithMany(ba => ba.ReleaseLines)
                .HasForeignKey(ba => ba.WarehouseNumber);

            modelBuilder.Entity<WarehousePlace>()
                 .HasOne(ba => ba.Warehouse)
                 .WithMany(ba => ba.WarehousePlaces)
                 .HasForeignKey(ba => ba.WarehouseName);

            modelBuilder.Entity<ReceiveLine>()
                .HasOne(ba => ba.ReceiveHeader)
                .WithMany(ba => ba.ReceiveLines)
                .HasForeignKey(ba => ba.DocumentID);

            modelBuilder.Entity<ReceiveLine>()
                .HasOne(ba => ba.Item)
                .WithMany(ba => ba.ReceiveLines)
                .HasForeignKey(ba => ba.ItemID);

            modelBuilder.Entity<ReceiveLine>()
                .HasOne(ba => ba.StockKeepUnitt)
                .WithMany(ba => ba.ReceiveLines)
                .HasForeignKey(ba => ba.StockKeepUnit);

            modelBuilder.Entity<ReceiveLine>()
                .HasOne(ba => ba.Warehouse)
                .WithMany(ba => ba.ReceiveLines)
                .HasForeignKey(ba => ba.WarehouseNumber);

            modelBuilder.Entity<InventoryHeader>()
                .HasOne(ba => ba.Warehouse)
                .WithMany(ba => ba.InventoryHeaders)
                .HasForeignKey(ba => ba.WarehouseName);

            modelBuilder.Entity<InventoryLine>()
                .HasOne(ba => ba.InventoryHeader)
                .WithMany(ba => ba.InventoryLines)
                .HasForeignKey(ba => ba.DocumentID);

            modelBuilder.Entity<InventoryLine>()
                .HasOne(ba => ba.Item)
                .WithMany(ba => ba.InventoryLines)
                .HasForeignKey(ba => ba.ItemID);

            modelBuilder.Entity<InventoryLine>()
                .HasOne(ba => ba.StockKeepUnitt)
                .WithMany(ba => ba.InventoryLines)
                .HasForeignKey(ba => ba.StockKeepUnit);

            modelBuilder.Entity<InventoryLine>()
                .HasOne(ba => ba.Warehouse)
                .WithMany(ba => ba.InventoryLines)
                .HasForeignKey(ba => ba.WarehouseNumber);




        }
    }
}