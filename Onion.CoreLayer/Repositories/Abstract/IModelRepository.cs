using Onion.CoreLayer.Abstracts;
using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.CoreLayer.Repositories.Abstract
{
    public interface IModelRepository:IBaseRepository<Model>
    {
        public Task<List<Model>> ListeleMarkaIDyeGoreAsync(int? id);
    }
}
