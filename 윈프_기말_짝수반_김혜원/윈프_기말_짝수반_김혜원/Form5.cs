using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                label3.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 1)
            {
                label4.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 2)
            {
                label5.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 3)
            {
                label6.Text += "\n사용중";
            }
            //B
            if (listBox1.SelectedIndex == 4)
            {
                label10.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 5)
            {
                label9.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 6)
            {
                label8.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 7)
            {
                label7.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 8)
            {
                label14.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 9)
            {
                label13.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 10)
            {
                label12.Text += "\n사용중";
            }
            if (listBox1.SelectedIndex == 11)
            {
                label11.Text += "\n사용중";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                label3.Text = "A1";
            }
            if (listBox1.SelectedIndex == 1)
            {
                label4.Text = "A2";
            }
            if (listBox1.SelectedIndex == 2)
            {
                label5.Text = "A3";
            }
            if (listBox1.SelectedIndex == 3)
            {
                label6.Text = "A4";
            }
            //B
            if (listBox1.SelectedIndex == 4)
            {
                label10.Text = "B1";
            }
            if (listBox1.SelectedIndex == 5)
            {
                label9.Text = "B2";
            }
            if (listBox1.SelectedIndex == 6)
            {
                label8.Text = "B3";
            }
            if (listBox1.SelectedIndex == 7)
            {
                label7.Text = "B4";
            }
            if (listBox1.SelectedIndex == 8)
            {
                label14.Text = "C1";
            }
            if (listBox1.SelectedIndex == 9)
            {
                label13.Text = "C2";
            }
            if (listBox1.SelectedIndex == 10)
            {
                label12.Text = "C3";
            }
            if (listBox1.SelectedIndex == 11)
            {
                label11.Text = "C4";
            }
        }
    }
}
