﻿// <auto-generated />
using Inventory.BLL.Entities;
using Inventory.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Inventory.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext<User, Role, int>))]
    [Migration("20180406093329_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inventory.BLL.Entities.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefaultWarehouse");

                    b.Property<string>("DefaultWarehousePlace");

                    b.Property<string>("Description");

                    b.Property<string>("WarehouseName");

                    b.HasKey("CategoryID");

                    b.HasIndex("WarehouseName");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.Item", b =>
                {
                    b.Property<string>("ItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryID");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ItemID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ItemStockKeepUnit", b =>
                {
                    b.Property<string>("ItemID");

                    b.Property<string>("Code");

                    b.HasKey("ItemID", "Code");

                    b.HasIndex("Code");

                    b.ToTable("ItemStockKeepUnits");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ReceiveHeader", b =>
                {
                    b.Property<string>("DocumentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("ReceiveDate");

                    b.HasKey("DocumentID");

                    b.ToTable("ReceiveHeaders");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ReceiveLine", b =>
                {
                    b.Property<string>("DocumentID");

                    b.Property<int>("PositionNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemID");

                    b.Property<double>("Quantity");

                    b.Property<double>("ReceiveQuantity");

                    b.Property<double>("ReceivedQuantity");

                    b.Property<string>("StockKeepUnit");

                    b.Property<string>("StockKeepUnittCode");

                    b.Property<string>("WarehouseName");

                    b.Property<string>("WarehouseNumber");

                    b.Property<string>("WarehousePlace");

                    b.HasKey("DocumentID", "PositionNumber");

                    b.HasIndex("ItemID");

                    b.HasIndex("StockKeepUnittCode");

                    b.HasIndex("WarehouseName");

                    b.ToTable("ReceiveLines");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ReleaseHeader", b =>
                {
                    b.Property<string>("DocumentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("DocumentID");

                    b.ToTable("ReleaseHeaders");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ReleaseLine", b =>
                {
                    b.Property<string>("DocumentID");

                    b.Property<int>("PositionNumber");

                    b.Property<string>("ItemID");

                    b.Property<double>("Quantity");

                    b.Property<double>("ReleaseQuantity");

                    b.Property<double>("ReleasedQuantity");

                    b.Property<string>("StockKeepUnit");

                    b.Property<string>("StockKeepUnittCode");

                    b.Property<string>("WarehouseName");

                    b.Property<string>("WarehouseNumber");

                    b.Property<string>("WarehousePlace");

                    b.HasKey("DocumentID", "PositionNumber");

                    b.HasIndex("ItemID");

                    b.HasIndex("StockKeepUnittCode");

                    b.HasIndex("WarehouseName");

                    b.ToTable("ReleaseLines");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.StockKeepUnit", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<double>("QuantityPerUnit");

                    b.HasKey("Code");

                    b.ToTable("StockKeepUnits");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.Warehouse", b =>
                {
                    b.Property<string>("WarehouseName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.HasKey("WarehouseName");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.WarehousePlace", b =>
                {
                    b.Property<string>("WarehouseName");

                    b.Property<string>("WarehousePlaceName");

                    b.HasKey("WarehouseName", "WarehousePlaceName");

                    b.ToTable("WarehousePlaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.Category", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.Warehouse", "Warehouse")
                        .WithMany("Categories")
                        .HasForeignKey("WarehouseName");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.Item", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ItemStockKeepUnit", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.StockKeepUnit", "StockKeepUnit")
                        .WithMany("ItemStockKeepUnits")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inventory.BLL.Entities.Item", "Item")
                        .WithMany("ItemStockKeepUnits")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ReceiveLine", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.ReceiveHeader", "ReceiveHeader")
                        .WithMany("ReceiveLines")
                        .HasForeignKey("DocumentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inventory.BLL.Entities.Item", "Item")
                        .WithMany("ReceiveLines")
                        .HasForeignKey("ItemID");

                    b.HasOne("Inventory.BLL.Entities.StockKeepUnit", "StockKeepUnitt")
                        .WithMany("ReceiveLines")
                        .HasForeignKey("StockKeepUnittCode");

                    b.HasOne("Inventory.BLL.Entities.Warehouse", "Warehouse")
                        .WithMany("ReceiveLines")
                        .HasForeignKey("WarehouseName");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.ReleaseLine", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.ReleaseHeader", "ReleaseHeader")
                        .WithMany("ReleaseLines")
                        .HasForeignKey("DocumentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inventory.BLL.Entities.Item", "Item")
                        .WithMany("ReleaseLines")
                        .HasForeignKey("ItemID");

                    b.HasOne("Inventory.BLL.Entities.StockKeepUnit", "StockKeepUnitt")
                        .WithMany("ReleaseLines")
                        .HasForeignKey("StockKeepUnittCode");

                    b.HasOne("Inventory.BLL.Entities.Warehouse", "Warehouse")
                        .WithMany("ReleaseLines")
                        .HasForeignKey("WarehouseName");
                });

            modelBuilder.Entity("Inventory.BLL.Entities.WarehousePlace", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.Warehouse", "Warehouse")
                        .WithMany("WarehousePlaces")
                        .HasForeignKey("WarehouseName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Inventory.BLL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Inventory.BLL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
