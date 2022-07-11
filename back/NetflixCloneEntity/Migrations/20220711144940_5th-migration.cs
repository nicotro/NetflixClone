using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixCloneEntity.Migrations
{
    public partial class _5thmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resource_id",
                table: "video");

            migrationBuilder.DropColumn(
                name: "resource_id",
                table: "image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "resource_id",
                table: "video",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "resource_id",
                table: "image",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
