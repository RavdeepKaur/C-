using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            MessageBox.Show("Welcome "+fname+" "+lname);


            String ex1 = textBox3.Text;
            String ex2 = textBox4.Text;
            String ex3 = textBox5.Text;

            double exp1 = double.Parse(ex1);
            double exp2 = double.Parse(ex2);
            double exp3 = double.Parse(ex3);

            double totalExp = exp1 + exp2 + exp3;

            label5.Text = totalExp.ToString();

        }
    }
}
