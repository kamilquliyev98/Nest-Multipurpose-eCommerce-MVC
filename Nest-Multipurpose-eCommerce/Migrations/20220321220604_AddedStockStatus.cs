using Microsoft.EntityFrameworkCore.Migrations;

namespace Nest_Multipurpose_eCommerce.Migrations
{
    public partial class AddedStockStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StockStatus",
                table: "Products",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockStatusText",
                table: "Products",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockStatus",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockStatusText",
                table: "Products");
        }
    }
}
