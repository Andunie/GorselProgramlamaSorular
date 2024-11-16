using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselCalisma7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.K)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            else if (e.Control && e.KeyCode == Keys.A && e.Shift)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
        }
    }
}
