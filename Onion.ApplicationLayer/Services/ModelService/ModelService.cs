using AutoMapper;
using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.ApplicationLayer.Models.DTO_s.Model;
using Onion.CoreLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.ModelService
{
    public class ModelService:IModelService
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public ModelService(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public async Task<List<Model_DTO>> TumModellerAsync(int? id )
        {
            List<Model_DTO> modeller = new List<Model_DTO>();

            var gelenModeller = await _modelRepository.ListeleMarkaIDyeGoreAsync(id);

            _mapper.Map(gelenModeller, modeller);

            return modeller;
        }

       
    }
}
