using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIBasics_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Blue");
            comboBox1.Items.Add("Black");
        }

        private void textc(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Cyan;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("PINK");
            comboBox1.Items.Add("RED");
            comboBox1.Items.Add("WHITE");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
