using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiparisStokTakip.Entities
{
    public class Urun
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UrunID { get; set; }
        [Required]
        public string Ad { get; set; }
        public int BirimFiyati { get; set; }
        //public int SatisFiyati { get; set; } //Eklenecek
        public int StokMiktari { get; set; }
        public int MinimumMiktari { get; set; }
        public int TedarikciID { get; set; }
    }
}
