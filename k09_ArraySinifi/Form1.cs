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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Array Sınıfı : Dizilerle ilgili bazı işlemleri(Kopyalama yeniden boyutlandırma sıralama vb) yapmamıza yardımcı olan metotları içerir.




        */
        string[] isimler = { "Orkun", "Batu", "ömer", "leyla", "batuhan", "çiğdem", "bahar", "serdar", "anıl", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" };
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Copy 
            // Bu sınıftaki tüm öğrencilerin isimlerini bir dizi olarak tanımlayınız ve sonrasında onlineKatılımcılar ve fizikselKatılımcılar isimli iki dizi olarak buraya kopyalayınız.

            string[] fizikselKatilimcilar = new string[9];
            Array.Copy(isimler, fizikselKatilimcilar, 9);
            string[] onlineKatilimcilar = new string[6];
            Array.Copy(isimler, 9, onlineKatilimcilar, 0, 6);

         


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // temizlediği elemanların yerine null atar.
            Array.Clear(isimler, 2, 3);
            //Tümünü temizlemek isteseydik.
            Array.Clear(isimler, 0, isimler.Length);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // IndexOf : Eğer aradığınız eleman dizi içinde geçmiyorsa -1 değerini döner. bulursa da elemanın index değerini döner. 
            var bulunanIndex = Array.IndexOf(isimler, "batuhan");
            if (bulunanIndex != 1)
            {
                MessageBox.Show($"Aradığınız İsim {bulunanIndex}.indexte bulundu");
            }
            else
            {
                MessageBox.Show("Dizi içinde aradığınız eleman bulunmuyor!!");
            }
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // 
            var bulunanIndex = Array.LastIndexOf(isimler, "batuhan");
            if (bulunanIndex !=-1 )
            {
                MessageBox.Show($"Aradığınız İsim {bulunanIndex}.indexte bulundu");
            }
            else
            {
                MessageBox.Show("Dizi içinde eleman bulunmuyor");
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            // Diziyi tam tersi şekilde sıralar. Son sıradaki ilk başa gelir ve ona göre devam eder.
            Array.Reverse(isimler);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // a'dan z'ye yada 0'dan 9'a doğru artan sıralama yapar.
            Array.Sort(isimler);
            Array.Reverse(isimler);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            // yeniden boyutlandırma yapar.
            Array.Resize(ref isimler, 20);
            
        }
    }
}
