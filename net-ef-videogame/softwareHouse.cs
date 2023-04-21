using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class SoftwareHouse
    {
        [Key] public int SoftwareHouseId { get; set; }
        [Required]public string Name { get; set; }
        public string? Address { get; set; }

        //one (SoftwareHouse) to many (Videogames)
        public List<Videogame> Videogames { get; set; }

        public SoftwareHouse(int softwareHouseId, string name, string? address, List<Videogame> videogames)
        {
            SoftwareHouseId = softwareHouseId; 
            Name = name;
            Address = address;
            Videogames = videogames;
        }
        public SoftwareHouse()
        {
        }
    }
}
