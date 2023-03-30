using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CelilCavus.OgrenciKayitSistemi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derslers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    derskodu = table.Column<string>(name: "ders_kodu", type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValue: "00000"),
                    dersadi = table.Column<string>(name: "ders_adi", type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValue: "Ders Adi Tanimsiz"),
                    dershocasi = table.Column<string>(name: "ders_hocasi", type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValue: "Ders Hocasi Tanimsiz"),
                    dersdonemi = table.Column<string>(name: "ders_donemi", type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Ders Dönemi Tanimsiz")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Öğrenci Adi Tanimsiz"),
                    soyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Öğrenci Soyadi Tanimsiz."),
                    cinsiyet = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Öğrenci Cinsiyet Tanimsiz"),
                    bolum = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "Öğrenci Bölüm Tanimsiz"),
                    sinif = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Derslers");

            migrationBuilder.DropTable(
                name: "Ogrencis");
        }
    }
}
