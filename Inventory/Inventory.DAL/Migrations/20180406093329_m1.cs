using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Inventory.DAL.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReceiveHeaders",
                columns: table => new
                {
                    DocumentID = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ReceiveDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveHeaders", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseHeaders",
                columns: table => new
                {
                    DocumentID = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseHeaders", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "StockKeepUnits",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    QuantityPerUnit = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockKeepUnits", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseName);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    DefaultWarehouse = table.Column<string>(nullable: true),
                    DefaultWarehousePlace = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                    table.ForeignKey(
                        name: "FK_Categories_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WarehousePlaces",
                columns: table => new
                {
                    WarehouseName = table.Column<string>(nullable: false),
                    WarehousePlaceName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousePlaces", x => new { x.WarehouseName, x.WarehousePlaceName });
                    table.ForeignKey(
                        name: "FK_WarehousePlaces_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<string>(nullable: false),
                    CategoryID = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemStockKeepUnits",
                columns: table => new
                {
                    ItemID = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStockKeepUnits", x => new { x.ItemID, x.Code });
                    table.ForeignKey(
                        name: "FK_ItemStockKeepUnits_StockKeepUnits_Code",
                        column: x => x.Code,
                        principalTable: "StockKeepUnits",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemStockKeepUnits_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveLines",
                columns: table => new
                {
                    DocumentID = table.Column<string>(nullable: false),
                    PositionNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    ReceiveQuantity = table.Column<double>(nullable: false),
                    ReceivedQuantity = table.Column<double>(nullable: false),
                    StockKeepUnit = table.Column<string>(nullable: true),
                    StockKeepUnittCode = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true),
                    WarehouseNumber = table.Column<string>(nullable: true),
                    WarehousePlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveLines", x => new { x.DocumentID, x.PositionNumber });
                    table.ForeignKey(
                        name: "FK_ReceiveLines_ReceiveHeaders_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "ReceiveHeaders",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiveLines_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiveLines_StockKeepUnits_StockKeepUnittCode",
                        column: x => x.StockKeepUnittCode,
                        principalTable: "StockKeepUnits",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceiveLines_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReleaseLines",
                columns: table => new
                {
                    DocumentID = table.Column<string>(nullable: false),
                    PositionNumber = table.Column<int>(nullable: false),
                    ItemID = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    ReleaseQuantity = table.Column<double>(nullable: false),
                    ReleasedQuantity = table.Column<double>(nullable: false),
                    StockKeepUnit = table.Column<string>(nullable: true),
                    StockKeepUnittCode = table.Column<string>(nullable: true),
                    WarehouseName = table.Column<string>(nullable: true),
                    WarehouseNumber = table.Column<string>(nullable: true),
                    WarehousePlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseLines", x => new { x.DocumentID, x.PositionNumber });
                    table.ForeignKey(
                        name: "FK_ReleaseLines_ReleaseHeaders_DocumentID",
                        column: x => x.DocumentID,
                        principalTable: "ReleaseHeaders",
                        principalColumn: "DocumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReleaseLines_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReleaseLines_StockKeepUnits_StockKeepUnittCode",
                        column: x => x.StockKeepUnittCode,
                        principalTable: "StockKeepUnits",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReleaseLines_Warehouses_WarehouseName",
                        column: x => x.WarehouseName,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_WarehouseName",
                table: "Categories",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryID",
                table: "Items",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStockKeepUnits_Code",
                table: "ItemStockKeepUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_ItemID",
                table: "ReceiveLines",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_StockKeepUnittCode",
                table: "ReceiveLines",
                column: "StockKeepUnittCode");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_WarehouseName",
                table: "ReceiveLines",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_ItemID",
                table: "ReleaseLines",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_StockKeepUnittCode",
                table: "ReleaseLines",
                column: "StockKeepUnittCode");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_WarehouseName",
                table: "ReleaseLines",
                column: "WarehouseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemStockKeepUnits");

            migrationBuilder.DropTable(
                name: "ReceiveLines");

            migrationBuilder.DropTable(
                name: "ReleaseLines");

            migrationBuilder.DropTable(
                name: "WarehousePlaces");

            migrationBuilder.DropTable(
                name: "ReceiveHeaders");

            migrationBuilder.DropTable(
                name: "ReleaseHeaders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "StockKeepUnits");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
