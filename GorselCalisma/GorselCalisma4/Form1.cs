using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselCalisma4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.MouseDown += listBox1_MouseDown;

            listBox2.DragEnter += listBox2_DragEnter;
            listBox2.DragDrop += listBox2_DragDrop;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Move);
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = (string)e.Data.GetData(typeof(string));
            listBox2.Items.Add(droppedItem);

            listBox1.Items.Remove(droppedItem);
        }
    }
}
