using PatrykKaczynskiLab6ZadDom.Core.Models;
using PatrykKaczynskiLab6ZadDom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.Services
{
    public interface IWineService
    {

        /// <summary>
        /// Zwraca wino o podanym id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        WineDto Get(Guid Id);

        /// <summary>
        /// Zwraca wszystkie wina
        /// </summary>
        /// <returns></returns>
        List<WineDto> GetAll();

        /// <summary>
        /// Dodaje nowe wino
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="producerName"></param>
        /// <param name="productionYear"></param>
        /// <param name="countryName"></param>
        /// <param name="color"></param>
        /// <param name="taste"></param>
        /// <param name="alcoholContent"></param>
        /// <returns></returns>
        WineDto Post(Guid Id, string name, string producerName, int productionYear, string countryName, string color, string taste, float alcoholContent);

        /// <summary>
        /// Edycja wskazanego wina
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="producerName"></param>
        /// <param name="productionYear"></param>
        /// <param name="countryName"></param>
        /// <param name="color"></param>
        /// <param name="taste"></param>
        /// <param name="alcoholContent"></param>
        void Put(Guid Id, string name,string producerName,int productionYear, string countryName, string color, string taste, float alcoholContent);

        /// <summary>
        /// Usuwa wskazane wino
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        void Delete(Guid Id);
    }
}
