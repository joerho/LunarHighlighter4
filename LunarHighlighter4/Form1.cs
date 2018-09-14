using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarHighlighter4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        //For the start button
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.BackColor = colorDialog1.Color;
            f2.ShowDialog();
        }

        //Color chooser
        private void button2_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
      
        }
    }
}
