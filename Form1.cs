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
    public partial class Form1 : Form
    {
        String[] words = { "Canada", "Nathan", "Daniel" };
        Random box = new Random();
        int time = 30;
        public Form1()
        {
            InitializeComponent();



            // randomize words
            for (int i = 0; i < words.Length; i++)
            {
                int d = box.Next(i, words.Length);
                string mix = words[i];
                words[i] = words[d];
                words[d] = mix;
            }
            // to lbls
            Label[] lbls = { label1, label3, label4, label5, label6, label7, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label21 };
            int label = 0;

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                // randomize letters for each word
                for (int i = 0; i < letters.Length; i++)
                {
                    int d = box.Next(i, letters.Length);
                    char mix = letters[i];
                    letters[i] = letters[d];
                    letters[d] = mix;
                }
                // string come to lbl if word is done (less than 6 letters)
                for (int i = 0; i < 6; i++)
                {
                    lbls[label].Text = letters[i].ToString();
                    label++;
                }




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = time.ToString();
            time--;
            if (time == -1)
            {
                timer1.Stop();
                MessageBox.Show("u got " +words + "right!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("They're 2 words that are names of ppl in our class, the other is a country, just guess!");
            button1.Visible = false;
            label22.Visible = false;
            time = time - 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool[] match = new bool[words.Length];
            PictureBox[] checkmarks = { pictureBox1, pictureBox2, pictureBox3 };
            bool red = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (textBox1.Text == words[i])
                {
                    match[i] = true;
                    time = time + 10;
                    checkmarks[i].Visible = true;
                    red = true;
                }
            }
            if (!red)
            {
                label8.BackColor = Color.Red;
            }
            else
            {
                label8.BackColor = this.BackColor;
            }
        }
    }

           
   }
 
        
 
