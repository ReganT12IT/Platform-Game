using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool left, right, jump;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Move left and right
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = g;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Stop moving left and right
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        int force = 17;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true) { player.Left += 5; }//5 pixels to the right
            if (left == true) { player.Left -= 5; }//5 pixels to the left
            //Falling
            if (jump == true)
            {
                player.Top -= force;
                force -= 1;

            }
            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; //Stop Falling
            }

        }
    }
}
