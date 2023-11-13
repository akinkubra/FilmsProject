using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmsProject.Migrations
{
    /// <inheritdoc />
    public partial class AlterTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Films_FilmId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_FilmId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Categories");

            migrationBuilder.CreateIndex(
                name: "IX_Films_CategoryId",
                table: "Films",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Films_CategoryId",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_FilmId",
                table: "Categories",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Films_FilmId",
                table: "Categories",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
