using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.CoreLayer.Models
{
    public class Uye:IdentityUser<int>
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Adres { get; set; }

        public ICollection<Sepet>? SepetdekiTelefonlar { get; set; }
    }
}
