using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiparisStokTakip.Entities
{
   public class GelirGider
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Malzeme { get; set; }
        public int VerilenTL { get; set; }
        public int VerilenUSD { get; set; }
        public int AlınanTL { get; set; }
        public int AlınanUSD { get; set; }
        public int USDAlirkenVergi { get; set; }
    }
}
