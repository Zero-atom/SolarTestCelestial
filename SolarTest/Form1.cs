using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolarTest
{
    public partial class Form1 : Form
    {
        CelestialObject CObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CObject.Size = int.Parse(textBox8.Text);
            CObject.Mass = int.Parse(textBox12.Text);
            CObject.Name = int.Parse(textBox13.Text);
            CObject.AddCelestialObject(int.Parse(textBox12.Text), int.Parse(textBox10.Text), int.Parse(textBox8.Text), int.Parse(textBox13.Text), int.Parse(textBox7.Text));
            label8.Text = textBox13.Text;
            textBox1.Text = textBox12.Text;
            textBox2.Text = textBox10.Text;
            textBox3.Text = textBox8.Text;
            textBox4.Text = textBox7.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
