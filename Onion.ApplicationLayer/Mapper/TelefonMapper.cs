using AutoMapper;
using Onion.ApplicationLayer.Models.DTO_s.IsletimSistemi;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.ApplicationLayer.Models.DTO_s.Model;
using Onion.ApplicationLayer.Models.DTO_s.Sepet;
using Onion.ApplicationLayer.Models.DTO_s.Telefon;
using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Mapper
{
    public class TelefonMapper:Profile
    {
        public TelefonMapper() //Aşağıdakia tanımlamalar olmazsa hata alırız
        {
            //Marka
            CreateMap<Marka, Marka_DTO>().ReverseMap(); // karşılıklı eşleştirme  yapıyoruz
            CreateMap<Model, Model_DTO>().ReverseMap(); 
            CreateMap<IsletimSistemi, IsletimSistemi_DTO>().ReverseMap(); 
            CreateMap<Telefon, TelefonEkle_DTO>().ReverseMap();
            CreateMap<Sepet, SepeteEkle_DTO>().ReverseMap();
        }
    }
}
