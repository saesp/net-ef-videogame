using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class VideogameContext : DbContext // DbContext serve a comunicare a .NET la configuarazione del db
    {
        public DbSet<Videogame> Videogames { get; set; } // DbSet<> serve a comunicare a .NET le classi da usare per il db
        public DbSet<SoftwareHouse> SoftwareHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-net-ef-videogame;Integrated Security=True"); //la stringa di connessione esegue il collegamento al db

            // optionsBuilder serve a settare il tipo di db usato e la stringa di connessione
        }
    }
}
