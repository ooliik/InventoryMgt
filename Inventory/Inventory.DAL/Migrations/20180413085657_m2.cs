using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Inventory.DAL.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Warehouses_WarehouseName",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_WarehouseName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "DefaultWarehouse",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "InventoryHeaders",
                columns: table => new
                {
                    DocumentID = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InventoryDate = table.Column<DateTime>(nullable: false),
                    WarehouseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryHeaders", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_InventoryHeaders_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WarhouseEntries",
                columns: table => new
                {
                    EntryNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(nullable: true),
                    DocumentDate = table.Column<DateTime>(nullable: false),
                    DocumentDescription = table.Column<string>(nullable: true),
                    DocumentNumber = table.Column<string>(nullable: true),
                    EntryType = table.Column<int>(nullable: false),
                    ItemID = table.Column<string>(nullable: true),
                    KeepUnit = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    QuantityPerUnit = table.Column<double>(nullable: false),
                    StockKeepUnitCode = table.Column<string>(nullable: true),
                    TotalQuantity = table.Column<double>(nullable: false),
                    VendorID = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true),
                    WarehouseNumber = table.Column<string>(nullable: true),
                    WarehousePlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarhouseEntries", x => x.EntryNumber);
                    table.ForeignKey(
                        name: "FK_WarhouseEntries_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarhouseEntries_StockKeepUnits_StockKeepUnitCode",
                        column: x => x.StockKeepUnitCode,
                        principalTable: "StockKeepUnits",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarhouseEntries_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryLines",
                columns: table => new
                {
                    DocumentID = table.Column<string>(nullable: false),
                    PositionNumber = table.Column<int>(nullable: false),
                    CountedQuantity = table.Column<double>(nullable: false),
                    ItemID = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    StockKeepUnit = table.Column<string>(nullable: true),
                    StockKeepUnittCode = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true),
                    WarehouseNumber = table.Column<string>(nullable: true),
                    WarehousePlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryLines", x => new { x.DocumentID, x.PositionNumber });
                    table.ForeignKey(
                        name: "FK_InventoryLines_InventoryHeaders_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "InventoryHeaders",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryLines_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryLines_StockKeepUnits_StockKeepUnittCode",
                        column: x => x.StockKeepUnittCode,
                        principalTable: "StockKeepUnits",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryLines_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DefaultWarehouse",
                table: "Categories",
                column: "DefaultWarehouse");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryHeaders_WarehouseName",
                table: "InventoryHeaders",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_ItemID",
                table: "InventoryLines",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_StockKeepUnittCode",
                table: "InventoryLines",
                column: "StockKeepUnittCode");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_WarehouseName",
                table: "InventoryLines",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_ItemID",
                table: "WarhouseEntries",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_StockKeepUnitCode",
                table: "WarhouseEntries",
                column: "StockKeepUnitCode");

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_WarehouseName",
                table: "WarhouseEntries",
                column: "WarehouseName");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Warehouses_DefaultWarehouse",
                table: "Categories",
                column: "DefaultWarehouse",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Warehouses_DefaultWarehouse",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "InventoryLines");

            migrationBuilder.DropTable(
                name: "WarhouseEntries");

            migrationBuilder.DropTable(
                name: "InventoryHeaders");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DefaultWarehouse",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "DefaultWarehouse",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_WarehouseName",
                table: "Categories",
                column: "WarehouseName");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Warehouses_WarehouseName",
                table: "Categories",
                column: "WarehouseName",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
