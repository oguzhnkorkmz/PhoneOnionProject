using Onion.ApplicationLayer.Models.DTO_s.Sepet;
using Onion.ApplicationLayer.Models.VievModels.Sepet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.SepetService
{
    public interface ISepetService
    {
        Task SepeteEkleAsync(SepeteEkle_DTO telefon);

        Task<List<SepetDetay_VM>> SepettekiTumUrunlerAsync(int uyeID);

        Task SepettenKaliciSilAsync(int sepetID);
    }
}
