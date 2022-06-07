using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nudNum2.Text == 0.ToString())
            {
                MessageBox.Show("計算できません","errore",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Hand);
            } else
            {
                nudAns.Text = (int.Parse(nudNum1.Text) / int.Parse(nudNum2.Text)).ToString();
                nudMod.Text = (int.Parse(nudNum1.Text) % int.Parse(nudNum2.Text)).ToString();
            }
        }

        
        private void label3_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        
    }
}
