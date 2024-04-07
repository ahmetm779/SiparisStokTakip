using SiparisStokTakip.Business.Abstract;
using SiparisStokTakip.DataAccess.Abstract;
using SiparisStokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiparisStokTakip.Business.Concrete
{
    public class SiparisStokTakipManager : ISiparisStokTakipService
    {
        private ISiparisStokTakipRepository _siparisStokTakipRepository;
        public SiparisStokTakipManager(ISiparisStokTakipRepository siparisStokTakipRepository)
        {
            _siparisStokTakipRepository = siparisStokTakipRepository;
        }

        public async Task<GelirGider> CreateGelirGiderBilgileri(GelirGider gelirGider)
        {
            return await _siparisStokTakipRepository.CreateGelirGiderBilgileri(gelirGider);
        }

        public async Task<Kullanici> CreateKullaniciBilgileri(Kullanici kullaniciBilgileri)
        {
            return await _siparisStokTakipRepository.CreateKullaniciBilgileri(kullaniciBilgileri);
        }

        public async Task<Siparis> CreateSiparisBilgileri(Siparis siparisBilgileri)
        {
            return await _siparisStokTakipRepository.CreateSiparisBilgileri(siparisBilgileri);
        }

        public async Task<SiparisDetay> CreateSiparisDetayBilgileri(SiparisDetay siparisDetayBilgileri)
        {
            return await _siparisStokTakipRepository.CreateSiparisDetayBilgileri(siparisDetayBilgileri);
        }

        public async Task<Tedarikci> CreateTedarikciBilgileri(Tedarikci tedarikciBilgileri)
        {
            return await _siparisStokTakipRepository.CreateTedarikciBilgileri(tedarikciBilgileri);
        }

        public async Task<Urun> CreateUrunBilgileri(Urun urunBilgileri)
        {
            return await _siparisStokTakipRepository.CreateUrunBilgileri(urunBilgileri);
        }

        public async Task DeleteGelirGiderBilgileri(int id)
        {
            await _siparisStokTakipRepository.DeleteGelirGiderBilgileri(id);
        }

        public async Task DeleteKullaniciBilgileri(int id)
        {
            await _siparisStokTakipRepository.DeleteKullaniciBilgileri(id);
        }

        public async Task DeleteSiparisBilgileri(int id)
        {
            await _siparisStokTakipRepository.DeleteSiparisBilgileri(id);
        }

        public async Task DeleteSiparisDetayBilgileri(int id)
        {
            await _siparisStokTakipRepository.DeleteSiparisDetayBilgileri(id);
        }

        public async Task DeleteTedarikciBilgileri(int id)
        {
            await _siparisStokTakipRepository.DeleteTedarikciBilgileri(id);
        }

        public async Task DeleteUrunBilgileri(int id)
        {
            await _siparisStokTakipRepository.DeleteUrunBilgileri(id);
        }

        public async Task<List<GelirGider>> GetAllGelirGiderBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllGelirGiderBilgileri();
        }

        public async Task<List<Kullanici>> GetAllKullaniciBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllKullaniciBilgileri();
        }

        public async Task<List<Kullanici>> GetAllMusteriBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllMusteriBilgileri();
        }

        public async Task<List<Kullanici>> GetAllPersonelBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllPersonelBilgileri();
        }

        public async Task<List<Siparis>> GetAllSiparisBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllSiparisBilgileri();
        }

        public async Task<List<SiparisDetay>> GetAllSiparisDetayBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllSiparisDetayBilgileri();
        }

        public async Task<List<Tedarikci>> GetAllTedarikciBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllTedarikciBilgileri();
        }

        public async Task<List<Urun>> GetAllUrunBilgileri()
        {
            return await _siparisStokTakipRepository.GetAllUrunBilgileri();
        }

        public async Task<GelirGider> GetGelirGiderBilgileriById(int id)
        {
            if (id > 0)
            {
                return await _siparisStokTakipRepository.GetGelirGiderBilgileriById(id);
            }
            throw new Exception("ID 1 den küçük olamaz");
        }

        public async Task<Kullanici> GetKullaniciBilgileriById(int id)
        {
            if (id > 0)
            {
                return await _siparisStokTakipRepository.GetKullaniciBilgileriById(id);
            }
            throw new Exception("ID 1 den küçük olamaz");
        }

        public async Task<Siparis> GetSiparisBilgileriById(int id)
        {
            if (id > 0)
            {
                return await _siparisStokTakipRepository.GetSiparisBilgileriById(id);
            }
            throw new Exception("ID 1 den küçük olamaz");
        }

        //public async Task<List<Siparis>> GetSiparisBilgileriByMusteriId(int musteriID)
        //{
        //    return await _siparisStokTakipRepository.GetSiparisBilgileriByMusteriId(musteriID);
        //}

        public async Task<SiparisDetay> GetSiparisDetayBilgileriById(int id)
        {
            return await _siparisStokTakipRepository.GetSiparisDetayBilgileriById(id);
        }

        public async Task<Tedarikci> GetTedarikciBilgileriById(int id)
        {
            return await _siparisStokTakipRepository.GetTedarikciBilgileriById(id);
        }

        public async Task<Urun> GetUrunBilgileriById(int id)
        {
            return await _siparisStokTakipRepository.GetUrunBilgileriById(id);
        }

        public async Task<GelirGider> UpdateGelirGiderBilgileri(GelirGider gelirGider)
        {
            return await _siparisStokTakipRepository.UpdateGelirGiderBilgileri(gelirGider);
        }

        public async Task<Kullanici> UpdateKullaniciBilgileri(Kullanici kullaniciBilgileri)
        {
            return await _siparisStokTakipRepository.UpdateKullaniciBilgileri(kullaniciBilgileri);
        }

        public async Task<Siparis> UpdateSiparisBilgileri(Siparis siparisBilgileri)
        {
            return await _siparisStokTakipRepository.UpdateSiparisBilgileri(siparisBilgileri);
        }

        public async Task<SiparisDetay> UpdateSiparisDetayBilgileri(SiparisDetay siparisDetayBilgileri)
        {
            return await _siparisStokTakipRepository.UpdateSiparisDetayBilgileri(siparisDetayBilgileri);
        }

        public async Task<Tedarikci> UpdateTedarikciBilgileri(Tedarikci tedarikciBilgileri)
        {
            return await _siparisStokTakipRepository.UpdateTedarikciBilgileri(tedarikciBilgileri);
        }

        public async Task<Urun> UpdateUrunBilgileri(Urun urunBilgileri)
        {
            return await _siparisStokTakipRepository.UpdateUrunBilgileri(urunBilgileri);
        }
    }
}
