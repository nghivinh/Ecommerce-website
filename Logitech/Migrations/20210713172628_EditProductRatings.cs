using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logitech.Migrations
{
    public partial class EditProductRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "ProductRatings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ProductRatings",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "ProductRatings");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ProductRatings");
        }
    }
}
