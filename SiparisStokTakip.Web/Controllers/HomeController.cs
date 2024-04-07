using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SiparisStokTakip.DataAccess;
using SiparisStokTakip.Entities;
using SiparisStokTakip.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SiparisStokTakip.Web.Controllers
{
    // [Authorize(Roles = "Yönetici")]
    [Authorize]
    public class HomeController : Controller
    {
        private SiparisStokTakipDbContext _sipasStokTakipDbContext = new SiparisStokTakipDbContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        string location = "http://localhost:28372/api/SiparisStokTakip/";
        /*Urünler*/
        public async Task<IActionResult> Urunler()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetAllUrunBilgileri");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Urun>>(jsonString);
            return View(values);
        }

        [Authorize(Roles = "Yönetici")]
        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UrunEkle(Entities.Urun urun)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(urun);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateUrunBilgileri", content);

            return RedirectToAction("Urunler");
        }

        [HttpGet]
        public async Task<IActionResult> UrunGuncelle(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetUrunBilgileriById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Entities.Urun>(jsonString);
                return View(values);
            }
            return RedirectToAction("Urunler");

        }

        [HttpPost]
        public async Task<IActionResult> UrunGuncelle(Urun urun)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(urun);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync(location + "UpdateUrunBilgileri", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Urunler");
            }
            return View(urun);
        }

        public async Task<IActionResult> UrunSil(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(location + "DeleteUrunBilgileri/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Urunler");
            }
            return View();
        }

        /*Siparisler*/
        //public async Task<IActionResult> Siparisler()
        //{

        //    SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
        //    var musteri = dbContext.Kullanicilar.FirstOrDefault(kul => kul.Eposta == User.Identity.Name);
        //    int musteriId = musteri.ID;
        //    string kullaniciAdi = musteri.Eposta;


        //    //var httpClient = new HttpClient();
        //    //var responseMessage = await httpClient.GetAsync(location + "GetAllSiparisBilgileri");
        //    //var jsonString = await responseMessage.Content.ReadAsStringAsync();
        //    //var values = JsonConvert.DeserializeObject<List<Siparis>>(jsonString);
        //    //return View(values);



        //}


        public async Task<IActionResult> Siparislerim()
        {

            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var musteri = dbContext.Kullanicilar.FirstOrDefault(kul => kul.Eposta == User.Identity.Name);
            int musteriId = musteri.ID;

            var siparislerim = dbContext.Siparisler.Where(kul => kul.MusteriID == musteriId).ToList();
            return View(siparislerim);
        }


        //[HttpGet]
        //public IActionResult SiparisEkle(int UrunID)
        //{
        //    return View();
        //}

        //[HttpPost]
        public async Task<IActionResult> SiparisEkle(Siparis siparis, int UrunID)
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var musteri = dbContext.Kullanicilar.FirstOrDefault(kul => kul.Eposta == User.Identity.Name);
            siparis.MusteriID = musteri.ID;

            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(siparis);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateSiparisBilgileri", content);
            return RedirectToAction("Siparislerim");
        }

        [HttpGet]
        public async Task<IActionResult> SiparisGuncelle(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetSiparisBilgileriById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Siparis>(jsonString);
                return View(values);
            }
            return RedirectToAction("Siparislerim");
        }

        [HttpPost]
        public async Task<IActionResult> SiparisGuncelle(Siparis siparis)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(siparis);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync(location + "UpdateSiparisBilgileri", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Siparislerim");
            }
            return View(siparis);
        }

        public async Task<IActionResult> SiparisSil(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(location + "DeleteSiparisBilgileri/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Siparislerim");
            }
            return View();
        }

        [Authorize]
        public async Task<IActionResult> YeniSiparisler()
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var siparisler = dbContext.Siparisler.Where(kul => kul.SiparisDurumu == "Sipariş Alındı").ToList();
            return View(siparisler);
        }
        [Authorize]
        public async Task<IActionResult> HazırlananSiparisler()
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var siparisler = dbContext.Siparisler.Where(kul => kul.SiparisDurumu == "Hazırlanıyor").ToList();
            return View(siparisler);
        }
        [Authorize]
        public async Task<IActionResult> SevkiyatSiparisler()
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var siparisler = dbContext.Siparisler.Where(kul => kul.SiparisDurumu == "Sevkiyatta").ToList();
            return View(siparisler);
        }
        [Authorize]
        public async Task<IActionResult> TamamlananSiparisler()
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var siparisler = dbContext.Siparisler.Where(kul => kul.SiparisDurumu == "Tamamlandı").ToList();
            return View(siparisler);
        }

        /*Siparis Detay*/
        public async Task<IActionResult> SiparisDetay(int id)
        {
            //var httpClient = new HttpClient();
            //var responseMessage = await httpClient.GetAsync(location + "GetSiparisDetayBilgileriById/" + id);
            //var jsonString = await responseMessage.Content.ReadAsStringAsync();
            //var values = JsonConvert.DeserializeObject<List<SiparisDetay>>(jsonString);
            //return View(values);
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var siparisDetaylari = dbContext.SiparisDetaylari.Where(sip => sip.SiparisID == id).ToList();
            return View(siparisDetaylari);
        }

        [HttpGet]
        public IActionResult SiparisDetayEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDetayEkle(SiparisDetay siparisDetay)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(siparisDetay);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateSiparisDetayBilgileri", content);
            return RedirectToAction("SiparisDetay");
        }

        [HttpGet]
        public async Task<IActionResult> SiparisDetayGuncelle(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetSiparisDetayBilgileriById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Entities.SiparisDetay>(jsonString);
                return View(values);
            }
            return RedirectToAction("SiparisDetay");
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDetayGuncelle(Entities.SiparisDetay siparisDetay)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(siparisDetay);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync(location + "UpdateSiparisDetayBilgileri", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SiparisDetay");
            }
            return View(siparisDetay);
        }

        public async Task<IActionResult> SiparisDetaySil(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(location + "DeleteSiparisDetayBilgileri/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SiparisDetay");
            }
            return View();
        }

        /*Tedarikçiler*/
        public async Task<IActionResult> Tedarikciler()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetAllTedarikciBilgileri");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Entities.Tedarikci>>(jsonString);
            return View(values);
        }

        [HttpGet]
        public IActionResult TedarikciEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TedarikciEkle(Entities.Tedarikci tedarikci)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(tedarikci);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateTedarikciBilgileri", content);
            return RedirectToAction("Tedarikciler");
        }

        [HttpGet]
        public async Task<IActionResult> TedarikciGuncelle(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetTedarikciBilgileriById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Entities.Tedarikci>(jsonString);
                return View(values);
            }
            return RedirectToAction("Tedarikciler");
        }

        [HttpPost]
        public async Task<IActionResult> TedarikciGuncelle(Entities.Tedarikci tedarikci)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(tedarikci);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync(location + "UpdateTedarikciBilgileri", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Tedarikciler");
            }
            return View(tedarikci);
        }

        public async Task<IActionResult> TedarikciSil(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(location + "DeleteTedarikciBilgileri/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Tedarikciler");
            }
            return View();
        }


        [Authorize]
        public async Task<IActionResult> PersonelListele()
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var kullanicilar = dbContext.Kullanicilar.Where(kul => kul.Rol != "Müşteri").ToList();
            return View(kullanicilar);
        }


        [Authorize]
        public async Task<IActionResult> MusteriListele()
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var musteriler = dbContext.Kullanicilar.Where(kul => kul.Rol == "Müşteri").ToList();
            return View(musteriler);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
