using Microsoft.EntityFrameworkCore.Migrations;

namespace RozproszoneZajecia.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dzieci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Wiek = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dzieci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "zestawy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(nullable: true),
                    Wielkość = table.Column<float>(nullable: false),
                    Cena = table.Column<float>(nullable: false),
                    dzieciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zestawy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_zestawy_dzieci_dzieciId",
                        column: x => x.dzieciId,
                        principalTable: "dzieci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "klocki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ilosc = table.Column<int>(nullable: false),
                    zestawId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_klocki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_klocki_zestawy_zestawId",
                        column: x => x.zestawId,
                        principalTable: "zestawy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_klocki_zestawId",
                table: "klocki",
                column: "zestawId");

            migrationBuilder.CreateIndex(
                name: "IX_zestawy_dzieciId",
                table: "zestawy",
                column: "dzieciId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "klocki");

            migrationBuilder.DropTable(
                name: "zestawy");

            migrationBuilder.DropTable(
                name: "dzieci");
        }
    }
}
