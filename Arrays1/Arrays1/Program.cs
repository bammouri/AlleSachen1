using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl; // "int" ist ein Array dem man einen Wert hinzufügen kann.
            zahl = 3; // Hier weisen wir "zahl" einen Wert zu. Indem fall 3.
        }
        

        int[] zahlen; // Für Array-Variablen sieht das Verfahren ganz änlich aus, nur dass die Werte, die man der Array-Variablen zuweist,
        // keine einfachen Werte, sondern Objekte sind, die mit new erzeugt werden. Bsp:
        zahlen = new int[100];

        // Man hat eine Adresse die als Kiste abgebildet wird (int zahl). Diese Kiste können wir eine Wert hinzufügen.
        // So änlich wie mit einer Obst-Kiste, legt man einfach 3 Äpfel hinzu.

        int[] zahlen;
        zahlen = new int[100]; // In dem Beispiel ist die Obstkiste "int[] zahlen". Wenn wir den Wert hinzufügen (zahlen = new int[100]) werden gleichzeitig,
    }                          // 100 Obstkisten erzeugt und alle haben einen Wert.
}
