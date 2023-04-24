using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    internal class VideogameManager
    {
        public static void CreateVideogame()
        {
            using (VideogameContext db = new VideogameContext())
            {
                Console.WriteLine("Inserisci i dati del nuovo videogioco:");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                // descrizione
                Console.Write("Descrizione: ");
                string overview = Console.ReadLine();

                // data di rilascio
                Console.Write("Data di rilascio (gg/mm/aaaa): ");
                DateTime releaseDate = Convert.ToDateTime(Console.ReadLine());

                // software house id
                Console.Write("Id casa produttrice: ");
                int softwareHouseId = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Videogame newVideogame = new Videogame { Name = name, Overview = overview, ReleaseDate = releaseDate, SoftwareHouseId = softwareHouseId };

                    db.Videogames.Add(newVideogame);
                    db.SaveChanges();

                    Console.WriteLine($"Inserito record nella tabella Videogame");
                }

                catch (Exception ex) // gestione di eventuali errori
                {
                    Console.WriteLine($"ERRORE: {ex.Message}");
                }
                // non serve usare 'finally' con close() per chiudere la risorsa grazie a using()
            }
        }

        public static void CreateSoftwareHouse()
        {
            using (VideogameContext db = new VideogameContext())
            {
                Console.WriteLine("Inserisci i dati della nuova Software House");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                // descrizione
                Console.Write("Indirizzo: ");
                string address = Console.ReadLine();

                try
                {
                    SoftwareHouse newSoftwareHouse = new SoftwareHouse { Name = name, Address = address };

                    db.SoftwareHouses.Add(newSoftwareHouse);
                    db.SaveChanges();

                    Console.WriteLine($"Inserito record nella tabella SoftwareHouse");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"ERRORE: {ex.Message}");
                }
            }
        }
    }
}