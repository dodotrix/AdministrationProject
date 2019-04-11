using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Administration.DataAccess.Migrations
{
    public partial class DodaniZahvatiiMiddleTablica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zahvati",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sifra = table.Column<string>(maxLength: 50, nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Cijena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahvati", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PacijentZahvati",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PacijentID = table.Column<int>(nullable: false),
                    ZahvatID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacijentZahvati", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PacijentZahvati_Pacijenti_PacijentID",
                        column: x => x.PacijentID,
                        principalTable: "Pacijenti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacijentZahvati_Zahvati_ZahvatID",
                        column: x => x.ZahvatID,
                        principalTable: "Zahvati",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacijentZahvati_PacijentID",
                table: "PacijentZahvati",
                column: "PacijentID");

            migrationBuilder.CreateIndex(
                name: "IX_PacijentZahvati_ZahvatID",
                table: "PacijentZahvati",
                column: "ZahvatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacijentZahvati");

            migrationBuilder.DropTable(
                name: "Zahvati");
        }
    }
}
