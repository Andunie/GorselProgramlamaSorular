using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselCalisma9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y - Convert.ToInt16(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X - Convert.ToInt16(textBox1.Text), button1.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X + Convert.ToInt16(textBox1.Text), button1.Location.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + Convert.ToInt16(textBox1.Text));
        }

        // R buton
        private void button6_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int randomX = rnd.Next(0, 352);
            int randomY = rnd.Next(0, 250);

            button1.Location = new Point(randomX, randomY);
        }
    }
}
