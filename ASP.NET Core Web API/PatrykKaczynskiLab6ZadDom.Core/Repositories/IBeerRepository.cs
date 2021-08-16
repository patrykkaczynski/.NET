using PatrykKaczynskiLab6ZadDom.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Core.Repositories
{
    public interface IBeerRepository
    {
        Beer Get(Guid Id);
        List<Beer> GetAll();
        Beer Post(Beer beer);
        void Put(Beer beer);
        void Delete(Beer beer);
    }
}
