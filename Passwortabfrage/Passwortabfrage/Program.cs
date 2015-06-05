using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwortabfrage
{
    class Program
    {
        static void Main(string[] args)
        {
            string kennwort;


            Console.WriteLine("Kennwort eingeben:");
            kennwort = Console.ReadLine();

            if (kennwort != "Sesam") ;
            {
                Console.WriteLine("\nFalsches Kennwort\n");
                Console.ReadLine();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Willkommen im Hauptprogramm\n");
            Console.ReadLine();
        }
    }
}
