using Onion.ApplicationLayer.Models.DTO_s.Marka;
using Onion.ApplicationLayer.Models.DTO_s.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.ModelService
{
    public interface IModelService
    {
        Task<List<Model_DTO>> TumModellerAsync(int? id);
    }
}
