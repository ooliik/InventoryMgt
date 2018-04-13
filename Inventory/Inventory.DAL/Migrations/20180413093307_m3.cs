using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Inventory.DAL.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLines_StockKeepUnits_StockKeepUnittCode",
                table: "InventoryLines");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLines_Warehouses_WarehouseName",
                table: "InventoryLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveLines_StockKeepUnits_StockKeepUnittCode",
                table: "ReceiveLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveLines_Warehouses_WarehouseName",
                table: "ReceiveLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseLines_StockKeepUnits_StockKeepUnittCode",
                table: "ReleaseLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseLines_Warehouses_WarehouseName",
                table: "ReleaseLines");

            migrationBuilder.DropForeignKey(
                name: "FK_WarhouseEntries_StockKeepUnits_StockKeepUnitCode",
                table: "WarhouseEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_WarhouseEntries_Warehouses_WarehouseName",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_WarhouseEntries_StockKeepUnitCode",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_WarhouseEntries_WarehouseName",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseLines_StockKeepUnittCode",
                table: "ReleaseLines");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseLines_WarehouseName",
                table: "ReleaseLines");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveLines_StockKeepUnittCode",
                table: "ReceiveLines");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveLines_WarehouseName",
                table: "ReceiveLines");

            migrationBuilder.DropIndex(
                name: "IX_InventoryLines_StockKeepUnittCode",
                table: "InventoryLines");

            migrationBuilder.DropIndex(
                name: "IX_InventoryLines_WarehouseName",
                table: "InventoryLines");

            migrationBuilder.DropColumn(
                name: "StockKeepUnitCode",
                table: "WarhouseEntries");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "WarhouseEntries");

            migrationBuilder.DropColumn(
                name: "StockKeepUnittCode",
                table: "ReleaseLines");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "ReleaseLines");

            migrationBuilder.DropColumn(
                name: "StockKeepUnittCode",
                table: "ReceiveLines");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "ReceiveLines");

            migrationBuilder.DropColumn(
                name: "StockKeepUnittCode",
                table: "InventoryLines");

            migrationBuilder.DropColumn(
                name: "WarehouseName",
                table: "InventoryLines");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KeepUnit",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "ReleaseLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockKeepUnit",
                table: "ReleaseLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "ReceiveLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockKeepUnit",
                table: "ReceiveLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "InventoryLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockKeepUnit",
                table: "InventoryLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_KeepUnit",
                table: "WarhouseEntries",
                column: "KeepUnit");

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_WarehouseNumber",
                table: "WarhouseEntries",
                column: "WarehouseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_StockKeepUnit",
                table: "ReleaseLines",
                column: "StockKeepUnit");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_WarehouseNumber",
                table: "ReleaseLines",
                column: "WarehouseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_StockKeepUnit",
                table: "ReceiveLines",
                column: "StockKeepUnit");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_WarehouseNumber",
                table: "ReceiveLines",
                column: "WarehouseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_StockKeepUnit",
                table: "InventoryLines",
                column: "StockKeepUnit");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_WarehouseNumber",
                table: "InventoryLines",
                column: "WarehouseNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLines_StockKeepUnits_StockKeepUnit",
                table: "InventoryLines",
                column: "StockKeepUnit",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLines_Warehouses_WarehouseNumber",
                table: "InventoryLines",
                column: "WarehouseNumber",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveLines_StockKeepUnits_StockKeepUnit",
                table: "ReceiveLines",
                column: "StockKeepUnit",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveLines_Warehouses_WarehouseNumber",
                table: "ReceiveLines",
                column: "WarehouseNumber",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseLines_StockKeepUnits_StockKeepUnit",
                table: "ReleaseLines",
                column: "StockKeepUnit",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseLines_Warehouses_WarehouseNumber",
                table: "ReleaseLines",
                column: "WarehouseNumber",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarhouseEntries_StockKeepUnits_KeepUnit",
                table: "WarhouseEntries",
                column: "KeepUnit",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarhouseEntries_Warehouses_WarehouseNumber",
                table: "WarhouseEntries",
                column: "WarehouseNumber",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLines_StockKeepUnits_StockKeepUnit",
                table: "InventoryLines");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLines_Warehouses_WarehouseNumber",
                table: "InventoryLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveLines_StockKeepUnits_StockKeepUnit",
                table: "ReceiveLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceiveLines_Warehouses_WarehouseNumber",
                table: "ReceiveLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseLines_StockKeepUnits_StockKeepUnit",
                table: "ReleaseLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ReleaseLines_Warehouses_WarehouseNumber",
                table: "ReleaseLines");

            migrationBuilder.DropForeignKey(
                name: "FK_WarhouseEntries_StockKeepUnits_KeepUnit",
                table: "WarhouseEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_WarhouseEntries_Warehouses_WarehouseNumber",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_WarhouseEntries_KeepUnit",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_WarhouseEntries_WarehouseNumber",
                table: "WarhouseEntries");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseLines_StockKeepUnit",
                table: "ReleaseLines");

            migrationBuilder.DropIndex(
                name: "IX_ReleaseLines_WarehouseNumber",
                table: "ReleaseLines");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveLines_StockKeepUnit",
                table: "ReceiveLines");

            migrationBuilder.DropIndex(
                name: "IX_ReceiveLines_WarehouseNumber",
                table: "ReceiveLines");

            migrationBuilder.DropIndex(
                name: "IX_InventoryLines_StockKeepUnit",
                table: "InventoryLines");

            migrationBuilder.DropIndex(
                name: "IX_InventoryLines_WarehouseNumber",
                table: "InventoryLines");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KeepUnit",
                table: "WarhouseEntries",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockKeepUnitCode",
                table: "WarhouseEntries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "WarhouseEntries",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "ReleaseLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockKeepUnit",
                table: "ReleaseLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockKeepUnittCode",
                table: "ReleaseLines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "ReleaseLines",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "ReceiveLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockKeepUnit",
                table: "ReceiveLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockKeepUnittCode",
                table: "ReceiveLines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "ReceiveLines",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseNumber",
                table: "InventoryLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StockKeepUnit",
                table: "InventoryLines",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockKeepUnittCode",
                table: "InventoryLines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseName",
                table: "InventoryLines",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_StockKeepUnitCode",
                table: "WarhouseEntries",
                column: "StockKeepUnitCode");

            migrationBuilder.CreateIndex(
                name: "IX_WarhouseEntries_WarehouseName",
                table: "WarhouseEntries",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_StockKeepUnittCode",
                table: "ReleaseLines",
                column: "StockKeepUnittCode");

            migrationBuilder.CreateIndex(
                name: "IX_ReleaseLines_WarehouseName",
                table: "ReleaseLines",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_StockKeepUnittCode",
                table: "ReceiveLines",
                column: "StockKeepUnittCode");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveLines_WarehouseName",
                table: "ReceiveLines",
                column: "WarehouseName");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_StockKeepUnittCode",
                table: "InventoryLines",
                column: "StockKeepUnittCode");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryLines_WarehouseName",
                table: "InventoryLines",
                column: "WarehouseName");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLines_StockKeepUnits_StockKeepUnittCode",
                table: "InventoryLines",
                column: "StockKeepUnittCode",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLines_Warehouses_WarehouseName",
                table: "InventoryLines",
                column: "WarehouseName",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveLines_StockKeepUnits_StockKeepUnittCode",
                table: "ReceiveLines",
                column: "StockKeepUnittCode",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiveLines_Warehouses_WarehouseName",
                table: "ReceiveLines",
                column: "WarehouseName",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseLines_StockKeepUnits_StockKeepUnittCode",
                table: "ReleaseLines",
                column: "StockKeepUnittCode",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReleaseLines_Warehouses_WarehouseName",
                table: "ReleaseLines",
                column: "WarehouseName",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarhouseEntries_StockKeepUnits_StockKeepUnitCode",
                table: "WarhouseEntries",
                column: "StockKeepUnitCode",
                principalTable: "StockKeepUnits",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WarhouseEntries_Warehouses_WarehouseName",
                table: "WarhouseEntries",
                column: "WarehouseName",
                principalTable: "Warehouses",
                principalColumn: "WarehouseName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
