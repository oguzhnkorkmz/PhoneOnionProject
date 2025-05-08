using AutoMapper;
using Onion.ApplicationLayer.Models.DTO_s.IsletimSistemi;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.CoreLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.IsletimSistemiService
{
    public interface IIsletimSistemiService
    {
        Task<List<IsletimSistemi_DTO>> TumIsletimSistemleriAsync();

       
    }
}
