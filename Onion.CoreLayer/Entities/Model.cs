using Onion.CoreLayer.Abstracts;
using Onion.CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.CoreLayer.Models
{
    public class Model:IEntity
    {
        public int ModelID { get; set; }
        public string ModelAdi { get; set; }
        public int MarkaID { get; set; }

        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }

        public KayitDurumu KayitDurumu { get; set; }

        public Marka? Marka { get; set; }
        public ICollection<Telefon>? Telefonlar { get; set; }
    }
}
