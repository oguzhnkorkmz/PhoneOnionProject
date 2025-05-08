using Onion.ApplicationLayer.Models.DTO_s.Marka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.ApplicationLayer.Services.MarkaService
{
    public interface IMarkaService
    {
        Task<List<Marka_DTO>> TumMarkalarAsync();
    }
}
