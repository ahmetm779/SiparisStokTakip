using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SiparisStokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SiparisStokTakip.Web.Controllers
{
    [Authorize]
    public class GelirGiderController : Controller
    {
        string location = "http://localhost:28372/api/SiparisStokTakip/";

        public async Task<IActionResult> GelirGiderListele()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetAllGelirGiderBilgileri");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<GelirGider>>(jsonString);
            return View(values);
        }

        [HttpGet]
        public IActionResult GelirGiderEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GelirGiderEkle(GelirGider gelirGider)
        {
            gelirGider.Tarih = DateTime.Now;
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(gelirGider);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync(location + "CreateGelirGiderBilgileri", content);
            return RedirectToAction("GelirGiderListele");
        }

        [HttpGet]
        public async Task<IActionResult> GelirGiderGuncelle(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(location + "GetGelirGiderBilgileriById/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonString = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GelirGider>(jsonString);
                return View(values);
            }
            return RedirectToAction("GelirGiderListele");
        }
        [HttpPost]
        public async Task<IActionResult> GelirGiderGuncelle(GelirGider gelirGider)
        {
            var httpClient = new HttpClient();
            var jsonString = JsonConvert.SerializeObject(gelirGider);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync(location + "UpdateGelirGiderBilgileri", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("GelirGiderListele");
            }
            return View(gelirGider);
        }
        public async Task<IActionResult> GelirGiderSil(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync(location + "DeleteGelirGiderBilgileri/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("GelirGiderListele");
            }
            return View();
        }
    }
}
