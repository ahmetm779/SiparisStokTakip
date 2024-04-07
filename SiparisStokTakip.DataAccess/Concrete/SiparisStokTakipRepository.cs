using Microsoft.EntityFrameworkCore;
using SiparisStokTakip.DataAccess.Abstract;
using SiparisStokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SiparisStokTakip.DataAccess.Concrete
{
    public class SiparisStokTakipRepository : ISiparisStokTakipRepository
    {
        public async Task<GelirGider> CreateGelirGiderBilgileri(GelirGider gelirGider)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.GelirGiderler.Add(gelirGider);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return gelirGider;
            }
        }

        public async Task<Kullanici> CreateKullaniciBilgileri(Kullanici kullaniciBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Kullanicilar.Add(kullaniciBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return kullaniciBilgileri;
            }
        }

        public async Task<Siparis> CreateSiparisBilgileri(Siparis siparisBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Siparisler.Add(siparisBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return siparisBilgileri;
            }
        }

        public async Task<SiparisDetay> CreateSiparisDetayBilgileri(SiparisDetay siparisDetayBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.SiparisDetaylari.Add(siparisDetayBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return siparisDetayBilgileri;
            }
        }

        public async Task<Tedarikci> CreateTedarikciBilgileri(Tedarikci tedarikciBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Tedarikciler.Add(tedarikciBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return tedarikciBilgileri;
            }
        }

        public async Task<Urun> CreateUrunBilgileri(Urun urunBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Urunler.Add(urunBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return urunBilgileri;
            }
        }

        public async Task DeleteGelirGiderBilgileri(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                var deleted = await GetGelirGiderBilgileriById(id);
                siparisStokTakipDbContext.GelirGiderler.Remove(deleted);
                await siparisStokTakipDbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteKullaniciBilgileri(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                var deleted = await GetKullaniciBilgileriById(id);
                siparisStokTakipDbContext.Kullanicilar.Remove(deleted);
                await siparisStokTakipDbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteSiparisBilgileri(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                var deleted = await GetSiparisBilgileriById(id);
                siparisStokTakipDbContext.Siparisler.Remove(deleted);
                await siparisStokTakipDbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteSiparisDetayBilgileri(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                var deleted = await GetSiparisDetayBilgileriById(id);
                siparisStokTakipDbContext.SiparisDetaylari.Remove(deleted);
                await siparisStokTakipDbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteTedarikciBilgileri(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                var deleted = await GetTedarikciBilgileriById(id);
                siparisStokTakipDbContext.Tedarikciler.Remove(deleted);
                await siparisStokTakipDbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteUrunBilgileri(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                var deleted = await GetUrunBilgileriById(id);
                siparisStokTakipDbContext.Urunler.Remove(deleted);
                await siparisStokTakipDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<GelirGider>> GetAllGelirGiderBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.GelirGiderler.ToListAsync();
            }
        }

        public async Task<List<Kullanici>> GetAllKullaniciBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Kullanicilar.ToListAsync();
            }
        }

        public async Task<List<Kullanici>> GetAllMusteriBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Kullanicilar.ToListAsync();
            }
        }

        public async Task<List<Kullanici>> GetAllPersonelBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Kullanicilar.ToListAsync();
            }
        }

        public async Task<List<Siparis>> GetAllSiparisBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Siparisler.ToListAsync();
            }
        }

        public async Task<List<SiparisDetay>> GetAllSiparisDetayBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.SiparisDetaylari.ToListAsync();
            }
        }

        public async Task<List<Tedarikci>> GetAllTedarikciBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Tedarikciler.ToListAsync();
            }
        }

        public async Task<List<Urun>> GetAllUrunBilgileri()
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Urunler.ToListAsync();
            }
        }

        public async Task<GelirGider> GetGelirGiderBilgileriById(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.GelirGiderler.FindAsync(id);
            }
        }

        public async Task<Kullanici> GetKullaniciBilgileriById(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Kullanicilar.FindAsync(id);
            }
        }

        public async Task<Siparis> GetSiparisBilgileriById(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Siparisler.FindAsync(id);
            }
        }

        //public async Task<List<Siparis>> GetSiparisBilgileriByMusteriId(int musteriID)
        //{
        //    using(var siparisStokTakipDbContext=new SiparisStokTakipDbContext())
        //    {
        //        return await siparisStokTakipDbContext.Siparisler.Where(s => s.MusteriID == musteriID).ToListAsync();
        //    }
        //}

        public async Task<SiparisDetay> GetSiparisDetayBilgileriById(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.SiparisDetaylari.FindAsync(id);
            }
        }

        public async Task<Tedarikci> GetTedarikciBilgileriById(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Tedarikciler.FindAsync(id);
            }
        }

        public async Task<Urun> GetUrunBilgileriById(int id)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                return await siparisStokTakipDbContext.Urunler.FindAsync(id);
            }
        }

        public async Task<GelirGider> UpdateGelirGiderBilgileri(GelirGider gelirGider)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.GelirGiderler.Update(gelirGider);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return gelirGider;
            }
        }

        public async Task<Kullanici> UpdateKullaniciBilgileri(Kullanici kullaniciBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Kullanicilar.Update(kullaniciBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return kullaniciBilgileri;
            }
        }

        public async Task<Siparis> UpdateSiparisBilgileri(Siparis siparisBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Siparisler.Update(siparisBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return siparisBilgileri;
            }
        }

        public async Task<SiparisDetay> UpdateSiparisDetayBilgileri(SiparisDetay siparisDetayBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.SiparisDetaylari.Update(siparisDetayBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return siparisDetayBilgileri;
            }
        }

        public async Task<Tedarikci> UpdateTedarikciBilgileri(Tedarikci tedarikciBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Tedarikciler.Update(tedarikciBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return tedarikciBilgileri;
            }
        }

        public async Task<Urun> UpdateUrunBilgileri(Urun urunBilgileri)
        {
            using (var siparisStokTakipDbContext = new SiparisStokTakipDbContext())
            {
                siparisStokTakipDbContext.Urunler.Update(urunBilgileri);
                await siparisStokTakipDbContext.SaveChangesAsync();
                return urunBilgileri;
            }
        }
    }
}
