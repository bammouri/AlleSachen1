using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstante_Variablen1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415;

            const int ERDOBERFLÄCHE = 510100933; // In km²

            const double MEINALTER = 15; // bleibt in Realität
                                         // leider nicht
                                         // konstant
            double zahl1;
            int zahl2;

            zahl1 = PI;
            zahl2 = ERDOBERFLÄCHE;

            Console.WriteLine(zahl1);
            Console.WriteLine(zahl2);
            Console.ReadLine();


        }
    }
}
