using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Inventory.DAL.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Warehouses_DefaultWarehouse",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_CategoryID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_DefaultWarehouse",
                table: "Category",
                newName: "IX_Category_DefaultWarehouse");

            migrationBuilder.AlterColumn<string>(
                name: "VendorID",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerID",
                table: "ReleaseHeaders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorID",
                table: "ReceiveHeaders",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorID = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_CustomerID",
                table: "WarhouseEntries",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_VendorID",
                table: "WarhouseEntries",
                column: "VendorID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseHeaders_CustomerID",
                table: "ReleaseHeaders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveHeaders_VendorID",
                table: "ReceiveHeaders",
                column: "VendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Warehouses_DefaultWarehouse",
                table: "Category",
                column: "DefaultWarehouse",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Category_CategoryID",
                table: "Items",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveHeaders_Vendors_VendorID",
                table: "ReceiveHeaders",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseHeaders_Customers_CustomerID",
                table: "ReleaseHeaders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarhouseEntries_Customers_CustomerID",
                table: "WarhouseEntries",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarhouseEntries_Vendors_VendorID",
                table: "WarhouseEntries",
                column: "VendorID",
                principalTable: "Vendors",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Warehouses_DefaultWarehouse",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Category_CategoryID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveHeaders_Vendors_VendorID",
                table: "ReceiveHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseHeaders_Customers_CustomerID",
                table: "ReleaseHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_WarhouseEntries_Customers_CustomerID",
                table: "WarhouseEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_WarhouseEntries_Vendors_VendorID",
                table: "WarhouseEntries");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_WarhouseEntries_CustomerID",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_WarhouseEntries_VendorID",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseHeaders_CustomerID",
                table: "ReleaseHeaders");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveHeaders_VendorID",
                table: "ReceiveHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "ReleaseHeaders");

            migrationBuilder.DropColumn(
                name: "VendorID",
                table: "ReceiveHeaders");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Category_DefaultWarehouse",
                table: "Categories",
                newName: "IX_Categories_DefaultWarehouse");

            migrationBuilder.AlterColumn<string>(
                name: "VendorID",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Warehouses_DefaultWarehouse",
                table: "Categories",
                column: "DefaultWarehouse",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_CategoryID",
                table: "Items",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
