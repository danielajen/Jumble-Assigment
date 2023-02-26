using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumble_Assigment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("They're 2 rounds of 3 words and they're all scrambled up and the letters are randomized and you have to guess them correctly! If you guess correctly u get checks, and a label will turn red for incorrect. YOU CAN ONLY USE 1 HINT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();

        }
    }
}
