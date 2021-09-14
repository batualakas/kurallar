using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_MatematikFonksiyonları
{
    public partial class MatematikFonksiyonları : Form
    {
        public MatematikFonksiyonları()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //pi sayısını alalım
            var piSayisi = Math.PI;

            // kullanıcıdan alının bir yarıçapa göre dairenin alanını hesaplayınız

            double yariCap = Convert.ToDouble(txtYariCap.Text);

            var alan = yariCap * yariCap * piSayisi;

            MessageBox.Show(alan.ToString());

            
            
            

        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            var mutlakDeger = Math.Abs(-143);
            var md1 = Math.Abs(-1.43);
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            // en yakın üst tam sayıya yuvarlama yapar.
            var tamSayi = Math.Ceiling(123.75); // decimal olarak algılamasını istiyorsak m ile belirtmemiz gerekir örn;
            var tamSayi1 = Math.Ceiling(123.75m);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // en yakın alt tam sayıya yuvarlar.
            var floorOrnegi = Math.Floor(124.75);  
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            // ondalıklı kısım 50' den büyükse üst tam sayıya yuvarlar küçükse alt.

            var roundOrnegi = Math.Round(123.51); // = 124
            var roundOrnegi2 = Math.Round(123.49); // = 123
            var roundOrnegi3 = Math.Round(43.1223647, 2); // = 43.12 --> 2 basamak yuvarla demek için ','den sonra 2 yazdık. ve artık virgülden sonraki 2 basamak nereye yakınsa oraya yuvarlıcak
            var roundOrnegi4 = Math.Round(43.1278956, 2); // = 43.13 oldu çünkü 43.12'ye değil 13 'e daha yakın.
            var roundOrnegi5 = Math.Round(2.50); // = 2 çünkü tam .50 ise sayılar alt kısma yuvarlanır.
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            // sayının tam kısmını almak için kullanılır. her hangi bir yuvarlama işlemi yapmaz,
            var sayi = Math.Truncate(4.75); // = 4;
            var sayi1 = Math.Truncate(4.33); // = 4;
            
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // dışarıdaki sayılar negatifse -1 , pozitifse 1, 0 ise 0 değerini döner
            var sayi = Math.Sign(-45); // = -1;
            var sayi1 = Math.Sign(0);  // =  0;
            var sayi2 = Math.Sign(5);  // =  1;

        }

        private void btnPOW_Click(object sender, EventArgs e)
        {
            // üs almak için kullanılır
            var ornek = Math.Pow(3, 5); // = 243;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            // kare kök alır
            var sayi = Math.Sqrt(4); // = 2 ;
            var sayi1 = Math.Sqrt(5986); // = 77.3692.... 
            
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            // verdiğimiz iki değerden hangisinin küçük ya da büyük olduğunu gösterir.
            var sonuc = Math.Min(11, 2); // = 2;
            var sonuc1 = Math.Max(11, 2);    // = 11;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sayi1 = Convert.ToInt32(txtSayi1.Text);
            var sayi2 = Convert.ToInt32(txtSayi2.Text);
            var sayi3 = Convert.ToInt32(txtSayi3.Text);
            var sonuc1 = Math.Max(sayi2, sayi1);
            var sonuc2 = Math.Max(sonuc1, sayi3);
            if(sayi1==sayi2)
            {
                MessageBox.Show($"Birbirine eşit iki sayı değeri girmeyin");
                return;
            }
            if(sayi3==sayi1)
            {
                MessageBox.Show($"Birbirine eşit iki sayı değeri girmeyin");
                return;
            }
            if (sayi3 == sayi2)
            {
                MessageBox.Show($"Birbirine eşit iki sayı değeri girmeyin");
                return;
            }

            MessageBox.Show(sonuc2.ToString());
            
        }
    }
}
