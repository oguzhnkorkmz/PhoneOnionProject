using Onion.ApplicationLayer.Models.DTO_s.Telefon;
using Onion.ApplicationLayer.Models.VievModels.Telefon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.TelefonService
{
    public interface ITelefonService
    {
        Task<List<Telefon_VM>> TumTelefonlarAsync();
        Task<TelefonDetay_VM> TelefonDetayAsync(int id);

        Task<int> TelefonEkleAsync(TelefonEkle_DTO telefon);
        Task TelefonSilAsync(int id);

        //Task<TelefonEklemeFormu_DTO> YeniTelefonEklemeFormuVerileriAsync();

        //Diğer metodlar ihtiyaca göre yazılmalı
    }
}
