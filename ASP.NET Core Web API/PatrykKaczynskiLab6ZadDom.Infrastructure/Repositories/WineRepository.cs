using PatrykKaczynskiLab6ZadDom.Core.Models;
using PatrykKaczynskiLab6ZadDom.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.Repositories
{
    public class WineRepository: IWineRepository
    {
        private static readonly List<Wine> wines = new List<Wine>()
        {
            new Wine()
            {
                Id = Guid.NewGuid(),
                Name = "Carlo Rossi WHITE",
                ProducerName = "Carlo Rossi",
                ProductionYear = 2004,
                CountryName = "USA",
                Color = "Białe",
                Taste = "Półwytrawne",
                AlcoholContent = 10.5f
            },
            new Wine()
            {
                Id = Guid.NewGuid(),
                Name = "Fresco SEMI SWEET",
                ProducerName = "Fresco",
                ProductionYear = 2008,
                CountryName = "Polska",
                Color = "Czerwone",
                Taste = "Półsłodkie",
                AlcoholContent = 10.0f
            }
        };

        public Wine Get(Guid Id)
        {
            return wines.SingleOrDefault(x => x.Id == Id);
        }

        public List<Wine> GetAll()
        {
            return wines;
        }

        public Wine Post(Wine wine)
        {
            wines.Add(wine);
            return wine;
        }

        public void Put(Wine wine)
        {

        }

        public void Delete(Wine wine)
        {
            wines.Remove(wine);
        }
    }
}
