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
        List<PictureBox> collide;
        public Form1()
        {
            InitializeComponent();
            collide = new List<PictureBox>()
            {
                box1, box2, box3
            };
        }
        bool left, right, jump;
        int g = 17;
        int force;
        
        
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

        private void block1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Stop moving left and right
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        
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
                jump = false;
            }
            else
            {
                player.Top += 5; 
            }
            //Collision
            foreach (PictureBox p in collide)
            {
                if (player.Left + player.Width - 1 > p.Left && player.Left + player.Width + 5 < p.Left + p.Width + player.Width && player.Top + player.Width >= p.Top && player.Top < p.Top)
                {
                    player.Top = screen.Height - (p.Height + screen.Height - (p.Top + p.Height)) - player.Height;
                    force = 0;
                    jump = false;
                }
                if (player.Right > p.Left && player.Left < p.Right - player.Width / 2 && player.Bottom > p.Top)
                {
                    right = false;
                }
                if (player.Left < p.Right && player.Right > p.Left + player.Width / 2 && player.Bottom > p.Top)
                {
                    left = false;
                }
            }
        }
    }
}
