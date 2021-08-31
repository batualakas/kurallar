using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k05_HataYonetimi
{
    public partial class Form1 : Form
    {

        /*
         Hata türleri
        1. Derleme Zamanı hataları (syntax hataları) : error listte görünür. düzeltilmeden program derlenmez.

        2. Çalışma Zamanı Hataları ( Run time hataları) :

        3. Mantıksal Hatalar ( Logical Errors ) : Debug Yaparak Bulunabilir.
        Önce Breakpoint konulur.
        Proje çalıştırılır f5 ile 
        f10 ile adım adım ilerleyerek çalışma zamanında kodlar kontrol edilir.

         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // dışarıdan bir sayıya ulaşmam lazım
                var girilenSayi = txtSayiKutusu.Text;
                // Covert etmemiz lazım
                var sayi = Convert.ToInt32(girilenSayi);
                // karesini alınız
                var karesi = sayi * sayi;
                // Kullanıcıya göster
                lblSonuc.Text = karesi.ToString();
                // try kodu
                // hata alması muhtemel kodları yazılır.
                // catch kodu
                // çalışma zamanı hatası oluşursa catch blokları düşer
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayı gir SAYIIIII");
                
            }


        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSayiKutusu_TextChanged(object sender, EventArgs e)
        {

        }
        // Kullanıcdan bir sayı alınız ve karesini hesaplayarak tekrar gösteriniz

    }
}
