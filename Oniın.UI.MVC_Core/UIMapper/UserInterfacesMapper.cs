using AutoMapper;
using Onion.ApplicationLayer.Models.DTO_s.Telefon;
using Onion.UI.MVC_Core.Models.ViewModels;

namespace Onion.UI.MVC_Core.UIMapper
{
    public class UserInterfacesMapper:Profile
    {
        public UserInterfacesMapper()
        {
            CreateMap<EkleTelefon_VM,TelefonEkle_DTO>()
                .ForMember(x=>x.Resim,y =>y.MapFrom(x=>x.Resim.FileName))
                .ReverseMap();
        }
    }
}
