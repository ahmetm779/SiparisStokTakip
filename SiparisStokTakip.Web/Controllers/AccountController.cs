using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SiparisStokTakip.DataAccess;
using SiparisStokTakip.Entities;

namespace SiparisStokTakip.Web.Controllers
{
    public class AccountController : Controller
    {
        string location = "http://localhost:28372/api/SiparisStokTakip/";

        [Authorize]
        public async Task<IActionResult> HesaplariListele()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetAllKullaniciBilgileri");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Entities.Kullanici>>(jsonString);
            return View(values);
        }
        [Authorize]
        public async Task<IActionResult> HesapSil(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(location + "DeleteKullaniciBilgileri/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("HesaplariListele");
            }
            return View();
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> HesapGuncelle(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetKullaniciBilgileriById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Kullanici>(jsonString);
                return View(values);
            }
            return RedirectToAction("HesaplariListele");
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> HesapGuncelle(Kullanici kullanici)
        {
            var httpClient = new HttpClient();
            kullanici.Sifre = Crypto.Hash(kullanici.Sifre, "MD5");
            var jsonString = JsonConvert.SerializeObject(kullanici);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync(location + "UpdateKullaniciBilgileri", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("HesaplariListele");
            }
            return View(kullanici);
        }

        [HttpGet]
        public IActionResult HesapEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HesapEkle(Kullanici kullanici)
        {
            kullanici.KayitTarihi = DateTime.Now;
            var httpClient = new HttpClient();
            kullanici.Sifre = Crypto.Hash(kullanici.Sifre, "MD5");
            var jsonString = JsonConvert.SerializeObject(kullanici);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateKullaniciBilgileri", content);
            return RedirectToAction("HesaplariListele");
        }

        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KayitOl(Kullanici kullanici)
        {
            kullanici.KayitTarihi = DateTime.Now;
            var httpClient = new HttpClient();
            kullanici.Sifre = Crypto.Hash(kullanici.Sifre, "MD5");
            var jsonString = JsonConvert.SerializeObject(kullanici);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateKullaniciBilgileri", content);
            return RedirectToAction("GirisYap");
        }
        [HttpGet]
        public IActionResult SifremiUnuttum()
        {
            return View();
        }

        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Kullanici k, string ReturnUrl)
        {
            SiparisStokTakipDbContext dbContext = new SiparisStokTakipDbContext();
            var kullanici = dbContext.Kullanicilar.FirstOrDefault(kul => kul.KullaniciAdi == k.KullaniciAdi && kul.Sifre == Sifrele.MD5Olustur(k.Sifre));
            if (kullanici != null)
            {
                var talepler = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,kullanici.Eposta.ToString()),
                    new Claim(ClaimTypes.Role,kullanici.Rol.ToString())
                };
                ClaimsIdentity kimlik = new ClaimsIdentity(talepler, "Login");
                ClaimsPrincipal kural = new ClaimsPrincipal(kimlik);
                await HttpContext.SignInAsync(kural);
                if (!String.IsNullOrEmpty(ReturnUrl))
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Urunler", "Home");
                }
            }
            return View();
        }

        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("GirisYap", "Account");
        }
    }
}
