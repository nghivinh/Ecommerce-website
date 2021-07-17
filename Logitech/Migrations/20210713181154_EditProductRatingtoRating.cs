using Microsoft.EntityFrameworkCore.Migrations;

namespace Logitech.Migrations
{
    public partial class EditProductRatingtoRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "ProductRatings",
                newName: "Star");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Star",
                table: "ProductRatings",
                newName: "Rating");
        }
    }
}
