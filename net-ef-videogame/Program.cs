using Microsoft.EntityFrameworkCore.Update.Internal;
using net_ef_videogame;

namespace net_ef_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key; //ConsoleKeyInfo è una struttura che rappresenta l’informazione sulla pressione di un tasto sulla console

            Console.WriteLine("Seleziona un'opzione: \n");

            Console.WriteLine("1 | Inserisci un nuovo videogioco");
            Console.WriteLine("2 | Inserisci una nuova software house");
            Console.WriteLine("3 | Ricerca uno o più videogiochi per nome o parti del nome");
            Console.WriteLine("4 | Ricerca un videogioco per id");
            Console.WriteLine("5 | Stampa la lista dei videogiochi");
            Console.WriteLine("6 | Cancella un videogioco \n");

            key = Console.ReadKey(true);

            switch (key.KeyChar)
            {
                case '1':
                    Console.Clear();
                    VideogameManager.CreateVideogame();
                    break;

                case '2':
                    Console.Clear();
                    VideogameManager.CreateSoftwareHouse();
                    break;

                case '3':
                    Console.Clear();
                    VideogameManager.SearchVideogamesName();
                    break;

                case '4':
                    Console.Clear();
                    VideogameManager.SearchVideogameId();
                    break;

                case '5':
                    Console.Clear();
                    VideogameManager.ReadVideogames();
                    break;

                case '6':
                    Console.Clear();
                    VideogameManager.DeleteVideogame();
                    break;
            }
        }
    }
}