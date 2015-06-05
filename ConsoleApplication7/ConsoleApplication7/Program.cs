using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            char zeichen;
            double x, y;

            Console.WriteLine("\nProgramm zu Wurzelberechnung\n\n");

            // for-Schleife mit leeren Komponenten
            for(;;) 
            {
            
                Console.WriteLine();
                Console.WriteLine("Geben Sie eine Zahl ein: ");
                x = Convert.ToDouble(Console.ReadLine());

                // Zahl verarbeiten, wenn ungleich Null
                if (x > 0)
                {
                    y = Math.Sqrt(x);

                    Console.WriteLine("Wurzel " + x + " = " + y);

                
                    Console.WriteLine();
                    Console.WriteLine("Weitere Berechnungen? (J/N)");

                    zeichen = Convert.ToChar(Console.ReadLine());

                    if (zeichen != 'j' && zeichen != 'J')


                        break;
                    


                }
                else
                    Console.WriteLine("Fehler: nur positive Zahlen");
                Console.ReadLine();

            }
        }
    }
}
