using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sinemaotomasyonu.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "görevlis",
                columns: table => new
                {
                    görevliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    görevliAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    görevliSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    görevliMaas = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_görevlis", x => x.görevliID);
                });

            migrationBuilder.CreateTable(
                name: "mekanlars",
                columns: table => new
                {
                    mekanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mekanAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mekanAdres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mekanlars", x => x.mekanID);
                });

            migrationBuilder.CreateTable(
                name: "seanslars",
                columns: table => new
                {
                    seansID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seansAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seansSaati = table.Column<DateTime>(type: "datetime2", nullable: false),
                    görevliID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seanslars", x => x.seansID);
                    table.ForeignKey(
                        name: "FK_seanslars_görevlis_görevliID",
                        column: x => x.görevliID,
                        principalTable: "görevlis",
                        principalColumn: "görevliID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "filmlers",
                columns: table => new
                {
                    filmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filmKonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmUcret = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mekanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmlers", x => x.filmID);
                    table.ForeignKey(
                        name: "FK_filmlers_mekanlars_mekanID",
                        column: x => x.mekanID,
                        principalTable: "mekanlars",
                        principalColumn: "mekanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "izleyicilers",
                columns: table => new
                {
                    izleyiciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    izleyiciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    izleyiciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seansID = table.Column<int>(type: "int", nullable: false),
                    SeanslarseansID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_izleyicilers", x => x.izleyiciID);
                    table.ForeignKey(
                        name: "FK_izleyicilers_seanslars_SeanslarseansID",
                        column: x => x.SeanslarseansID,
                        principalTable: "seanslars",
                        principalColumn: "seansID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "koltuklars",
                columns: table => new
                {
                    koltukID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    koltukAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    koltukÇeşidi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmID = table.Column<int>(type: "int", nullable: false),
                    FilmlerfilmID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_koltuklars", x => x.koltukID);
                    table.ForeignKey(
                        name: "FK_koltuklars_filmlers_FilmlerfilmID",
                        column: x => x.FilmlerfilmID,
                        principalTable: "filmlers",
                        principalColumn: "filmID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filmlers_mekanID",
                table: "filmlers",
                column: "mekanID");

            migrationBuilder.CreateIndex(
                name: "IX_izleyicilers_SeanslarseansID",
                table: "izleyicilers",
                column: "SeanslarseansID");

            migrationBuilder.CreateIndex(
                name: "IX_koltuklars_FilmlerfilmID",
                table: "koltuklars",
                column: "FilmlerfilmID");

            migrationBuilder.CreateIndex(
                name: "IX_seanslars_görevliID",
                table: "seanslars",
                column: "görevliID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "izleyicilers");

            migrationBuilder.DropTable(
                name: "koltuklars");

            migrationBuilder.DropTable(
                name: "seanslars");

            migrationBuilder.DropTable(
                name: "filmlers");

            migrationBuilder.DropTable(
                name: "görevlis");

            migrationBuilder.DropTable(
                name: "mekanlars");
        }
    }
}
