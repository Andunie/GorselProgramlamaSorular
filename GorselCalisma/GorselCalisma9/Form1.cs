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

        private void Form1_Load(object sender, EventArgs e)
        {
            double[,] notlar = new double[5, 2];
            string[] ogrenciAdlari = new string[5];

            for (int i = 0; i < 5; i++)
            {
                ogrenciAdlari[i] = Microsoft.VisualBasic.Interaction.InputBox($"Öğrenci {i + 1} Adı:", "Öğrenci Adı Girişi", "Öğrenci Adı");

                string vizeStr = Microsoft.VisualBasic.Interaction.InputBox($"{ogrenciAdlari[i]} adlı öğrencinin Vize notunu giriniz:", "Vize Notu Girişi", "0");
                notlar[i, 0] = Convert.ToDouble(vizeStr);

                string finalStr = Microsoft.VisualBasic.Interaction.InputBox($"{ogrenciAdlari[i]} adlı öğrencinin Final notunu giriniz:", "Final Notu Girişi", "0");
                notlar[i, 1] = Convert.ToDouble(finalStr);
            }

            string sonuc = "";
            for (int i = 0; i < 5; i++)
            {
                double ortalama = (notlar[i, 0] * 0.4) + (notlar[i, 1] * 0.6);
                string durum = ortalama >= 70 ? "Geçti" : "Kaldı";
                sonuc += $"{ogrenciAdlari[i]}: Ortalama = {ortalama:F2}, Durum = {durum}\n";
            }

            MessageBox.Show(sonuc, "Öğrenci Sonuçları");
        }
    }
}
