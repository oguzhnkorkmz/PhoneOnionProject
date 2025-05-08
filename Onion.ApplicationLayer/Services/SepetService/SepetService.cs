using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Onion.ApplicationLayer.Models.DTO_s.Sepet;
using Onion.ApplicationLayer.Models.VievModels.Sepet;
using Onion.CoreLayer.Models;
using Onion.CoreLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.SepetService
{
    public class SepetService : ISepetService
    {

        private readonly ISepetRepository _sepetRepository;
        private readonly IMapper _mapper;

        public SepetService(ISepetRepository sepetRepository, IMapper mapper)
        {
            _sepetRepository = sepetRepository;
            _mapper = mapper;
        }

        public async Task SepeteEkleAsync(SepeteEkle_DTO telefon)
        {
            var result = await _sepetRepository.HerSekildeFiltreleAsync<Sepet>(x => x, x => x.TelefonID == telefon.TelefonID && x.UyeID == telefon.UyeID);

            Sepet yeniSepet = new Sepet();
            if(result.Count() > 0)
            {
                //update
                Sepet sepet = result.SingleOrDefault();
                sepet.Adet += 1;
                _sepetRepository.GuncelleAsync(sepet);
            }
            else
            {
                //insert
                _mapper.Map(telefon, yeniSepet);
                await _sepetRepository.EkleAsync(yeniSepet);
            }

               
        }

        public async Task<List<SepetDetay_VM>> SepettekiTumUrunlerAsync(int uyeID)
        {
            var result = await _sepetRepository.HerSekildeFiltreleAsync(select: x => new SepetDetay_VM
            {
                SepetID = x.SepetID,
                TelefonID = x.TelefonID,
                UyeID = x.UyeID,
                MarkaAdi = x.Telefon.Marka.MarkaAdi,
                ModelAdi = x.Telefon.Model.ModelAdi,
                Adet = x.Adet,
                Fiyat = x.Telefon.Fiyat,
                Resim = x.Telefon.Resim
            },
            where: x => x.UyeID == uyeID,
            include: x => x.Include(x => x.Telefon).ThenInclude(x => x.Model).ThenInclude(x => x.Marka)
            );
            return  result.ToList();
        }

        public async Task SepettenKaliciSilAsync(int sepetID)
        {
           await _sepetRepository.SepettenKaliciSilAsync(sepetID);
        }
    }
}
