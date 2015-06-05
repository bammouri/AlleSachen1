using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Willkommen im Konsolen Taschenrechner.");
            int zahl1 = 123, zahl2 = 123;
           
            
            
            

            

            int ergebnis = zahl1 + zahl2;

            Console.Write("Das Ergebnis ist " + ergebnis);
            Console.ReadLine();
            

        }
        private static void GetData(ref int num)
            
        {
        dataInput:

            Console.WriteLine("Zahl eingeben und mit Enter bestätigen.");

            string data = Console.ReadLine();
            bool result = int.TryParse(data, out num);

            if (!result)
            {
                Console.WriteLine("Die Zahl hat ein zu großes Volumen!");
                Console.WriteLine("Bitte eine Neue Zahl eingeben!");
                goto dataInput;
               
                
                
            }
            
        }
    }
}

