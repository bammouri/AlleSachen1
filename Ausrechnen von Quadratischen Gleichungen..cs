using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Angabe in: cx² + dx + e");
            Console.WriteLine("=========================");


            Console.Write("Eingabe von c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Eingabe von d: ");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Eingabe von e: ");
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (c == 1.0)
            {
                calculate(d, e);
            }
            else
            {
                d = d / c;
                e = e / c;
                calculate(d, e);
            }

            Console.ReadLine();
        }

        static void calculate(double d, double e)
        {
            double x1 = -(d / 2) + Math.Sqrt(Math.Pow((d / 2), 2) - e);
            double x2 = -(d / 2) - Math.Sqrt(Math.Pow((d / 2), 2) - e);

            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
        }
    }
}
