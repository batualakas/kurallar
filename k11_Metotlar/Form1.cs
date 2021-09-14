using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metotlar
{
    public partial class txtSayi : Form
    {
        /*
         Metotlar;
        Kod tekrarını önler.
        Kodların daha düzenli tutulmasını ve daha anlaşılır olmasını sağlar.
         1-) Parametre almayan geriye değer döndürmeyen metotlar.
         2-) Parametre alan geriye değer dönürmeyen metotlar.
         3-) Parametre almayan geriye değer döndüren metotlar.
         4-) Parametre alan ve geriye değer döndüren metotlar.

        erisimBelirleyici gerideğerdöndürmedurumu MetotAdi (varsa parametreler)
        {
        Metodun yapmasını istediğimiz işlemler.
        }

        -- eğer metot geriye değer döndürmeyecekse void ile işaretlenir.
         
        Metot adı tanımlarken uyulacak kurallar:
        -Pascal Case notasyonu ile tanımlama yapılır.
        -Emir kipleri ile tanımlama yaparız.
         */
        #region Metotlar
        #region Geriye değer Döndürmeyen (void metotlar)

        private void adSoyad()
        {
            MessageBox.Show("orkun ince");
        }
        private void adSoyad(string ad, string soyad)
        {
            MessageBox.Show($"{ad} {soyad}");
        }
        #endregion
        // geriye değer döndüren metotlar
        #region Geriye Değer Döndüren Metotlar
        private string AdSoyadGetir()
        {
            var isim = "Rabia Nur Öztürk";
            return isim;
        }
        private int Toplam(int sayi1, int sayi2)
        {
            var toplam = sayi1 + sayi2;

            return toplam;
        }
        // string 3 tane parametre alsın, sonuç olarak int döndürsün.
        private int ornek(string st1, string st2, string st3)
        {
           
            
                var sayi1111 = Convert.ToInt32(st1);
                var sayi1112 = Convert.ToInt32(st2);
                var sayi1113 = Convert.ToInt32(st3);
                var toplam123 = sayi1111 + sayi1112 + sayi1113;
                return Convert.ToInt32(toplam123);
            
            
        }
        #endregion
        #endregion



        public txtSayi()


        {
            InitializeComponent();
            //adSoyad();
            //adSoyad("batu" ,"alakaş");

        }

        private void btnAdSoyadGoster_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            adSoyad(ad, soyad);
        }

        private void txtYazdir_Click(object sender, EventArgs e)
        {
            var sonuc = AdSoyadGetir();

            txtAd.Text = sonuc;

        }

        private void btnToplat_Click(object sender, EventArgs e)
        {
            var sayi11 = txtSayi1.Text;
            var s1 = Convert.ToInt32(sayi11);
            var sayi22 = txtSayi2.Text;
            var s2 = Convert.ToInt32(sayi22);
            var toplam1 =Toplam(s1,s2);
            lblToplam.Text = toplam1.ToString();
            
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            var sayi111 = txtSayi11.Text;
            var s111 = Convert.ToInt32(sayi111);
            var sayi222 = txtSayi22.Text;
            var s222 = Convert.ToInt32(sayi222);
            var sayi333 = txtSayi33.Text;
            var s333 = Convert.ToInt32(sayi333);
            var toplam12 = ornek(s111.ToString(), s222.ToString(), s333.ToString());
            txtSonucuGoster.Text = toplam12.ToString();
        }
    }
}
