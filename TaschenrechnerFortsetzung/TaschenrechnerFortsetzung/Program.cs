using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerFortsetzung
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // "WriteLine" heißt das es sofort dort steht wenn man es ausführt.
            Console.WriteLine("Willkommen im Konsolen Taschenrechner.");
            // Int ist eine Variable und der geben wir einen Wert (Bsp. int zahl3 = 10)
            int zahl1 = 0, zahl2 = 0;
            while (true)

            {
                
                string eingabe1 = Console.ReadLine();
                if (eingabe1 == null)


                    break;

                zahl1 = Convert.ToInt32(eingabe1);
                zahl2 = Convert.ToInt32(eingabe1);



                int ergebnis = zahl1 + zahl2;

                Console.WriteLine("Das Ergebnis ist " + ergebnis);
                //Console.ReadLine();
            }
        }
    }
}
