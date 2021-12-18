using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiceProject.Data.Migrations
{
    public partial class AddShoppingCartToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ShoppingCart",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ShoppingCart");
        }
    }
}
