using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
            movetostart();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Finish_MouseEnter(object sender, EventArgs e) 
        {
            MessageBox.Show("Du hast das Ziel erreicht! Gut gemacht :)"); // Das tritt auf wenn man das ziel erreicht hat. "MessageBox" bedeuted das eine Nachricht auftritt
                                        // Das in den Klammern z.B ("Du hast gewonnen") steht dort wenn die MessageBox auftaucht.
            Close(); // Über den Befehl schließt sich das Spiel wenn man auf den Knopf "Ok" von der MessageBox klickt.
        }
        private void movetostart()
        {
            Point startingpoint = panel1.Location; // Dieser Befehl gibt an wo die Maus genau ist "Location" aus dem Englischen heisst Ort oder so.
            startingpoint.Offset(10, 10); // Hier werden die Koordinaten angegeben wo man starten soll. In dem Fall (10,10), also oben Links in der Ecke.
            Cursor.Position = PointToScreen(startingpoint);
        }
       

        private void wall_MouseEnter(object sender, EventArgs e) // wall_MouseEnter bedeuted, dass wenn die Maus ein Roten Balken trifft,
                                                                 // springt die Maus sofort wieder zu den ursprung zurück.
        {
            movetostart(); // movetostart heisst ganz einfach, dass wenn man die Maus bewegt startet das Spiel.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
