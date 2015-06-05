using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           int zahl1= Console.Read();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int zahl2 = Console.Read();
        }

    }
}



Und das ist die klasse:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Program
    {



        public void add(int zahl1, int zahl2)
        {

            int ergebnis = zahl1 + zahl2;
        }
        public void mal(int zahl1, int zahl2)
        {

            int ergebnis = zahl1 + zahl2;
        }
        public void geteilt(int zahl1, int zahl2)
        {

            int ergebnis = zahl1 + zahl2;
        }
        public void min(int zahl1, int zahl2)
        {

            int ergebnis = zahl1 + zahl2;
        }


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {


           
        }
    }
}
