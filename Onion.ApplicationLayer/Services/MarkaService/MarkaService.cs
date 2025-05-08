using AutoMapper;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.CoreLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.MarkaService
{
    public class MarkaService : IMarkaService
    {

        private readonly IMarkaRepository _markaRepository;
        private readonly IMapper _mapper;

        public MarkaService(IMarkaRepository markaRepository,IMapper mapper)
        {
            _markaRepository = markaRepository;
            _mapper = mapper;
        }
        public async Task<List<Marka_DTO>> TumMarkalarAsync()
        {
            List<Marka_DTO> markalar = new List<Marka_DTO>();
            var gelenMarkalar = await _markaRepository.ListeleAsync();
            _mapper.Map(gelenMarkalar, markalar);
            return markalar;
        }
    }
}
