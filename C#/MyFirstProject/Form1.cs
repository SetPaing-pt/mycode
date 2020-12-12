using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class MyFirstProgram : Form
    {
        public MyFirstProgram()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Hide();
            textBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble (textBox1.Text);
            double b = 3.124 * (a * a);
            string c = b.ToString();
            label2.Show();
            textBox2.Show();
            MessageBox.Show(c);
           
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
