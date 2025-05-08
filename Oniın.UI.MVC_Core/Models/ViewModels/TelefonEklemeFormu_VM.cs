using Microsoft.AspNetCore.Mvc.Rendering;
using Onion.ApplicationLayer.Models.DTO_s.IsletimSistemi;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.ApplicationLayer.Models.DTO_s.Model;
using Onion.ApplicationLayer.Models.DTO_s.Telefon;

namespace Onion.UI.MVC_Core.Models.ViewModels
{
    public class TelefonEklemeFormu_VM
    {
        public EkleTelefon_VM Telefon { get; set; }

        public SelectList Markalar { get; set; }
        public SelectList Modeller { get; set; }
        public SelectList IsletimSistemleri { get; set; }
    }
}
