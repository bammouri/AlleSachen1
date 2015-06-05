using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList zahlen = new ArrayList();
            zahlen.Add(333);
            string eingabe;

            Console.WriteLine("Werte eingeben (b zum beenden)");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Wert eingeben: ");
                eingabe = Console.ReadLine();

                if (eingabe == "b")
                    break;

                zahlen.Add(Convert.ToInt32(eingabe));



            } while (true);


            System.Collections.IEnumerator Enumrator =
                                           zahlen.GetEnumerator();
            while (Enumrator.MoveNext())
                Console.WriteLine(" " + Enumrator.Current);
            Console.ReadLine();

        }
    }
}
