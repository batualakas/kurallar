using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k06_KararYapilari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Vize'nin %30'u final'in % 70 ini alıp Not'u gösterip onlara harf tanımlayan bir kod yazınız.





        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            var vize1 = txtVize.Text;
            var vizeNotu1 = Convert.ToDouble(vize1);
            var final1 = txtFinal.Text;
            var finalNotu1 = Convert.ToDouble(final1);
            string durum = "";

            

            var sonuc1 = ((vizeNotu1 * 30/100) + (finalNotu1 * 70/100));
            var sonNot = Convert.ToDouble(sonuc1);
            lblOrtalama1.Text = Convert.ToString(sonNot);

            if (sonNot < 30)
            {
                lblHarfNotu1.Text = "FF";
            }
            else if (sonNot >= 30 && sonNot < 50)
            {
                lblHarfNotu1.Text = "DD";
            }
            else if (sonNot >= 50 && sonNot<60)
            {
                lblHarfNotu1.Text = "CC";
            }
            else if (sonNot >=60 && sonNot<85  )
            {
                lblHarfNotu1.Text = "BA";

            }
            else if (sonNot >= 85 && sonNot <= 100)
            {
                lblHarfNotu1.Text = "AA";

            }
            else
            {
                MessageBox.Show("GEÇERLİ NOT ARALIĞINDA BİR DEĞER GİRİNİZ 0-100");
            }

            if (sonNot >= 50)
            {
                durum = "GEÇTİ";
            }
            else
            {

                durum = "KALDI";
            }
            lblDurum1.Text = durum;
            
            
            
        }

        private void lblOrtalama1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lblOrtalama_Click(object sender, EventArgs e)
        {

        }
    }
}
