using Microsoft.EntityFrameworkCore;
using Onion.CoreLayer.Models;
using Onion.CoreLayer.Repositories.Abstract;
using Onion.InfrastructureLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.InfrastructureLayer.Repositories.Concretes
{
    public class ModelRepository : BaseRepository<Model>, IModelRepository
    {
        public async Task<List<Model>> ListeleMarkaIDyeGoreAsync(int? id)
        {
            if (id == null)
                return await _table.ToListAsync();

            return await _table.Where(x => x.MarkaID == id).ToListAsync();
        }
    }
}
