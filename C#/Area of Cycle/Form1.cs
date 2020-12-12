using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_of_Cycle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Hide(); //double r = Convert.ToDouble (textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double a = 3.142 * (r * r);
            textBox2.Text = a.ToString();
            textBox3.Text = "3.142 x" + r + "**2";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
