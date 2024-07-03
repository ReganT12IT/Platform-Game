using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using NAudio;
using NAudio.Wave;
using System.Threading;

namespace Platform_Game
{
    public partial class Form2 : Form
    {
        //Declare variables
        List<PictureBox> collide;

        AudioFileReader reader = new AudioFileReader("../../audio/metronome.mp3");

        public Form2()
        {
            InitializeComponent();
            //Add to list of items with collisions
            collide = new List<PictureBox>()
            {
                box1, box2, box3, box5, box6, box7, box8, box9, box10, box11, box12,
            };
            sound = new WaveOut();
            sound.Init(reader);
        }
        //Declare variables
        bool left, right, jump, touched;
        int g = 17;
        int force;
        int counter;
        IWavePlayer sound;
        

        private void screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {

        }

        private void box12_Click(object sender, EventArgs e)
        {

        }

        private void box10_Click(object sender, EventArgs e)
        {

        }

        private void box11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void box9_Click(object sender, EventArgs e)
        {

        }

        private void box8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void box7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void box6_Click(object sender, EventArgs e)
        {

        }

        private void box5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void box4_Click(object sender, EventArgs e)
        {

        }

        private void box2_Click(object sender, EventArgs e)
        {

        }

        private void box1_Click(object sender, EventArgs e)
        {

        }

        private void box3_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
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
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            //Stop moving left and right
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter ++;
              
            //Collision
            foreach (PictureBox p in collide)
            {
                //right collision
                if (player.Right > p.Left && player.Left < p.Right - player.Width / 2 && player.Bottom > p.Top && player.Top < p.Bottom)
                {
                    right = false;
                }
                //left collision
                if (player.Left < p.Right && player.Right > p.Left + player.Width / 2 && player.Bottom > p.Top && player.Top < p.Bottom)
                {
                    left = false;
                }
                //bottom colision
                if (player.Left + player.Width - 1 > p.Left && player.Left + player.Width + 5 < p.Left + p.Width + player.Width && player.Bottom + player.Width >= p.Bottom && player.Top < p.Bottom)
                {
                    jump = false;
                }
            }
            //movement
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
            //top collision
            foreach (PictureBox p in collide)
            {
                if (player.Left + player.Width - 1 > p.Left && player.Left + player.Width + 5 < p.Left + p.Width + player.Width && player.Top + player.Height >= p.Top && player.Top < p.Top)
                {
                    player.Top = screen.Height - (p.Height + screen.Height - (p.Top + p.Height)) - player.Height;
                    force = 0;
                    jump = false;
                }
            }
            //Death
            if (player.Bounds.IntersectsWith(box4.Bounds))
            {
                player.Location = new Point(200, 427);
            }
            //End level 
            if (player.Bounds.IntersectsWith(finish.Bounds))
            {
                if (touched == false)
                {
                    touched = true;
                    //Open next level info
                    Form3Info f3i = new Form3Info();
                    this.Hide();
                    f3i.ShowDialog();

                    this.Close();
                    
                }
            }
            if (touched == false)
            {
                if (counter % 40 == 0)
                {
                    reader = new AudioFileReader("../../audio/metronome.mp3");
                    sound = new WaveOut();
                    sound.Init(reader);
                    sound.Play();
                }
            }
          
            if (player.Bounds.IntersectsWith(edgeb.Bounds))
            {
                if (touched == false)
                {
                    player.Location = new Point(200, 427);

                }
            }

                //150 bpm quarter notes
                if (counter / 40 % 2 == 0)
            {
                box5.Show();
                box6.Show();
                box7.Show();
                box8.Show();
                box9.Show();
                box10.Show();
                box11.Show();
                box4.Show();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();
                pictureBox7.Show();
                pictureBox9.Show();
                pictureBox11.Show();
            }
            else
            {
                box5.Hide();
                box6.Hide();
                box7.Hide();
                box8.Hide();
                box9.Hide();
                box10.Hide();
                box11.Hide();
                box4.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                pictureBox9.Hide();
                pictureBox11.Hide();
            }
            
        }

    }
}

