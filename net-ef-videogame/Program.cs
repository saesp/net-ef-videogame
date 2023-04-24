using Microsoft.EntityFrameworkCore.Update.Internal;
using net_ef_videogame;

namespace net_ef_videogame
{
    // 2 ricercare un videogioco per id
    // 3 ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
    // 4 cancellare un videogioco
    // 5 chiudere il programma
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key; //ConsoleKeyInfo è una struttura che rappresenta l’informazione sulla pressione di un tasto sulla console

            Console.WriteLine("Seleziona un'opzione: \n");

            Console.WriteLine("1 | Inserisci un nuovo videogioco");
            Console.WriteLine("2 | Inserisci una nuova software house");
            Console.WriteLine("3 | Ricerca un videogioco per nome");
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
                    VideogameManager.SearchVideogameName();
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