using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselCalisma6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 100;
            hScrollBar1.Value = 0;

            hScrollBar2.Minimum = 0;
            hScrollBar2.Maximum = 100;
            hScrollBar2.Value = 0;

            hScrollBar3.Minimum = 0;
            hScrollBar3.Maximum = 100;
            hScrollBar3.Value = 0;

            int panelR = 0;
            int panelG = 0;
            int panelB = 0;
            panel1.BackColor = Color.FromArgb(panelR, panelG, panelB);
            panel1.BackColor = SystemColors.Window;

            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            panel1.Paint += Panel1_Paint;
            panel1.Refresh();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Font font = new Font("Arial", 16, FontStyle.Bold);

            if (radioButton2.Checked)
            {
                int rr = hScrollBar1.Value;
                int gg = hScrollBar2.Value;
                int bb = hScrollBar3.Value;

                Color color = Color.FromArgb(rr, gg, bb);

                Brush brush = new SolidBrush(color);

                string text = "Merhaba, Panel!";
                PointF location = new PointF(30, 30); // Panel içinde (x:10, y:10) konumu

                g.DrawString(text, font, brush, location);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }
        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UpdatePanelColor();
        }

        private void UpdatePanelColor()
        {
            if (radioButton1.Checked)
            {
                int r = hScrollBar1.Value;
                int g = hScrollBar2.Value;
                int b = hScrollBar3.Value;

                panel1.BackColor = Color.FromArgb(r, g, b);
            }
            else if (radioButton2.Checked)
            {
                int rr = hScrollBar1.Value;
                int gg = hScrollBar2.Value;
                int bb = hScrollBar3.Value;

                panel1.ForeColor = Color.FromArgb(rr, gg, bb);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
