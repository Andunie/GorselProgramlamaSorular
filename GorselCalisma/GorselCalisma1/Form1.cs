using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselCalisma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();

            listBox1.ClearSelected();

            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string listItem = listBox1.Items[i].ToString();

                if (listItem.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listBox1.SetSelected(i, true);
                }
                else
                {
                    //listBox1.SetSelected(i, false);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
