using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigener_Taschenrechner
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Moin, hier biste beim Taschenrechner");
            int zahl1 = 9999999, zahl2 = 99999999;



            int ergebnis = zahl1 * zahl2;

            Console.WriteLine("Das Ergebnis ist " + ergebnis);
            Console.ReadLine();
        }
    }
}
