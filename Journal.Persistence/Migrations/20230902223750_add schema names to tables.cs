using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Journal.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addschemanamestotables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.EnsureSchema(
                name: "common");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "posts",
                newSchema: "common");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories",
                newSchema: "common");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryId",
                schema: "common",
                table: "posts",
                newName: "IX_posts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_posts",
                schema: "common",
                table: "posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                schema: "common",
                table: "categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_posts_categories_CategoryId",
                schema: "common",
                table: "posts",
                column: "CategoryId",
                principalSchema: "common",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posts_categories_CategoryId",
                schema: "common",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_posts",
                schema: "common",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                schema: "common",
                table: "categories");

            migrationBuilder.RenameTable(
                name: "posts",
                schema: "common",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "categories",
                schema: "common",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_posts_CategoryId",
                table: "Posts",
                newName: "IX_Posts_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
