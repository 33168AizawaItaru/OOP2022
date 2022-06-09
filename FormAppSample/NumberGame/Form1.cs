using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class form1 : Form
    {
        private Random rand = new Random();
        private int numRand;

        public form1(){InitializeComponent();}

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (numRand == inRandom.Value)
            {
                label2.Text = "正解";
            } else if (inRandom.Value > numRand)
            {
                label2.Text = "小さくして";
            } else
            {
                label2.Text = "大きくして";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numRand = rand.Next(minValue: 1, maxValue: 51);
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            getRandom();
        }

        private void getRandom() {
            numRand = rand.Next(minValue: 1, maxValue: 51);
        }

        private void label1_Click(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e){}
    }
}
