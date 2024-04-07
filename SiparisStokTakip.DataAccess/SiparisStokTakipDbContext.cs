//using Microsoft.EntityFrameworkCore;
//using SiparisStokTakip.Entities;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Text;

//namespace SiparisStokTakip.DataAccess
//{
//    public class SiparisStokTakipDbContext : DbContext
//    {
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            base.OnConfiguring(optionsBuilder);
//            optionsBuilder.UseSqlServer("Server=KHSGBOFS04\\SQLEXPRESS;Database=SiparisStokTakip;Trusted_Connection=true;");
//        }
//        public DbSet<Siparis> Siparisler { get; set; }
//        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }
//        public DbSet<Tedarikci> Tedarikciler { get; set; }
//        public DbSet<Urun> Urunler { get; set; }
//        public DbSet<Kullanici> Kullanicilar { get; set; }
//        public DbSet<GelirGider> GelirGiderler { get; set; }
//    }
//}

using Microsoft.EntityFrameworkCore; // EF Core için
using SiparisStokTakip.Entities;
// System.Data.Entity kaldırıldı, EF Core ile çakışıyor.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SiparisStokTakip.DataAccess
{
    public class SiparisStokTakipDbContext : DbContext // EF Core DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Veritabanı bağlantı stringinizi burada belirtin
                optionsBuilder.UseSqlServer("Server=KHSGBOFS04\\SQLEXPRESS;Database=SiparisStokTakip;Trusted_Connection=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<GelirGider> GelirGiderler { get; set; }
    }
}