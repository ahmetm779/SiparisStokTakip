using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiparisStokTakip.DataAccess.Migrations
{
    public partial class _20240121 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GelirGiderler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Malzeme = table.Column<string>(nullable: true),
                    VerilenTL = table.Column<int>(nullable: false),
                    VerilenUSD = table.Column<int>(nullable: false),
                    AlınanTL = table.Column<int>(nullable: false),
                    AlınanUSD = table.Column<int>(nullable: false),
                    USDAlirkenVergi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GelirGiderler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    Adi = table.Column<string>(nullable: false),
                    Soyadi = table.Column<string>(nullable: false),
                    Adres = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(nullable: false),
                    Eposta = table.Column<string>(nullable: false),
                    KullaniciAdi = table.Column<string>(nullable: false),
                    Sifre = table.Column<string>(nullable: false),
                    Rol = table.Column<string>(nullable: false),
                    Durum = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetaylari",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisID = table.Column<int>(nullable: false),
                    UrunID = table.Column<int>(nullable: false),
                    Adet = table.Column<int>(nullable: false),
                    BirimFiyat = table.Column<int>(nullable: false),
                    İndirimOrani = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetaylari", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(nullable: false),
                    UrunID = table.Column<int>(nullable: false),
                    SiparisTarihi = table.Column<DateTime>(nullable: false),
                    ToplamTutar = table.Column<int>(nullable: false),
                    SiparisDurumu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: false),
                    Adres = table.Column<string>(nullable: false),
                    Telefon = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: false),
                    BirimFiyati = table.Column<int>(nullable: false),
                    StokMiktari = table.Column<int>(nullable: false),
                    MinimumMiktari = table.Column<int>(nullable: false),
                    TedarikciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GelirGiderler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "SiparisDetaylari");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
