using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umwandlung_von_Zahlen_in_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl = -8754.3;
            string str;

            str = zahl.ToString();

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
