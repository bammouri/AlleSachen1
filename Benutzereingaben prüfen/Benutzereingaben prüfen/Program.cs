using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benutzereingaben_prüfen
{
    class Program
    {
        static void Main(string[] args)
        {
            double eingabe;
            double wurzel;

            Console.WriteLine("\nGeben Sie bitte eine Zahl ein:");
            eingabe = Convert.ToDouble(Console.ReadLine());


            if (eingabe < 0)
            {
                eingabe = Math.Abs(eingabe);
                Console.WriteLine();
                Console.WriteLine("Die Wurzel ist nur positive" + " Zahlen definiert. \nEs wird die " + "Wurzel von " + eingabe + "berechnet!");


            }



            wurzel = Math.Sqrt(eingabe);

            Console.WriteLine("\nDie Wurzel von " + eingabe + " ist " + wurzel);
            Console.ReadLine();
                
        }
    }
}
