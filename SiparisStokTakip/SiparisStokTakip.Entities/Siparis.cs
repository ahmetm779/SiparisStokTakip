using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiparisStokTakip.Entities
{
    public class Siparis
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public int UrunID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int ToplamTutar { get; set; }
        public string SiparisDurumu { get; set; }
    }
}
