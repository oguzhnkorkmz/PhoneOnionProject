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
    public class SepetRepository : BaseRepository<Sepet>, ISepetRepository
    {
        public async  Task SepettenKaliciSilAsync(int sepetID)
        {
             _table.Remove(await AraAsync(sepetID));
            await _dbContext.SaveChangesAsync();
        }
    }
}
