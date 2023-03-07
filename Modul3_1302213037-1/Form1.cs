using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_1302213037_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y, z;

        private void button7_Click(object sender, EventArgs e)
        {
            int num = 7;
            Output.Text = num.ToString();
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = 1;
            Output.Text= num.ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int num = 2;
            Output.Text = num.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int num = 3;
            Output.Text = num.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int num = 4;
            Output.Text = num.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int num = 5;
            Output.Text = num.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int num = 6;
            Output.Text = num.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int num = 8;
            Output.Text = num.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int num = 9;
            Output.Text = num.ToString();
        }

        private void btnEQ_Click(object sender, EventArgs e)
        {
            y = int.Parse(Output.Text);
            z = x + y;
            Output.Text = z.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int num = 0;
            Output.Text = num.ToString();
        }

        private void btnPLUS_Click(object sender, EventArgs e)
        {
            x = int.Parse(Output.Text);
            Output.Text += " ";
        }
    }
}
