using PatrykKaczynskiLab6ZadDom.Core.Models;
using PatrykKaczynskiLab6ZadDom.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.Repositories
{
    public class BeerRepository: IBeerRepository
    {
        private static readonly List<Beer> beers = new List<Beer>()
        {
            new Beer()
            {
                Id = Guid.NewGuid(),
                Name = "Atak Chmielu",
                ProducerName = "Browar Pinta",
                Style = "American India Pale Ale",
                ExtractContent = 15.0f,
                AlcoholContent = 6.1f,
                BitternessContent = 58
            },
            new Beer()
            {
                Id = Guid.NewGuid(),
                Name = "WRCLW Imperial Stout",
                ProducerName = "Browar Stu Mostów",
                Style = "American India Pale Ale",
                ExtractContent = 30.0f,
                AlcoholContent = 11.0f,
                BitternessContent = 62
            }
        };

        public Beer Get(Guid Id)
        {
            return beers.SingleOrDefault(x => x.Id == Id);
        }

        public List<Beer> GetAll()
        {
            return beers;
        }

        public Beer Post(Beer beer)
        {
            beers.Add(beer);
            return beer;
        }

        public void Put(Beer beer)
        {

        }

        public void Delete(Beer beer)
        {
            beers.Remove(beer);
        }
    }
}

