using Onion.CoreLayer.Enums;
using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Models.VievModels.Telefon
{
    public class Telefon_VM
    {
        public int TelefonID { get; set; }
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
     
    }
}
