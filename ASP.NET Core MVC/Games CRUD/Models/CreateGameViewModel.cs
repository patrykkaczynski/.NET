using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Models
{
    public class CreateGameViewModel
    {
        public IEnumerable<Producer> Producers { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Mode> Modes { get; set; }
        public Game Game { get; set; }
    }
}
