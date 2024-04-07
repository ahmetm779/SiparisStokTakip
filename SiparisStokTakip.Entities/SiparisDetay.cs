using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiparisStokTakip.Entities
{
    public class SiparisDetay
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int SiparisID { get; set; }
        public int UrunID { get; set; }
        //public int MusteriID { get; set; }
        public int Adet { get; set; }
        public int BirimFiyat { get; set; }
        public int İndirimOrani { get; set; }
    }
}
