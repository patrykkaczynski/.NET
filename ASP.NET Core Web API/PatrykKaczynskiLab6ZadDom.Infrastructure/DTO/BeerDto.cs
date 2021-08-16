using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Infrastructure.DTO
{
    public class BeerDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProducerName { get; set; }
        public string Style { get; set; }
        public float ExtractContent { get; set; }
        public float AlcoholContent { get; set; }
        public int BitternessContent { get; set; }
    }
}
