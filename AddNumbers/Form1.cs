﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNumbers
{
    public partial class TxtNumber1 : Form
    {
        public TxtNumber1()
        {
            InitializeComponent();
        }

        private void TxtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(TxtNum1.Text);
            num2 = Convert.ToInt32(TxtNum2.Text);
            sum = num1 + num2;
            lblResult2.Text = sum.ToString();
        }
    }
}
