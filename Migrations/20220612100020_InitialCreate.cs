using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HasashinShop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(nullable: true),
                    LoaiSP = table.Column<string>(nullable: true),
                    NgayMua = table.Column<DateTime>(nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    ImageProduct = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
