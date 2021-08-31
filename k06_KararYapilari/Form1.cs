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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
KARAR YAPILARI : Programın akışını belli bir koşula göre yönlendirmek istediğimiz durumlarda kullanılır.
1. if-else
2. switch-case
3. ternary if
*/







        private void Form1_Load(object sender, EventArgs e)
        {
            /* 1. IF-ELSE KULLANIMI */
            // if (kosul)
            // {
            // koşul sağlandığı zaman çalışacak kodlar(koşulun true olması)
            // }


            //Örnek
            // dışarıdan alınan bir değerin "nur " değerine eşit olması durumunda çalışan ve ekrana girilen değer NUR yazan uygulamayı yapalım.

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            var girilenAd = txtAd.Text;

            if (girilenAd == "nur")
            {
                MessageBox.Show("Girdiğiniz değer Nur'dur.");
            }
            // Dışarıdan alınan değer Nur ise giriş başarılı değilse giriş hatalı bilgilerinin kontrol ediniz uyarısı versin.

            if (girilenAd == "nur")
            {
                MessageBox.Show("Giriş Başarılı ':)' ");
            }
            else
            {
                MessageBox.Show("Giriş Hatalı! Bilgilerinizi Kontrol ediniz");
            }

            // Kullanıcıdan alınan sayı 0 - 50 arasında ise kaldınız; 50-100 arasında ise geçtiniz, bunlar dışında bir şey girilmişse uygun aralıkta değer girmediniz yazdıralım
        }

        private void btnGectiKaldi_Click(object sender, EventArgs e)
        {
            var girilenDeger = txtNot.Text;
            var sayi = Convert.ToInt32(girilenDeger);

            if (sayi >= 50 && sayi <= 100)
            {
                MessageBox.Show("Geçtiniz Harika!");
            }
            else if (sayi < 50 && sayi >= 0)
            {
                MessageBox.Show("Kaldınızzzz :(");
            }
            else
            {
                MessageBox.Show("0-100 değerleri arasında bir sayı giriniz");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTekCift_Click(object sender, EventArgs e)


        {
            try
            { 
            var deger = txtTekCift.Text;
            var yeniDeger = Convert.ToInt32(deger);
            var yeniDeger1 = Convert.ToDouble(deger);



            if (yeniDeger / 2 == yeniDeger1 / 2)
            {
                MessageBox.Show("Çift");
            }
            else
            {
                MessageBox.Show("Tek");
            }

        }
            catch 
            {
                MessageBox.Show("Sayısal bir değer gir" );
            }
        
        }

        // Kullanıcıdan alınan sayının tek mi çift mi olduğunu bularak ekran bilgi veren uygulamayı yazınız

    }

}
