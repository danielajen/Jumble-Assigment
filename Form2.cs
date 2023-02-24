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
            MessageBox.Show("They're three words and they're all scrambled up and the letters are randomized and you have to guess them correctly! If you guess correctly the word background will turn green to show correct, red for incorrect. YOU CAN ONLY USE 1 HINT");
        }
    }
}
