using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public class VideogameManager
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

        public static void SearchVideogameName()
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {
                    Console.WriteLine("Scrivi il nome del videogioco che vuoi cercare.");
                    string vgName = Console.ReadLine();
                    Console.WriteLine();

                    List<Videogame> videogames = db.Videogames.OrderBy(videogame => videogame.Name).ToList<Videogame>();

                    foreach (Videogame videogame in videogames)
                    {
                        if (vgName == videogame.Name)
                            Console.WriteLine($"Id: '{videogame.VideogameId}', Name: '{videogame.Name}', Overview: '{videogame.Overview}', Relase date: '{videogame.ReleaseDate}' \n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRORE: {ex.Message}");
                }
            }
        }

        public static void SearchVideogameId()
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {
                    Console.WriteLine("Scrivi l'Id del videogioco che vuoi cercare.");
                    int vgName = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    List<Videogame> videogames = db.Videogames.OrderBy(videogame => videogame.VideogameId).ToList<Videogame>();

                    foreach (Videogame videogame in videogames)
                    {
                        if (vgName == videogame.VideogameId)
                            Console.Write($"Id: '{videogame.VideogameId}', Name: '{videogame.Name}', Overview: '{videogame.Overview}', Relase date: '{videogame.ReleaseDate}' \n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRORE: {ex.Message}");
                }
            }
        }

        public static void ReadVideogames()
        {
            using (VideogameContext db = new VideogameContext())
            {
                try
                {
                    Console.WriteLine("Lista di videogiochi: \n");

                    List<Videogame> videogames = db.Videogames.OrderBy(videogame => videogame.Name).ToList<Videogame>();

                    foreach (Videogame videogame in videogames)
                    {
                        Console.WriteLine($"Id: '{videogame.VideogameId}', Name: '{videogame.Name}', Overview: '{videogame.Overview}', Relase date: '{videogame.ReleaseDate}' \n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRORE: {ex.Message}");
                }
            }
        }

        //public static void DeleteVideogame()
        //{
        //    using (VideogameContext db = new VideogameContext())
        //    {
        //        try
        //        {
        //            List<Videogame> videogames = db.Videogames.OrderBy(vg => vg.VideogameId).ToList<Videogame>();

        //            db.Remove(vg);
        //            db.SaveChanges();

        //            Console.WriteLine($"Inserito record nella tabella Videogame");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"ERRORE: {ex.Message}");
        //        }
        //    }
        //}
    }
}