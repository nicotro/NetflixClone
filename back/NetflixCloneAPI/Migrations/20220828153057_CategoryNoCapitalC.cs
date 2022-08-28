using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixCloneAPI.Migrations
{
    public partial class CategoryNoCapitalC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "resource",
                newName: "category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category",
                table: "resource",
                newName: "Category");
        }
    }
}
