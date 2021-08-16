using AutoMapper;
using PatrykKaczynskiLab6ZadDom.Core.Models;
using PatrykKaczynskiLab6ZadDom.Core.Repositories;
using PatrykKaczynskiLab6ZadDom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.Services
{
    public class BeerService : IBeerService
    {
        private readonly IBeerRepository _beerRepository;
        private readonly IMapper _mapper;
        public BeerService(IBeerRepository beerRepository, IMapper mapper)
        {
            _beerRepository = beerRepository;
            _mapper = mapper;
        }

        public BeerDto Get(Guid Id)
        {
            var beer = _beerRepository.Get(Id);

            return _mapper.Map<BeerDto>(beer);
        }

        public List<BeerDto> GetAll()
        {
            var beers = _beerRepository.GetAll();

            return _mapper.Map<List<BeerDto>>(beers);
        }

        public BeerDto Post(Guid Id, string name, string producerName, string style, float extractContent, float alcoholContent, int bitternessContent)
        {
            var beer = new Beer(Id,  name,  producerName,  style,  extractContent,  alcoholContent,  bitternessContent);
            _beerRepository.Post(beer);
            return _mapper.Map<BeerDto>(beer);
        }

        public void Put(Guid Id, string name, string producerName, string style, float extractContent, float alcoholContent, int bitternessContent)
        {
            var beer = _beerRepository.Get(Id);
            beer.SetName(name);
            beer.SetProducerName(producerName);
            beer.SetStyle(style);
            beer.SetExtractContent(extractContent);
            beer.SetAlcoholContent(alcoholContent);
            beer.SetBitternessContent(bitternessContent);

            _beerRepository.Post(beer);
        }

        public void Delete(Guid Id)
        {
            var beer = _beerRepository.Get(Id);
            _beerRepository.Delete(beer);
        }
    }
}
