using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mit_dem_PC_sprechen_Teil2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ausgabe = "Hallo           Ben, wie geht es Dir?";
            Console.WriteLine("\n" + ausgabe + "\n");

            string name;
            Console.WriteLine("Gib einen weiteren Namen ein:");
            name = Console.ReadLine();

            int pos;
            pos = ausgabe.IndexOf("Ben");

            ausgabe = ausgabe.Insert(pos, name);


            Console.WriteLine("\n" + ausgabe + "\n");
            Console.ReadLine();
        }
    }
}
