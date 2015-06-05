using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGameTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Du hast es geschaft! :)");
            Close();
        }
        private void movetostart()
        {
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingpoint);
        }
       

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            movetostart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            movetostart();
        }
    }
}
