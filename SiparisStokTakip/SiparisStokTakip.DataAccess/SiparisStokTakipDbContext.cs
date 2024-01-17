using Microsoft.EntityFrameworkCore;
using SiparisStokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiparisStokTakip.DataAccess
{
    public class SiparisStokTakipDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=KHSGBOFS04\\SQLEXPRESS;Database=SiparisStokTakip;Trusted_Connection=true;");
        }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}
