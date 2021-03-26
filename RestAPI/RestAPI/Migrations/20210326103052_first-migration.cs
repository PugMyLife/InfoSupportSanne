using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestAPI.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CursusDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titel = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    cursusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursusDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CursusInstanties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cursusDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursusInstanties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursusInstanties_CursusDetails_cursusDetailId",
                        column: x => x.cursusDetailId,
                        principalTable: "CursusDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursusInstanties_cursusDetailId",
                table: "CursusInstanties",
                column: "cursusDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursusInstanties");

            migrationBuilder.DropTable(
                name: "CursusDetails");
        }
    }
}
