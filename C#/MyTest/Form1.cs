using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //double a = Convert.ToDouble(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Hide();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = 3.142 * (a * a);
            textBox3.Text = b.ToString();
            textBox2.Text = "3.142 " + a + " **2";
            textBox2.Show();
            label2.Show();
            textBox3.Show();
            label3.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            label2.Hide();
            textBox3.Hide();
            label3.Hide();

        }
    }
}
