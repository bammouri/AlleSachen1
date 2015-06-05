using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte LOTTOZAHLEN = 6;

            byte[] zahlen = new byte[LOTTOZAHLEN];
            byte zusatzzahl;
            Random zufallszahlen = new Random(9);
            Random ´const byte = new Random(1);

            string kennwort;

            Console.WriteLine("Kennwort eingeben:");
            kennwort = Console.ReadLine();


            if (kennwort != "BEN")
            {
                Console.WriteLine("\nFalsches Kennwort\n");
                return;
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Willkommen im Hauptprogramm\n");
                
                    
                for (int i = 0; i < zahlen.Length; ++i)
                {
                   (i) = (byte)(zufallszahlen.Next(1, 50));
                   
                }
                
                zusatzzahl = (byte)(zufallszahlen.Next(1, 50));

                Array.Sort(zahlen);

                Console.WriteLine("Die Lottozahlen:");

                foreach (byte elem in zahlen)
                    Console.WriteLine("\t" + elem);


            }
            Console.WriteLine();
            Console.WriteLine("Zusatzzahl: " + zusatzzahl);
            Console.ReadLine();
        }
    }
}
