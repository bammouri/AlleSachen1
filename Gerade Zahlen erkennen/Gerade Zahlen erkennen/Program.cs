using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerade_Zahlen_erkennen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            while (true)
            {
                
                Console.WriteLine("Geben Sie eine gerade Zahl ein:");
                zahl = Convert.ToInt32(Console.ReadLine());



                if ((zahl & 1) == 1)
                    Console.WriteLine("Ey, das war keine gerade Zahl!");
                Console.ReadLine();
                break;
                goto while;
            }
            

            
           

        }
    }
}
