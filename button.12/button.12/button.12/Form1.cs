using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, fark, carpım, bolum;

            sayi1=Convert.ToDouble(txtsayi1.Text);
            sayi2=Convert.ToDouble(txtsayi2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpım = sayi1 * sayi2;
            bolum=sayi1 / sayi2;

            lbltoplam.Text = "Toplam: " + toplam;
            lblfark.Text = "Fark: " + fark;
            lblcarpım.Text = "Çarpım: " + carpım;
            lblbolum.Text = "Bölüm: " + bolum;

        }
    }
}
