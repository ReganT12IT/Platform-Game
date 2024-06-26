﻿using System;
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
    public partial class Form1Info : Form
    {
        public Form1Info()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("../../text/f1.txt");
            foreach (var line in lines)
            {
                listBoxInformation.Items.Add(line);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
    
}
