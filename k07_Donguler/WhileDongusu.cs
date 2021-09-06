using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k07_Donguler
{
    public partial class WhileDongusu : Form
    {
        /*
        While Döngüsü : Bellir bir koşul sağlandığı sürece döngü çalışmaya devam eder. döngü çıkma kriterini unuttuğunuzda sonsuz döngüye girer.

        while(koşul)
        {
        Tekrar etmesini istediğiniz kodlar.
        !! Durdurma kriterini unutmayın!!
        }
            

        */
        public WhileDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1'den 100'e kadar sayıları while kullanarak listeye yazdırınız.

            int i = 1;

            while (i <= 100)

            {
                lstSonuc.Items.Add(i);
                i++;
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            // listboxa ürettiğimiz 10 tane sayıyı ekleyelim. ancak listeden olan bir sayı tekrardan eklenmesin.
            //Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    var rastgeleSayi = rnd.Next(1, 5);
            //    if (lstSonuc.Items.Contains(rastgeleSayi) == false )
            //    {
            //        lstSonuc.Items.Add(rastgeleSayi);
            //    }
            //}

            // listboxun içinde kesin olarak 10 tane rastgele sayı olmasını istiyoruz.
            // bu döngü kaç kez döndü? saydırıp mesaj boxa yazınız.

            Random rnd = new Random();
            int sayac = 1;
            
            
            while (lstSonuc.Items.Count < 10)
            {
                var rastgeleSayi = rnd.Next(1, 11);
                if (!lstSonuc.Items.Contains(rastgeleSayi))
                {
                    lstSonuc.Items.Add(rastgeleSayi);
                }
                sayac++;
            }
            MessageBox.Show($"sayı dönme sayısı {sayac}");
        }

        private void lstSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
