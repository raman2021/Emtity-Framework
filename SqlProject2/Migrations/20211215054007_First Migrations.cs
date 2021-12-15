using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlProject2.Migrations
{
    public partial class FirstMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productModels",
                columns: table => new
                {
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    price = table.Column<string>(type: "TEXT", nullable: false),
                    ProductDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productModels", x => x.ProductName);
                });

            migrationBuilder.CreateTable(
                name: "saleItemModels",
                columns: table => new
                {
                    ProductSaleName = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<string>(type: "TEXT", nullable: false),
                    Startdate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Enddate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleItemModels", x => x.ProductSaleName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productModels");

            migrationBuilder.DropTable(
                name: "saleItemModels");
        }
    }
}
