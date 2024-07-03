using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace Platform_Game
{
    public partial class Form3Info : Form
    {
        public Form3Info()
        {
            InitializeComponent();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1Info f1i = new Form1Info();
            this.Hide();
            f1i.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
