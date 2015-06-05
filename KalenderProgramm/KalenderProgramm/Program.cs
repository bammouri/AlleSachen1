using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderProgramm
{
    class Program
    {
        enum Tage
        {
            Sonntag, Montag, Dienstag, Mittwoch,
            Donnerstag, Freitag, Samstag
        };
        

        static void Main(string[] args)
        {
            DateTime heute = DateTime.Now;

            switch(  (Tage) heute.DayOfWeek)
            {
                case Tage.Sonntag:

                    Console.WriteLine("Wunderbar, Sonntag\n");
                    break;


                case Tage.Montag:

                    Console.WriteLine("Es ist Montag :-(\n");
                    break;


                case Tage.Dienstag:

                    Console.WriteLine("Es ist Dienstag\n");
                    break;


                case Tage.Mittwoch:

                    Console.WriteLine("Es ist Mittwoch :-|\n");
                    break;


                case Tage.Donnerstag:

                    Console.WriteLine("Es ist Donnerstag\n");
                    break;
                    
                case Tage.Freitag:

                    Console.WriteLine("Es ist Freitag\n");
                    Console.WriteLine("Nicht geiles Wetter\n");
                    break;

                case Tage.Samstag:

                    Console.WriteLine("Hurra, Samstag :-)\n");
                    break;

                default:
                    Console.WriteLine("Fehler\n");
                    break;
            }
            Console.ReadLine();

        }
    }
}
