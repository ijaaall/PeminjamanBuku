using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeminjamanBuku.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreateNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bukus_Kategoris_KategoriId",
                table: "Bukus");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Bukus_KategoriId",
                table: "Bukus");

            migrationBuilder.DropColumn(
                name: "NamaPeminjam",
                table: "Peminjams");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Bukus",
                newName: "Stok");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Peminjams",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AnggotaId",
                table: "Peminjams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PetugasId",
                table: "Peminjams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalHarusKembali",
                table: "Peminjams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalPinjam",
                table: "Peminjams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "JudulBuku",
                table: "Bukus",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "KodeBuku",
                table: "Bukus",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Anggotas",
                columns: table => new
                {
                    AnggotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nisn = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NamaAnggota = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JenisKelamin = table.Column<int>(type: "int", nullable: false),
                    Kelas = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anggotas", x => x.AnggotaId);
                });

            migrationBuilder.CreateTable(
                name: "Pengembalians",
                columns: table => new
                {
                    PengembalianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeminjamanId = table.Column<int>(type: "int", nullable: false),
                    TanggalKembali = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerlambatHari = table.Column<int>(type: "int", nullable: false),
                    Denda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengembalians", x => x.PengembalianId);
                    table.ForeignKey(
                        name: "FK_Pengembalians_Peminjams_PeminjamanId",
                        column: x => x.PeminjamanId,
                        principalTable: "Peminjams",
                        principalColumn: "PeminjamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Petugas",
                columns: table => new
                {
                    PetugasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaPetugas = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jabatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petugas", x => x.PetugasId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peminjams_AnggotaId",
                table: "Peminjams",
                column: "AnggotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjams_PetugasId",
                table: "Peminjams",
                column: "PetugasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pengembalians_PeminjamanId",
                table: "Pengembalians",
                column: "PeminjamanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peminjams_Anggotas_AnggotaId",
                table: "Peminjams",
                column: "AnggotaId",
                principalTable: "Anggotas",
                principalColumn: "AnggotaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peminjams_Petugas_PetugasId",
                table: "Peminjams",
                column: "PetugasId",
                principalTable: "Petugas",
                principalColumn: "PetugasId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peminjams_Anggotas_AnggotaId",
                table: "Peminjams");

            migrationBuilder.DropForeignKey(
                name: "FK_Peminjams_Petugas_PetugasId",
                table: "Peminjams");

            migrationBuilder.DropTable(
                name: "Anggotas");

            migrationBuilder.DropTable(
                name: "Pengembalians");

            migrationBuilder.DropTable(
                name: "Petugas");

            migrationBuilder.DropIndex(
                name: "IX_Peminjams_AnggotaId",
                table: "Peminjams");

            migrationBuilder.DropIndex(
                name: "IX_Peminjams_PetugasId",
                table: "Peminjams");

            migrationBuilder.DropColumn(
                name: "AnggotaId",
                table: "Peminjams");

            migrationBuilder.DropColumn(
                name: "PetugasId",
                table: "Peminjams");

            migrationBuilder.DropColumn(
                name: "TanggalHarusKembali",
                table: "Peminjams");

            migrationBuilder.DropColumn(
                name: "TanggalPinjam",
                table: "Peminjams");

            migrationBuilder.DropColumn(
                name: "KodeBuku",
                table: "Bukus");

            migrationBuilder.RenameColumn(
                name: "Stok",
                table: "Bukus",
                newName: "KategoriId");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Peminjams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "NamaPeminjam",
                table: "Peminjams",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "JudulBuku",
                table: "Bukus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

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
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    OperatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.OperatorId);
                    table.ForeignKey(
                        name: "FK_Operators_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bukus_KategoriId",
                table: "Bukus",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Operators_RoleId",
                table: "Operators",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bukus_Kategoris_KategoriId",
                table: "Bukus",
                column: "KategoriId",
                principalTable: "Kategoris",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
