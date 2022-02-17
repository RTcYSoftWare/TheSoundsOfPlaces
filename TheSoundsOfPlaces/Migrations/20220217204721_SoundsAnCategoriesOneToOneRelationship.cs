using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSoundsOfPlaces.Migrations
{
    public partial class SoundsAnCategoriesOneToOneRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Sounds_CategoryId",
                table: "Sounds",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sounds_Categories_CategoryId",
                table: "Sounds",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sounds_Categories_CategoryId",
                table: "Sounds");

            migrationBuilder.DropIndex(
                name: "IX_Sounds_CategoryId",
                table: "Sounds");
        }
    }
}
