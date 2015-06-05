using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int befehl = -1;


            do
            {
                Console.WriteLine();
                Console.WriteLine(" Menue ");
                Console.WriteLine("  Vektoren eingeben       <1>" );
                Console.WriteLine("  Vektoren addieren <2>  ");
                Console.WriteLine(" Vektoren subthrahieren <3> ");
                Console.WriteLine("  Skarlapunkt          <4> ");
                Console.WriteLine("Vektortprodukt       <5>");
                Console.WriteLine(" Laenge berechnen <6Y");
                Console.WriteLine(" Programm beenden  <0>");

                Console.WriteLine("Ihre Eingabe :\n");
                befehl = Convert.ToInt32( Console.ReadLine());

                switch( befehl)
                {
                    case 0:
                        Console.WriteLine("Programm beenden");
                        break;

                    case 1:

                        // wie in menue.cs

                    default:
                        Console.WriteLine("Fehler\n");
                        break;

                } while(befehl != 0);



                 
                 
            
            }

        }
    }
}
