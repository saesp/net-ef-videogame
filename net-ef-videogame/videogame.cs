using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    //[Table("videogames")]  //per cambiare il nome
    public class Videogame
    {
        [Key] public int VideogameId { get; set; }
        [Required] public string Name { get; set; }
        public string? Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        public int SoftwareHouseId { get; set; }

        //one (SoftwareHouse) to many (Videogames)
        public SoftwareHouse SoftwareHouse { get; set; }

        public Videogame(int videogameId, string name, string? overview, DateTime releaseDate, int softwareHouseId)
        {
            VideogameId = videogameId; 
            Name = name;
            Overview = overview;
            ReleaseDate = releaseDate;
            SoftwareHouseId = softwareHouseId;
        }

        public Videogame()
        {
        }
    }
}
