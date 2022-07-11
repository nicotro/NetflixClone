using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetflixCloneEntity.Migrations
{
    public partial class _4thmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryResource",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ResourcesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryResource", x => new { x.CategoriesId, x.ResourcesId });
                    table.ForeignKey(
                        name: "FK_CategoryResource_category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryResource_resource_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    resource_id = table.Column<int>(type: "int", nullable: false),
                    size_type = table.Column<int>(type: "int", nullable: false),
                    url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_image_resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "resource",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "video",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    resource_id = table.Column<int>(type: "int", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_video_resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "resource",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryResource_ResourcesId",
                table: "CategoryResource",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_image_ResourceId",
                table: "image",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_video_ResourceId",
                table: "video",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryResource");

            migrationBuilder.DropTable(
                name: "image");

            migrationBuilder.DropTable(
                name: "video");
        }
    }
}
