using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CelilCavus.OgrenciKayitSistemi.Migrations
{
    /// <inheritdoc />
    public partial class FluenApiRemoveIsRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "soyad",
                table: "Ogrencis",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "Öğrenci Soyadi Tanimsiz.",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "Öğrenci Soyadi Tanimsiz.");

            migrationBuilder.AlterColumn<string>(
                name: "cinsiyet",
                table: "Ogrencis",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValue: "Öğrenci Cinsiyet Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValue: "Öğrenci Cinsiyet Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "bolum",
                table: "Ogrencis",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValue: "Öğrenci Bölüm Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValue: "Öğrenci Bölüm Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ad",
                table: "Ogrencis",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValue: "Öğrenci Adi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "Öğrenci Adi Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ders_kodu",
                table: "Derslers",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValue: "00000",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldDefaultValue: "00000");

            migrationBuilder.AlterColumn<string>(
                name: "ders_hocasi",
                table: "Derslers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValue: "Ders Hocasi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldDefaultValue: "Ders Hocasi Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ders_donemi",
                table: "Derslers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValue: "Ders Dönemi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValue: "Ders Dönemi Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ders_adi",
                table: "Derslers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValue: "Ders Adi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldDefaultValue: "Ders Adi Tanimsiz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "soyad",
                table: "Ogrencis",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Öğrenci Soyadi Tanimsiz.",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "Öğrenci Soyadi Tanimsiz.");

            migrationBuilder.AlterColumn<string>(
                name: "cinsiyet",
                table: "Ogrencis",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "Öğrenci Cinsiyet Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "Öğrenci Cinsiyet Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "bolum",
                table: "Ogrencis",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "Öğrenci Bölüm Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "Öğrenci Bölüm Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ad",
                table: "Ogrencis",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Öğrenci Adi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValue: "Öğrenci Adi Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ders_kodu",
                table: "Derslers",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "00000",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValue: "00000");

            migrationBuilder.AlterColumn<string>(
                name: "ders_hocasi",
                table: "Derslers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "Ders Hocasi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValue: "Ders Hocasi Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ders_donemi",
                table: "Derslers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "Ders Dönemi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "Ders Dönemi Tanimsiz");

            migrationBuilder.AlterColumn<string>(
                name: "ders_adi",
                table: "Derslers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "Ders Adi Tanimsiz",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValue: "Ders Adi Tanimsiz");
        }
    }
}
