using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Platform_Game
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("../../text/information.txt");
            foreach (var line in lines)
            {
                listBoxInformation.Items.Add(line);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1Info f1i = new Form1Info();
            this.Hide();
            f1i.ShowDialog();
            this.Close();
        }

    }
}
