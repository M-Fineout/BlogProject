using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProj.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageSource",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "RecipeImageSource",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeImageSource",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "ImageSource",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
