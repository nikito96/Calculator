using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int result, a, b;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                result = a - b;
                MessageBox.Show(a + " - " + b + " = " + result.ToString());
            }
            else
            {
                MessageBox.Show("Empty field!");
            }
}

        private void sumButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                result = a + b;
                MessageBox.Show(a + " + " + b + " = " + result.ToString());
            }
            else
            {
                MessageBox.Show("Empty field!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void divButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                result = a / b;
                MessageBox.Show(a + " / " + b + " = " + result.ToString());
            }
            else
            {
                MessageBox.Show("Empty field!");
            }
        }

        private void divButton2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                result = a % b;
                MessageBox.Show(a + " % " + b + " = " + result.ToString());
            }
            else
            {
                MessageBox.Show("Empty field!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                result = a * b;
                MessageBox.Show(a + " * " + b + " = " + result.ToString());
            }
            else
            {
                MessageBox.Show("Empty field!");
            }
        }
    }
}
