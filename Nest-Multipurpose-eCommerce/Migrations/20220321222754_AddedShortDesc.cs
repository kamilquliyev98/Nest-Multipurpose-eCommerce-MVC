using Microsoft.EntityFrameworkCore.Migrations;

namespace Nest_Multipurpose_eCommerce.Migrations
{
    public partial class AddedShortDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Products",
                maxLength: 1000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Products");
        }
    }
}
