using Onion.ApplicationLayer.Models.DTO_s.IsletimSistemi;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.ApplicationLayer.Models.DTO_s.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Models.DTO_s.Telefon
{
    public class TelefonEklemeFormu_DTO
    {
        public TelefonEkle_DTO Telefon { get; set; }

        public List<Marka_DTO> Markalar { get; set; }
        public List<Model_DTO> Modeller { get; set; }
        public List<IsletimSistemi_DTO> IsletimSistemleri { get; set; }
    }
}
