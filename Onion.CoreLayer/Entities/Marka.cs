using Onion.CoreLayer.Abstracts;
using Onion.CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.CoreLayer.Models
{
    public class Marka:IEntity
    {
        public int MarkaID { get; set; }
        public string MarkaAdi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }

        public KayitDurumu KayitDurumu { get; set; }

        ICollection<Telefon>? Telefonlar { get; set; }
        ICollection<Model>? Modeller { get; set; }
    }
}
