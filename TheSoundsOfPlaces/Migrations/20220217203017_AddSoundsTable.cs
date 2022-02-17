using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheSoundsOfPlaces.Migrations
{
    public partial class AddSoundsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", nullable: false),
                    Text = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BannerImage = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    SoundUrl = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    Slug = table.Column<string>(type: "varchar(50)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<string>(type: "varchar(50)", nullable: false),
                    Longitude = table.Column<string>(type: "varchar(50)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sounds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sounds");
        }
    }
}
