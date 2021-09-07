using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnElemans_Click(object sender, EventArgs e)
        {
            //öncelikle bir dizi tanımlayalım sonrasında dizinin elemanlarını  hem tek tek hemde tek seferde listeye ekleyelim.
            string[] iller = { "Ankara", "Eskişehir", "Adana", "Erzincan", "Niğde" };
            //elemanları for ve foreach döngülerini kullanarak tek tek ekleyebiliriz.
            // ÖRNEKLERİ AŞŞAĞIDA.
            //lstSonuc.Items.Add(iller[0]);
            //lstSonuc.Items.Add(iller[1]);
            //lstSonuc.Items.Add(iller[2]);
            //for (int i = 0; i < iller.Length; i++)
            //{
            //    lstSonuc.Items.Add(iller[i]);
            //}
            //foreach ( var il in iller)
            //{
            //    lstSonuc.Items.Add(il);
            //}
            //TEK SEFERDE YAPMAK İÇİN ;


            lstSonuc.Items.AddRange(iller);






        }

        private void btnCiftleriEkle_Click(object sender, EventArgs e)
        //1 den 10'a kadar dizi oluşturunuz, sonrasında listeye çift olan sayıları ekleyiniz
        {

        }

        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    lstCiftSayilar.Items.Add(sayi);
                }

                else
                {
                    lstTekSayilar.Items.Add(sayi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 20 elemanlı bir boş dizi oluşturunuz, sonrasında for döngüsü ile 1'den 20'ye kadar olan sayıları diziye ekleyiniz.
            //sonrasında dizideki elemanların hepsini lstSonuc listesine tek seferde ekleyelim.

            var sayilar = new int[20];
            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = i + 1;
            }

            foreach (var sayi in sayilar)
            {

                lstSonuc.Items.Add(sayi);
            }

        }

        private void btnDizininSonElemaniAl_Click(object sender, EventArgs e)
        {
            //iller dizisi tanımlayalım içine 5 tane il ekleyelim, sonrasında son elemanı seçip mboxda gösterelim
            string[] iller = { "Ankara", "FeelsBatMAN", "Adana", "İstanbul", "İzmir" };
            var sonEleman = iller[iller.Length - 1];

            lstSonuc.Items.Add(iller);



        }
        string[] isimler = { "batu", "eray", "orkun", "mustafa", "batuhan", "ömer", "bahar", "çiğdem", "yasemin", "leyla", "utku", "serdar", "kaan" };





        private void button2_Click(object sender, EventArgs e)
        {
            // global olarak isimler dizisi oluşturunuz.
            // butona her bastığımızda rastgele bir index oluştursun ve bu indexdeki isim listboxa eklensin.
            Random rnd = new Random();
            var rastgeleSayi = rnd.Next(0, isimler.Length);
            var rastgeleSecilenEleman = isimler[rastgeleSayi];

            if (!lstSonuc.Items.Contains(rastgeleSecilenEleman))
            {
                lstSonuc.Items.Add(rastgeleSecilenEleman);
            }
            else
            {
                MessageBox.Show($"Bu isim Daha önce geldi gibi bi bak {rastgeleSecilenEleman}");

            }
            if (isimler.Length == lstSonuc.Items.Count)
            {
                btnRastgeleElemanFalan.Enabled = false;
                MessageBox.Show($"Doldu Hocam Doldu İsim Yazma Hakkımız Doldu YAPMAA");

            }








        }
        int[] rastgeleSayilar = new int[7];
        private void btnElemanlariTopla_Click(object sender, EventArgs e)
        {
            // butona her bastığımızda dizideki 

            Random rnd = new Random(); // instance : nesneden kopya almak demektir.
            for (int i = 0; i < 7; i++)
            {
                var rastgeleSayi = rnd.Next(0, 101);
                rastgeleSayilar[i] = rastgeleSayi;
            }





        }
        int sayac = 0;
        int toplam = 0;

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (sayac < rastgeleSayilar.Length)
            {
                var secilenEleman = rastgeleSayilar[sayac];
                lstSonuc.Items.Add(secilenEleman);
                toplam += secilenEleman;
                sayac++;
                // this içinde bulunduğumuz classı temsil eder.
                this.Text = toplam.ToString();
                //this.Text formun başlığı .

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        
        
        private void btnAyirmaButonu_Click(object sender, EventArgs e)
        {
            // textboxa yazılan metini alıp sesli harflerini ve sessiz harflerini ayırarak lblSesliler lblSessizler'de gösterelim.
            // 8 tane sesli harfi tanımladıktan sonra metinin her bir harfini tek tek inceleriz. eğer gelen harf sesliHarfler dizisinde yer alıyorsa sesli, almıyorsa sessiz label'ına eklenir.

            // string : karakterler dizisidir.
            char[] sesliHarfler = {'a','e','ı','i','o','ö','u','ü'};
            var girilenCumle = "";
            girilenCumle = txtCumleler.Text;
            foreach (var harfler in girilenCumle)
            {
                if (sesliHarfler.Contains(harfler))
                {
                    lblSesliler.Text += harfler.ToString()+",";
                }    

                else
                {
                    lblSessizler.Text += harfler.ToString()+",";
                }
            }
            
            
        }
        
        private void txtCumleler_TextChanged(object sender, EventArgs e)
        {
            

        }
    }

}




