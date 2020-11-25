using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);

                double volume = length * width * height;
                double surfacearea =  2.0 * (length * height + length*width + width * height);
                label1.Text = "volume =" + volume;
                label2.Text = "surfacearea" + surfacearea;
                











            }
            catch
            {
                MessageBox.Show("error on input");

            }















        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox4.Text);
            double sarea = 4.0 * Math.PI * radius * radius;
            double volume = 4.0 / 3.0 * Math.PI * radius * radius * radius;

            label3.Text = "volume =" + volume;
            label4.Text = "sarea =" + sarea;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(textBox5.Text);
            double height = double.Parse(textBox6.Text)
        }
    }
}
