using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixCloneAPI.Migrations
{
    public partial class OneCategoryPerResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category_resource");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "resource",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "resource");

            migrationBuilder.CreateTable(
                name: "category_resource",
                columns: table => new
                {
                    resource_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_resource", x => x.resource_id);
                    table.ForeignKey(
                        name: "FK_category_resource_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_category_resource_resource_resource_id",
                        column: x => x.resource_id,
                        principalTable: "resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_resource_category_id",
                table: "category_resource",
                column: "category_id");
        }
    }
}
