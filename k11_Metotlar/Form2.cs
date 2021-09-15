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
    public partial class Form2 : Form
    {
        //başlangıç ve bitiş kullanıcıdan alınarak o aralıktaki sayıları int dizisi olarak döndüren overload yazınız
        public Form2()
        {
            InitializeComponent();
        }
        #region Sayilar
        private int[] Sayilar()
        {
            int[] sayilar = new int[100];
            for (int i = 1; i < 101; i++)
            {
                sayilar[i - 1] = i;
            }
            return sayilar;
        }
        #region Ornek2
        private void Ornek2(int sayi1)
        {
            while (sayi1 >= 1)
            {
                lstSonuc.Items.Add(sayi1);
                sayi1--;
            }

        }
        #region ornek3
        private void ornek3(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                while (sayi1 >= sayi2)
                {
                    lstSonuc.Items.Add(sayi1);
                    sayi1--;
                }
            }
            else
            {
                while (sayi2 >= sayi1)
                {
                    lstSonuc.Items.Add(sayi2);
                    sayi2--;
                }


            }



        }
        #region DiziGetir
        private int[] DiziGetir(int baslangıc, int bitis)
        {
            int[] sayilar = new int[0];
            for (int i = baslangıc; i <= bitis; i++)
            {
                Array.Resize(ref sayilar, sayilar.Length + 1);
                sayilar[sayilar.Length - 1] = i;
            }
            return sayilar;
        }
        #region MaillerAyrıştır
        private string[] MailleriAyristir(string mail)
        {
            var mailler  = mail.Split(';', ',');
            return mailler;
                
        }
        #endregion
        #endregion
        #endregion


        #endregion

        #endregion

        private void btnGoster_Click(object sender, EventArgs e)
        {
            var sayilar = Sayilar();
            foreach (var sayi in sayilar)
            {
                lstSonuc.Items.Add(sayi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var sayi1 = Convert.ToInt32(txtOrnek2.Text);
            Ornek2(sayi1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sayi1 = Convert.ToInt32(txtOrnek31.Text);
            var sayi2 = Convert.ToInt32(txtOrnek32.Text);
            ornek3(sayi1, sayi2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var baslangic = Convert.ToInt32(txtOrnek41.Text);
            var bitis = Convert.ToInt32(txtOrnek42.Text);
            var sayilar = DiziGetir(baslangic, bitis);
            foreach (var sayi in sayilar)
            {
                lstSonuc.Items.Add(sayi);
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //txtmailler textboxuna ; ve , ile birden fazla mail girişi yapılacak
            // bu mailleri ';' ',' sembollerine göre ayırarak geri döndüren bir metot yazınız.
            // metot adı mailleriayrıştır yapalım.
            var mailAdresi = txtMailler.Text;
            
            var sonuclar = MailleriAyristir(mailAdresi);
            lstSonuc.Items.AddRange(sonuclar);
            
        }
    }
}
