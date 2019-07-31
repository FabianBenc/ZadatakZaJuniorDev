using Microsoft.EntityFrameworkCore.Migrations;

namespace zadatakZaProgramere.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kontakti",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ime = table.Column<string>(nullable: true),
                    prezime = table.Column<string>(nullable: true),
                    grad = table.Column<string>(nullable: true),
                    opis = table.Column<string>(nullable: true),
                    slika = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kontakti", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "telefon",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kontaktiid = table.Column<int>(nullable: false),
                    broj = table.Column<string>(nullable: true),
                    tip = table.Column<string>(nullable: true),
                    opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telefon", x => x.id);
                    table.ForeignKey(
                        name: "FK_telefon_kontakti_Kontaktiid",
                        column: x => x.Kontaktiid,
                        principalTable: "kontakti",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_telefon_Kontaktiid",
                table: "telefon",
                column: "Kontaktiid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "telefon");

            migrationBuilder.DropTable(
                name: "kontakti");
        }
    }
}
