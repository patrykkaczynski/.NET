using PatrykKaczynskiLab6ZadDom.Core.Models;
using PatrykKaczynskiLab6ZadDom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.Services
{
    public interface IBeerService
    {
        /// <summary>
        /// Zwraca piwo o podanym id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        BeerDto Get(Guid Id);

        /// <summary>
        /// Zwraca wszystkie piwa
        /// </summary>
        /// <returns></returns>
        List<BeerDto> GetAll();

        /// <summary>
        /// Dodaje nowe piwo
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="producerName"></param>
        /// <param name="style"></param>
        /// <param name="extractContent"></param>
        /// <param name="alcoholContent"></param>
        /// <param name="bitternessContent"></param>
        /// <returns></returns>
        BeerDto Post(Guid Id, string name, string producerName, string style, float extractContent, float alcoholContent, int bitternessContent);

        /// <summary>
        /// Edycja wskazanego piwa
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="producerName"></param>
        /// <param name="style"></param>
        /// <param name="extractContent"></param>
        /// <param name="alcoholContent"></param>
        /// <param name="bitternessContent"></param>
        void Put(Guid Id, string name, string producerName, string style, float extractContent, float alcoholContent, int bitternessContent);

        /// <summary>
        /// Usuwa wskazane piwo
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        void Delete(Guid Id);
    }
}
