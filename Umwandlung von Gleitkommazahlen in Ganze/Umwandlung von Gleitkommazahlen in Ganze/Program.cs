using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umwandlung_von_Gleitkommazahlen_in_Ganze
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1 = 1234.567;
            int zahl2;
            short s_zahl = 110;
            int i_zahl = 220;
            double d_zahl = 330;

            i_zahl = s_zahl;
            d_zahl = i_zahl;

            zahl2 = Convert.ToInt32(zahl1);

            Console.WriteLine(zahl2);
            Console.ReadLine();
        }
    }
}
