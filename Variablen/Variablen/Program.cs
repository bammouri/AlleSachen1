using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablen
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 42;
            string greeting = "Hallo Welt!";
            double bigNumber = 1e100;

            System.Console.WriteLine("{0} {1} {2}", answer, greeting, bigNumber);

            Console.ReadLine();
        }
    }
}
