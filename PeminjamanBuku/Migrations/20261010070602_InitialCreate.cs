using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeminjamanBuku.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaKategori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Bukus",
                columns: table => new
                {
                    BukuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JudulBuku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Penulis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bukus", x => x.BukuId);
                    table.ForeignKey(
                        name: "FK_Bukus_Kategoris_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Peminjams",
                columns: table => new
                {
                    PeminjamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaPeminjam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdBuku = table.Column<int>(type: "int", nullable: false),
                    BukuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peminjams", x => x.PeminjamId);
                    table.ForeignKey(
                        name: "FK_Peminjams_Bukus_BukuId",
                        column: x => x.BukuId,
                        principalTable: "Bukus",
                        principalColumn: "BukuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bukus_KategoriId",
                table: "Bukus",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjams_BukuId",
                table: "Peminjams",
                column: "BukuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peminjams");

            migrationBuilder.DropTable(
                name: "Bukus");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
