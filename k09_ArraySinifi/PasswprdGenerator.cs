using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k09_ArraySinifi
{
    public partial class PasswprdGenerator : Form
    {
        public PasswprdGenerator()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            // Kullanıcdan kaç karakterli bir şifre oluşturmak istediğini alalım sonrasında şifrenin içinde hangi tip karakter geçmesini istediğini soralım (büyük,küçük harf, rakam ve ya sembol) en az bir seçim yapmak zorunda.
            // her biri için dizi oluşturalım.
            if(string.IsNullOrEmpty(txtKarakterSayisi.Text))
            {
                MessageBox.Show("Karakter Sayısını Boş Geçmeyiniz.");
                return;
            }
            var karakterSayisi = Convert.ToInt32(txtKarakterSayisi.Text);
            if(!(chbBuyukHarf.Checked|| chbKucukHarf.Checked||chbRakam.Checked|| chbSembol.Checked))
            {
                MessageBox.Show("Aşko En az bir seçeneği işaretle");
                return;
            }

            var buyukHarfler = new char[0];
            var kucukHarfler = new char[0];
            var rakamlar = new char[0];
            var semboller = new char[0];
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Array.Resize(ref buyukHarfler, buyukHarfler.Length + 1);
                buyukHarfler[buyukHarfler.Length - 1] = i;
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                Array.Resize(ref kucukHarfler, kucukHarfler.Length + 1);
                kucukHarfler[kucukHarfler.Length - 1] = i;
            }
            for (char i = '0'; i <= '9'; i++)
            {
                Array.Resize(ref rakamlar, rakamlar.Length + 1);
                rakamlar[rakamlar.Length - 1] = i;
            }
            for (char i = '!'; i <= '/'; i++)
            {
                Array.Resize(ref semboller, semboller.Length + 1);
                semboller[semboller.Length - 1] = Convert.ToChar(i);
            }

            Random rnd = new Random();
            
            //if (hangiDizidenSecimYapilsin == 0)
            //{
            //    //buyuk harflerden rastgele bir şey seçip şifrenin içine ekleyeceğiz.
            //}
            var sifre = "";
            //for (int i = 0; i < karakterSayisi; i++)
            while (sifre.Length < karakterSayisi)
            {
                var hangiDizidenSecimYapilsin = rnd.Next(0, 4); // 0,1,2,3
                switch (hangiDizidenSecimYapilsin)
                {
                    case 0:
                        {
                            // buyuklerden sec
                            if (chbBuyukHarf.Checked)
                            {
                                var rastgeleIndex = rnd.Next(0, buyukHarfler.Length);
                                var secilenHarf = buyukHarfler[rastgeleIndex];
                                sifre += secilenHarf;

                            }
                            break;
                        }
                    case 1:

                        //kucuklerden sec
                        if (chbKucukHarf.Checked)
                        {
                            var rastgeleIndex1 = rnd.Next(0, kucukHarfler.Length);
                            var secilenHarf1 = kucukHarfler[rastgeleIndex1];
                            sifre += secilenHarf1;
                        }
                        break;

                    case 2:
                        //rakamlardan sec
                        {
                            if (chbRakam.Checked)
                            {
                                var rastgeleIndex = rnd.Next(0, rakamlar.Length);
                                var secilenRakam = rakamlar[rastgeleIndex];
                                sifre += secilenRakam;
                            }
                            break;
                        }
                    case 3:
                        //sembollerden sec
                        {
                            if (chbSembol.Checked)
                            {
                                var rastgeleIndex = rnd.Next(0, semboller.Length);
                                var secilenRakam = semboller[rastgeleIndex];
                                sifre += secilenRakam;
                            }
                            break;
                        }

                }
            }
            lstSifreler.Items.Add(sifre);






        }
    }
}
