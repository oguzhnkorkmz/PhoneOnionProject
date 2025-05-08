using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Models.DTO_s.Telefon
{
    public  class TelefonEkle_DTO
    {
        public int MarkaID { get; set; }
        public int? ModelID { get; set; }
        public int IsletimSistemiID { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public bool CiftSim { get; set; }
        public short Stok { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
    }
}
