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
            Output.Text = "";
        }

        int angka;
        int hasil;
        private void button7_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "7";
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            Output.Text = Output.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            Output.Text = Output.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "9";
        }

        private void btnEQ_Click(object sender, EventArgs e)
        {
            angka = int.Parse(Output.Text);
            hasil += angka;
            Output.Text = hasil.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Output.Text = Output.Text + "0";
        }

        private void btnPLUS_Click(object sender, EventArgs e)
        {
            angka = int.Parse(Output.Text);
            hasil += angka;
            Output.Text = "";
        }
    }
}
