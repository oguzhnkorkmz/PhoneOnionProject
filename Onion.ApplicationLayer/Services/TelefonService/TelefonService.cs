using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Onion.ApplicationLayer.Models.DTO_s.Telefon;
using Onion.ApplicationLayer.Models.VievModels.Telefon;
using Onion.ApplicationLayer.Services.IsletimSistemiService;
using Onion.ApplicationLayer.Services.MarkaService;
using Onion.ApplicationLayer.Services.ModelService;
using Onion.CoreLayer.Models;
using Onion.CoreLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.TelefonService
{
    public class TelefonService : ITelefonService
    {

        private readonly ITelefonRepository _telefonRepository;
        private readonly IMapper _mapper;

        public TelefonService(ITelefonRepository telefonRepository, IMapper mapper)
        {
            _telefonRepository = telefonRepository;
            _mapper = mapper;
        }

        public async Task<TelefonDetay_VM> TelefonDetayAsync(int id)
        {
            var telefonDetay = await _telefonRepository.HerSekildeFiltreleAsync(
              select: x => new TelefonDetay_VM
              {
                  TelefonID = x.TelefonID,
                  MarkaAdi = x.Marka.MarkaAdi,
                  ModelAdi = x.Model.ModelAdi,
                  Fiyat = x.Fiyat,
                  Aciklama = x.Aciklama,
                  CiftSim = x.CiftSim,
                  IsletimSistemiAdi = x.IsletimSistemi.IsletimSistemiAdi,
                  Resim = x.Resim,
                  Stok = x.Stok
              },
              where: x => x.KayitDurumu != CoreLayer.Enums.KayitDurumu.KayitSil && x.TelefonID == id,
              include: x => x.Include(x => x.Marka).Include(x => x.Model).Include(x => x.IsletimSistemi));

            return telefonDetay.FirstOrDefault();
        }


        public async Task<int> TelefonEkleAsync(TelefonEkle_DTO telefon)
        {
            Telefon yeniTelefon = new Telefon();
            _mapper.Map(telefon, yeniTelefon);
            return await _telefonRepository.EkleAsync(yeniTelefon);
        }

        public async Task TelefonSilAsync(int id)
        {
           await _telefonRepository.SilAsync(id);
        }

        public async Task<List<Telefon_VM>> TumTelefonlarAsync()
        {
           var telefonlar =await  _telefonRepository.HerSekildeFiltreleAsync(x => new Telefon_VM { 
               TelefonID = x.TelefonID,
               MarkaAdi = x.Marka.MarkaAdi,
               ModelAdi = x.Model.ModelAdi,
               Resim = x.Resim,
               Fiyat = x.Fiyat
           },
               x => x.KayitDurumu != CoreLayer.Enums.KayitDurumu.KayitSil,
               null,
               x => x.Include(x => x.Marka).Include(x => x.Model));

            return telefonlar.ToList();
        }

       
    }
}
