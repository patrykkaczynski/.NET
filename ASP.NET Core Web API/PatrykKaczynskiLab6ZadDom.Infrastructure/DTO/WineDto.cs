using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.DTO
{
    public class WineDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProducerName { get; set; }
        public int ProductionYear { get; set; }
        public string CountryName { get; set; }
        public string Color { get; set; }
        public string Taste { get; set; }
        public float AlcoholContent { get; set; }
    }
}
