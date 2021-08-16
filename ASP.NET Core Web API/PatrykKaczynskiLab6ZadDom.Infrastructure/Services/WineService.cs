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
    public class WineService : IWineService
    {
        private readonly IWineRepository _wineRepository;
        private readonly IMapper _mapper;

        public WineService(IWineRepository wineRepository, IMapper mapper)
        {
            _wineRepository = wineRepository;
            _mapper = mapper;
        }

        public WineDto Get(Guid Id)
        {
            var wine = _wineRepository.Get(Id);

            return _mapper.Map<WineDto>(wine);
        }

        public List<WineDto> GetAll()
        {
            var wines = _wineRepository.GetAll();

            return _mapper.Map<List<WineDto>>(wines);
        }

        public WineDto Post(Guid Id, string name, string producerName, int productionYear, string countryName, string color, string taste, float alcoholContent)
        {
            var wine = new Wine(Id, name, producerName, productionYear, countryName, color, taste, alcoholContent);
            _wineRepository.Post(wine);
            return _mapper.Map<WineDto>(wine);
        }

        public void Put(Guid Id, string name, string producerName, int productionYear, string countryName, string color, string taste, float alcoholContent)
        {
            var wine = _wineRepository.Get(Id);
            wine.SetName(name);
            wine.SetProducerName(producerName);
            wine.SetProductionYear(productionYear);
            wine.SetCountryName(countryName);
            wine.SetColor(color);
            wine.SetTaste(taste);
            wine.SetAlcoholContent(alcoholContent);

            _wineRepository.Post(wine);
        }

        public void Delete(Guid Id)
        {
            var wine = _wineRepository.Get(Id);
            _wineRepository.Delete(wine);
        }
    }
}
