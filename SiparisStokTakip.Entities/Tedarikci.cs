using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SiparisStokTakip.Entities
{
    public class Tedarikci
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Telefon { get; set; }
    }
}
