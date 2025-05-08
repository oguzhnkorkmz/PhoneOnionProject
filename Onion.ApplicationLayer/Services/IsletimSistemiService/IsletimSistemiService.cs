using AutoMapper;
using Onion.ApplicationLayer.Models.DTO_s.IsletimSistemi;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.CoreLayer.Repositories.Abstract;
using Onion.InfrastructureLayer.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.IsletimSistemiService
{
    public class IsletimSistemiService : IIsletimSistemiService
    {
        private readonly IIsletimSistemiRepository _isletimSistemiRepository;
        private readonly IMapper _mapper;

        public IsletimSistemiService(IIsletimSistemiRepository isletimSistemiRepository, IMapper mapper)
        {
            _isletimSistemiRepository = isletimSistemiRepository;
            _mapper = mapper;
        }

        public async Task<List<IsletimSistemi_DTO>> TumIsletimSistemleriAsync()
        {
            List<IsletimSistemi_DTO> isletimSistemleri = new List<IsletimSistemi_DTO>();

            var gelenIsletimSistemleri = await _isletimSistemiRepository.ListeleAsync();

            _mapper.Map(gelenIsletimSistemleri, isletimSistemleri);

            return isletimSistemleri;
        }
    }
}
