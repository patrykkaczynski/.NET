using PatrykKaczynskiLab6ZadDom.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Core.Repositories
{
    public interface IWineRepository
    {
        Wine Get(Guid Id);
        List<Wine> GetAll();
        Wine Post(Wine wine);
        void Put(Wine wine);
        void Delete(Wine wine);
    }
}
