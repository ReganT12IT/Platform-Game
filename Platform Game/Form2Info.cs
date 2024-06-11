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
    public partial class Form2Info : Form
    {
        public Form2Info()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
