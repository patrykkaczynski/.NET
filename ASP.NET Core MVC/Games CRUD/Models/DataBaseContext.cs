using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Models
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Mode> Modes { get; set; }
    }
}
