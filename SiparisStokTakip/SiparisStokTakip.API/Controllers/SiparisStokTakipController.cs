using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SiparisStokTakip.Business.Abstract;
using SiparisStokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisStokTakip.API.Controllers
{
    //[EnableCors("*", "*", "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisStokTakipController : Controller
    {
        private ISiparisStokTakipService _siparisStokTakipService;
        public SiparisStokTakipController(ISiparisStokTakipService siparisStokTakipService)
        {
            _siparisStokTakipService = siparisStokTakipService;
        }

        /*SİPARİŞ*/

        /// <summary>
        /// Bütün Sipariş Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllSiparisBilgileri()
        {
            var siparis = await _siparisStokTakipService.GetAllSiparisBilgileri();
            return Ok(siparis);
        }

        /// <summary>
        /// ID ye Göre Sipariş Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetSiparisBilgileriById(int id)
        {
            var siparis = await _siparisStokTakipService.GetSiparisBilgileriById(id);
            if (siparis != null)
            {
                return Ok(siparis);
            }
            return NotFound();
        }

        /// <summary>
        /// Sipariş Ekler
        /// </summary>
        /// <param name="siparis"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateSiparisBilgileri([FromBody] Siparis siparis)
        {
            var createdSiparis = await _siparisStokTakipService.CreateSiparisBilgileri(siparis);
            return CreatedAtAction("Get", new { id = createdSiparis.ID }, createdSiparis);
        }

        /// <summary>
        /// Sipariş bilgilerini günceller
        /// </summary>
        /// <param name="siparis"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateSiparisBilgileri([FromBody] Siparis siparis)
        {
            if (await _siparisStokTakipService.GetSiparisBilgileriById(siparis.ID) != null)
            {
                return Ok(await _siparisStokTakipService.UpdateSiparisBilgileri(siparis));
            }
            return NotFound();
        }

        /// <summary>
        /// Sipariş Siler
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteSiparisBilgileri(int id)
        {
            if (await _siparisStokTakipService.GetSiparisBilgileriById(id) != null)
            {
                await _siparisStokTakipService.DeleteSiparisBilgileri(id);
                return Ok();
            }
            return NotFound();
        }

        /*SİPARİŞ DETAY*/

        /// <summary>
        /// Bütün Sipariş Detay Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllSiparisDetayBilgileri()
        {
            var siparisDetay = await _siparisStokTakipService.GetAllSiparisDetayBilgileri();
            return Ok(siparisDetay);
        }

        /// <summary>
        /// ID ye Göre Sipariş Detay Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetSiparisDetayBilgileriById(int id)
        {
            var siparisDetay = await _siparisStokTakipService.GetSiparisDetayBilgileriById(id);
            if (siparisDetay != null)
            {
                return Ok(siparisDetay);
            }
            return NotFound();
        }

        /// <summary>
        /// Sipariş Detay Ekler
        /// </summary>
        /// <param name="siparisDetay"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateSiparisDetayBilgileri([FromBody] SiparisDetay siparisDetay)
        {
            var createdSiparisDetay = await _siparisStokTakipService.CreateSiparisDetayBilgileri(siparisDetay);
            return CreatedAtAction("Get", new { id = createdSiparisDetay.ID }, createdSiparisDetay);
        }

        /// <summary>
        /// Sipariş Detay bilgilerini günceller
        /// </summary>
        /// <param name="siparisDetay"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateSiparisDetayBilgileri([FromBody] SiparisDetay siparisDetay)
        {
            if (await _siparisStokTakipService.GetSiparisDetayBilgileriById(siparisDetay.ID) != null)
            {
                return Ok(await _siparisStokTakipService.UpdateSiparisDetayBilgileri(siparisDetay));
            }
            return NotFound();
        }

        /// <summary>
        /// Sipariş Detay Siler
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteSiparisDetayBilgileri(int id)
        {
            if (await _siparisStokTakipService.GetSiparisDetayBilgileriById(id) != null)
            {
                await _siparisStokTakipService.DeleteSiparisDetayBilgileri(id);
                return Ok();
            }
            return NotFound();
        }

        /*TEDARİKÇİ*/

        /// <summary>
        /// Bütün Tedarikçi Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllTedarikciBilgileri()
        {
            var tedarikci = await _siparisStokTakipService.GetAllTedarikciBilgileri();
            return Ok(tedarikci);
        }

        /// <summary>
        /// ID ye Göre Tedarikci Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetTedarikciBilgileriById(int id)
        {
            var tedarikci = await _siparisStokTakipService.GetTedarikciBilgileriById(id);
            if (tedarikci != null)
            {
                return Ok(tedarikci);
            }
            return NotFound();
        }

        /// <summary>
        /// Tedarikci Ekler
        /// </summary>
        /// <param name="tedarikci"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateTedarikciBilgileri([FromBody] Tedarikci tedarikci)
        {
            var createdTedarikci = await _siparisStokTakipService.CreateTedarikciBilgileri(tedarikci);
            return CreatedAtAction("Get", new { id = createdTedarikci.ID }, createdTedarikci);
        }

        /// <summary>
        /// Tedarikci bilgilerini günceller
        /// </summary>
        /// <param name="tedarikci"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateTedarikciBilgileri([FromBody] Tedarikci tedarikci)
        {
            if (await _siparisStokTakipService.GetTedarikciBilgileriById(tedarikci.ID) != null)
            {
                return Ok(await _siparisStokTakipService.UpdateTedarikciBilgileri(tedarikci));
            }
            return NotFound();
        }

        /// <summary>
        /// Tedarikci Siler
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteTedarikciBilgileri(int id)
        {
            if (await _siparisStokTakipService.GetTedarikciBilgileriById(id) != null)
            {
                await _siparisStokTakipService.DeleteTedarikciBilgileri(id);
                return Ok();
            }
            return NotFound();
        }

        /*URUN*/

        /// <summary>
        /// Bütün Ürün Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllUrunBilgileri()
        {
            var urun = await _siparisStokTakipService.GetAllUrunBilgileri();
            return Ok(urun);
        }

        /// <summary>
        /// ID ye Göre Ürün Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetUrunBilgileriById(int id)
        {
            var urun = await _siparisStokTakipService.GetUrunBilgileriById(id);
            if (urun != null)
            {
                return Ok(urun);
            }
            return NotFound();
        }

        /// <summary>
        /// Urun Ekler
        /// </summary>
        /// <param name="urun"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUrunBilgileri([FromBody] Urun urun)
        {
            var createdUrun = await _siparisStokTakipService.CreateUrunBilgileri(urun);
            return CreatedAtAction("Get", new { id = createdUrun.UrunID }, createdUrun);
        }

        /// <summary>
        /// Urun bilgilerini günceller
        /// </summary>
        /// <param name="urun"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUrunBilgileri([FromBody] Urun urun)
        {
            if (await _siparisStokTakipService.GetUrunBilgileriById(urun.UrunID) != null)
            {
                return Ok(await _siparisStokTakipService.UpdateUrunBilgileri(urun));
            }
            return NotFound();
        }

        /// <summary>
        /// Urun Siler
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteUrunBilgileri(int id)
        {
            if (await _siparisStokTakipService.GetUrunBilgileriById(id) != null)
            {
                await _siparisStokTakipService.DeleteUrunBilgileri(id);
                return Ok();
            }
            return NotFound();
        }

        /*KULLANICI*/

        /// <summary>
        /// Bütün Kullanici Getirir
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllKullaniciBilgileri()
        {
            var kullanici = await _siparisStokTakipService.GetAllKullaniciBilgileri();
            return Ok(kullanici);
        }

        /// <summary>
        /// ID ye Göre Kullanici Getirir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetKullaniciBilgileriById(int id)
        {
            var kullanici = await _siparisStokTakipService.GetKullaniciBilgileriById(id);
            if (kullanici != null)
            {
                return Ok(kullanici);
            }
            return NotFound();
        }

        /// <summary>
        /// Kullanici Ekler
        /// </summary>
        /// <param name="kullanici"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateKullaniciBilgileri([FromBody] Kullanici kullanici)
        {
            var createdKullanici = await _siparisStokTakipService.CreateKullaniciBilgileri(kullanici);
            return CreatedAtAction("Get", new { id = createdKullanici.ID }, createdKullanici);
        }

        /// <summary>
        /// Kullanici bilgilerini günceller
        /// </summary>
        /// <param name="kullanici"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateKullaniciBilgileri([FromBody] Kullanici kullanici)
        {
            if (await _siparisStokTakipService.GetKullaniciBilgileriById(kullanici.ID) != null)
            {
                return Ok(await _siparisStokTakipService.UpdateKullaniciBilgileri(kullanici));
            }
            return NotFound();
        }

        /// <summary>
        /// Kullanici Siler
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteKullaniciBilgileri(int id)
        {
            if (await _siparisStokTakipService.GetKullaniciBilgileriById(id) != null)
            {
                await _siparisStokTakipService.DeleteKullaniciBilgileri(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
