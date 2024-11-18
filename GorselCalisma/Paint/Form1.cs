using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private string secilenSekil1;
        private int x, y, h, w;
        private int r, g, b;

        private bool isDrawing = false; 
        private Point previousPoint;    
        private Bitmap drawingBitmap;  
        private Color selectedColor = Color.Black;
        private int kalinlik = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawingBitmap = new Bitmap(panel2.Width, panel2.Height);
            panel2.BackgroundImage = drawingBitmap; 
            panel2.BackgroundImageLayout = ImageLayout.None;

            // Olayları bağla
            panel2.MouseDown += Panel2_MouseDown;
            panel2.MouseMove += Panel2_MouseMove;
            panel2.MouseUp += Panel2_MouseUp;

            trackBar1.Scroll += (s, ev) => UpdateSelectedColor();
            trackBar2.Scroll += (s, ev) => UpdateSelectedColor();
            trackBar3.Scroll += (s, ev) => UpdateSelectedColor();

            // RadioButton olaylarını bağla
            radioButton1.CheckedChanged += (s, ev) => UpdateLineThickness();
            radioButton2.CheckedChanged += (s, ev) => UpdateLineThickness();
            radioButton3.CheckedChanged += (s, ev) => UpdateLineThickness();
        }

        private void UpdateSelectedColor()
        {
            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;
            selectedColor = Color.FromArgb(r, g, b);
        }

        private void UpdateLineThickness()
        {
            if (radioButton1.Checked)
            {
                kalinlik = 1;
            }
            else if (radioButton2.Checked)
            {
                kalinlik = 3;
            }
            else if (radioButton3.Checked)
            {
                kalinlik = 5;
            }
        }

        // Sekil Cizme
        private void button1_Click(object sender, EventArgs e)
        {
            secilenSekil1 = comboBox1.SelectedItem.ToString();

            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            h = Convert.ToInt16(textBox3.Text);
            w = Convert.ToInt16(textBox4.Text);

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pan
            //panel1.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.White;
            Graphics g = e.Graphics;

            if (secilenSekil1 == "Dörtgen")
            {
                g.DrawRectangle(Pens.Black, x, y, w, h);
            }
            else if (secilenSekil1 == "Daire")
            {
                g.DrawEllipse(Pens.Black, x, y, w, h);
            }
            else if (secilenSekil1 == "Çizgi")
            {
                g.DrawLine(Pens.Black, x, y, x + w, y + h);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.White;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;          // Çizim başlasın
                previousPoint = e.Location; // İlk konumu kaydet
            }
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    // İki nokta arasına çizgi çiz
                    using (Pen pen = new Pen(selectedColor, kalinlik)) 
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                    }
                }

                // Çizimi güncelle
                panel2.Invalidate();

                // Şu anki konumu kaydet
                previousPoint = e.Location;
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false; // Çizim bitir
            }
        }
    }
}
