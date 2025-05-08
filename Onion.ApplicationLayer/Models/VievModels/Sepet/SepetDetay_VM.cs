using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Models.VievModels.Sepet
{
    public class SepetDetay_VM
    {
        public int SepetID { get; set; }
        public int TelefonID { get; set; }
        public int UyeID { get; set; }
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Adet { get; set; }

        public string Resim { get; set; }
        public decimal ToplamFiyat { get => Fiyat * Adet; }
    }
}
