using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiparisStokTakip.Entities
{
    public class Kullanici
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime KayitTarihi { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Eposta { get; set; }

        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public string Rol { get; set; }

        public bool Durum { get; set; }
    }
}
