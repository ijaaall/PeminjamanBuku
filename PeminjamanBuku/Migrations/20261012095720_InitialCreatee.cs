using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeminjamanBuku.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdBuku",
                table: "Peminjams");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Peminjams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Peminjams");

            migrationBuilder.AddColumn<int>(
                name: "IdBuku",
                table: "Peminjams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
