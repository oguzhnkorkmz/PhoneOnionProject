using Onion.CoreLayer.Abstracts;
using Onion.CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.CoreLayer.Models
{
    public class Sepet:IEntity
    {
        public int SepetID { get; set; }
        public int TelefonID { get; set; }
        public int UyeID { get; set; }
        public short Adet { get; set; }

        
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }

        public KayitDurumu KayitDurumu { get; set; }

        public Telefon? Telefon { get; set; }
        public Uye? Uye { get; set; }
    }
}
