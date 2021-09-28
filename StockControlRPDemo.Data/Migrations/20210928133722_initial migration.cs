using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControlRPDemo.Data.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "St_ItemMasters",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ItemDesc = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    StoreLoc = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Storerack = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Storebin = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ReOrderLevel = table.Column<int>(type: "int", nullable: true),
                    ReOrderQty = table.Column<int>(type: "int", nullable: true),
                    Units = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    XRef = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Supplier1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Supplier2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Supplier3 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Supplier4 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Supplier5 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Supplier6 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Class = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BusLine = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PartNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_St_ItemMasters", x => new { x.ItemCode, x.ItemDesc });
                });

            migrationBuilder.CreateTable(
                name: "St_Suppliers",
                columns: table => new
                {
                    SupplierCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Sup_Last_Num = table.Column<int>(type: "int", nullable: true),
                    Sup_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_St_Suppliers", x => x.SupplierCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "St_ItemMasters");

            migrationBuilder.DropTable(
                name: "St_Suppliers");
        }
    }
}
