using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmsAPI.Migrations
{
    public partial class IntitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmDirector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
