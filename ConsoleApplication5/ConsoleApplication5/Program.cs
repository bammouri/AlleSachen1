using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double winkel; // Winkel Peillinie - Boden
            // in Grad
            double distanz; // Entfernung
            // Peilpunkt - Hauswand
            double hoehe;

            // Daten einlesen
            Console.WriteLine("Winkel in Grad eingeben:");
            winkel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Distanz in Meter eingeben:");
            distanz = Convert.ToDouble(Console.ReadLine());

            // Höhre berechnen und ausgeben
            winkel = winkel * 2 * Math.PI / 360; // Umrechnung
            // in RAD

            hoehe = distanz * Math.Tan(winkel);

            Console.WriteLine("Das Haus ist " + hoehe + " Meter hoch.");
            Console.ReadLine();
        }
    }
}
