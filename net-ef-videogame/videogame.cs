using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Aggiungiamo anche un’altra voce al menu :
//inserisci una nuova software house
//Fatto questo, ogni volta che creiamo un nuovo videogioco dobbiamo abbinargli la software house che l’ha prodotto (che dobbiamo aver precedentemente inserito in tabella), chiedendo all’utente l’id della software house e impostandolo nell’entity del videogame.
//Realizzare quindi tutte le entity e le migration necessarie per creare il database e implementare tutte le richieste dell’esercizio.
//BONUS : aggiungere un’altra voce di menu
//stampa tutti i videogiochi prodotti da una software house (all’utente verrà chiesto l’id della software house della quale mostrare i videogame)
//NB: per effettuare la ricerca sui videogames contenenti una stringa usare la sintassi:
//.Where(m => m.Name.Contains(stringaDaRicercare))
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
