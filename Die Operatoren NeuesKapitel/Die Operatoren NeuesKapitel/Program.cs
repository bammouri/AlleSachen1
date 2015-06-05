using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Operatoren_NeuesKapitel
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1;
            double zahl2;
            double ergebnis;

            Console.WriteLine("Geben sie die erste Zahl ein: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie die zweite Zahl ein: ");
            zahl2 = Convert.ToDouble(Console.ReadLine());

            ergebnis = zahl1 * zahl2;  //Multiplikation

            Console.WriteLine(ergebnis);
            Console.ReadLine();
        }
    }
}
