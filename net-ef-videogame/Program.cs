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
            }
        }
    }
}