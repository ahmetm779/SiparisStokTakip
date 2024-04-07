using SiparisStokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiparisStokTakip.Business.Abstract
{
    public interface ISiparisStokTakipService
    {

        Task<List<Siparis>> GetAllSiparisBilgileri();
        Task<Siparis> GetSiparisBilgileriById(int id);
        //Task<List<Siparis>> GetSiparisBilgileriByMusteriId(int musteriID);
        Task<Siparis> CreateSiparisBilgileri(Siparis siparisBilgileri);
        Task<Siparis> UpdateSiparisBilgileri(Siparis siparisBilgileri);
        Task DeleteSiparisBilgileri(int id);

        Task<List<SiparisDetay>> GetAllSiparisDetayBilgileri();
        Task<SiparisDetay> GetSiparisDetayBilgileriById(int id);
        Task<SiparisDetay> CreateSiparisDetayBilgileri(SiparisDetay siparisDetayBilgileri);
        Task<SiparisDetay> UpdateSiparisDetayBilgileri(SiparisDetay siparisDetayBilgileri);
        Task DeleteSiparisDetayBilgileri(int id);

        Task<List<Tedarikci>> GetAllTedarikciBilgileri();
        Task<Tedarikci> GetTedarikciBilgileriById(int id);
        Task<Tedarikci> CreateTedarikciBilgileri(Tedarikci tedarikciBilgileri);
        Task<Tedarikci> UpdateTedarikciBilgileri(Tedarikci tedarikciBilgileri);
        Task DeleteTedarikciBilgileri(int id);

        Task<List<Urun>> GetAllUrunBilgileri();
        Task<Urun> GetUrunBilgileriById(int id);
        Task<Urun> CreateUrunBilgileri(Urun urunBilgileri);
        Task<Urun> UpdateUrunBilgileri(Urun urunBilgileri);
        Task DeleteUrunBilgileri(int id);

        Task<List<Kullanici>> GetAllKullaniciBilgileri();
        Task<Kullanici> GetKullaniciBilgileriById(int id);
        Task<Kullanici> CreateKullaniciBilgileri(Kullanici kullaniciBilgileri);
        Task<Kullanici> UpdateKullaniciBilgileri(Kullanici kullaniciBilgileri);
        Task DeleteKullaniciBilgileri(int id);


        Task<List<Kullanici>> GetAllPersonelBilgileri();
        Task<List<Kullanici>> GetAllMusteriBilgileri();

        Task<List<GelirGider>> GetAllGelirGiderBilgileri();
        Task<GelirGider> GetGelirGiderBilgileriById(int id);
        Task<GelirGider> CreateGelirGiderBilgileri(GelirGider gelirGider);
        Task<GelirGider> UpdateGelirGiderBilgileri(GelirGider gelirGider);
        Task DeleteGelirGiderBilgileri(int id);
    }
}
