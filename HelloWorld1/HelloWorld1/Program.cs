using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld!");


            Console.WriteLine("Drück eine Taste, und es schließt sich.");
            
            string input = Console.ReadLine();
            Console.WriteLine("Ihre Eingabe:");
            Console.WriteLine(input);

            Console.ReadKey();
        }


    }

}
          
