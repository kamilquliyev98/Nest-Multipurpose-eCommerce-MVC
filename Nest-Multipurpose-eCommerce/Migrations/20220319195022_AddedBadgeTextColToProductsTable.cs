using Microsoft.EntityFrameworkCore.Migrations;

namespace Nest_Multipurpose_eCommerce.Migrations
{
    public partial class AddedBadgeTextColToProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BadgeText",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BadgeText",
                table: "Products");
        }
    }
}
