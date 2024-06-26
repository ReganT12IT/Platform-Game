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
    public partial class Form2Info : Form
    {
        public Form2Info()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("../../text/f2.txt");
            foreach (var line in lines)
            {
                listBoxInformation.Items.Add(line);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
