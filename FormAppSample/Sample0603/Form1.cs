﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //ボタンクリックイベントハンドラ
        private void button1_Click(object sender, EventArgs e)
        {
            //tbAns.Text = (int.Parse(tbSuu1.Text) + int.Parse(tbSuu2.Text)).ToString();
            nudAns.Value = nudSuu1.Value + nudSuu2.Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbSuu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSuu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAns_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}