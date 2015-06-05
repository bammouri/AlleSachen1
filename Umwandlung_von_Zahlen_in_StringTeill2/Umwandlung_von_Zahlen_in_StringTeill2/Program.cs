using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umwandlung_von_Zahlen_in_StringTeill2
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl;
            string eingabe;

            Console.WriteLine("Geben sie bitte eine Zahl ein: ");
            eingabe = Console.ReadLine();

            zahl = Convert.ToDouble(eingabe);
        }
    }
}
