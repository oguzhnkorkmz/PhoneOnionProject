using Onion.CoreLayer.Abstracts;
using Onion.CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.CoreLayer.Models
{
    public class Telefon : IEntity
    {
        public int TelefonID { get; set; }
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

        public KayitDurumu KayitDurumu { get; set; }

        public Marka? Marka { get; set; }
        public IsletimSistemi? IsletimSistemi { get; set; }

        public Model? Model { get; set; }

        public ICollection<Sepet>? SepetdekiTelefonlar { get; set; }
    }
}
