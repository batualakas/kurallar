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
    public partial class ForDongusu : Form
    {
        /*
         Döngüler
        Tekrarlı olarak yapılması istenen işlemler varsa belli bir sayıda bu işlemleri tekrar eden yapılardır.

         1-) For: Bir başlangıç değeri, bir bitiş değeri ve artış miktarı belirtilir.
        for(int i = 0 ; i < 10 ; i ++)
        {
        tekrarlı olarak yapılmasını istediğiniz kodlar
        }
         
         2-) While:
         3-) do-while: 
         4-) foreach:
         
         
         
         
         
         */


        public ForDongusu()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // 1'den 100'e kadar olan sayıları listeleye ekleyiniz.
            // object veri tipi : tüm veri tiplerini kapsar.
            // listbox'a yeni eleman eklemek için :
            //lstSonuc.Items.Add("ankara");
            //lstSonuc.Items.Add("1");
            //lstSonuc.Items.Add("false");

            for (int i = 1; i<=100; i++) 
            {
                lstSonuc.Items.Add(i);
            }
        }

        private void btnGeriye_Click(object sender, EventArgs e)
        {
            for (int a = 100; a > 0; a--)
            {
                lstSonuc.Items.Add(a);
            }
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            for (int b = 10;  b<= 50; b= b +3 )
            {
                lstSonuc.Items.Add(b);

            }
        }

        private void button1_Click(object sender, EventArgs e)
            // A'dan Z'ye kadar olan harfleri yazdırınız.
            // for (char 'A') ASCII tablosunda buna karşılık gelen bir sayı değeri vardır. 
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                lstSonuc.Items.Add($"sembol -> {i} ASCII -> {Convert.ToInt32(i)}");
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 20; i <= 100;  i = i+1)
            {
                if (i %2==0)
                {
                    lstSonuc.Items.Add(i);
                }
                

                
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=100; i=i+1)
            {
                if(i %3==0)
                {
                    lstSonuc.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sonuc = 0;
            
            for (int i = 1; i <= 10; i = i + 1)
               
            {
                sonuc=sonuc+i;
                lstSonuc.Items.Add(sonuc);
                
                
            }
            MessageBox.Show(sonuc.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var toplam = 0;
                for (int i = 10; i <=30; i= i+1)
            {
                if(i%2==1)
                {
                    toplam = toplam + i;
                    lstSonuc.Items.Add($"Tek sayı {i} Toplamı {toplam}");
                }
            }
            MessageBox.Show(toplam.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 2000-2020 arasındaki yılları combo boxa yazdıralım sonrasında comboboxtan bir yıl seçip ve textbox'ta gösterelim.
            for (int i = 2000; i <=2020; i= i+1)
            {
                cmbYillar.Items.Add(i);
            }
            
        }

        private void txtSecilenYil_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbYillar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sectigiYil = "";
            sectigiYil = cmbYillar.SelectedIndex.ToString();
            lstSonuc.Items.Clear();
            if (cmbYillar.SelectedIndex != - 1  )
            {
                var secilenYil = cmbYillar.SelectedItem;
                txtSecilenYil.Text = secilenYil.ToString();
                sectigiYil = "Bu sene iyiydi";
                lstSonuc.Items.Add(sectigiYil);
                
            }
            else if(cmbYillar.SelectedIndex == 8)
            {
                sectigiYil = "Bu sene kötüydü";
                txtSecilenYil.Text = cmbYillar.SelectedItem.ToString();
                lstSonuc.Items.Add(sectigiYil);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 1-10 arası random sayı üretip listboxa ekliyoruz.
            // listbox'ta bir sayının sadece bir kez görünmesini istersek : 
            Random rnd = new Random();
            
            
            for(int i=0;  i<10; i++ )
            {
                var rastgeleSayi = rnd.Next(1, 25);

                if(lstSonuc.Items.Contains(rastgeleSayi)== false)
                {

                lstSonuc.Items.Add(rastgeleSayi);
              
                }
                else
                {
                    MessageBox.Show("Bu sayı daha önce eklenmişti" + rastgeleSayi);
                }
                
            }

           
            



        }

        private void button8_Click(object sender, EventArgs e)
        {
            //1-10 arasındaki sayılar için çarpım tablosu oluşturun.
            for (int i = 1; i <= 10; i++)
            {
                lstSonuc.Items.Add($"{i}'ler Tablosu");
                for (int n = 1; n <= 10; n++)
                {
                    lstSonuc.Items.Add($"{i}x{n}={i * n}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Yanyana 10 tane "x" yazdırmak
            string x1 = "x";
            for(int i=0; i<11; i++)

            {
                for (int n = 0; n < 11 ; n++)
                {
                    lblYaziTahtasi.Text += "X";
                }
                
               
            }

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Döngüde bazı durumlarda o anki iterasyonun atlanıp sonraki iterasyonlardan devam etmesini sağlar.

            // 1-30'a kadar sayıları ekrana yazdırmak istiyoruz ancak 8'in katı olan sayıların yazılmasını istemiyoruz.

            for(int i =1; i <=30; i ++)
            {
                if (i % 8 == 0)
                {
                    continue;
                }
                lstSonuc.Items.Add(i);
            }
        }

        private void btnBreakKurali_Click(object sender, EventArgs e)
        {
            // belli bir koşul sağlandığında döngünün çalışmasını durdurmak için break kullanılır.
            // döngüden çıktıktan sonra kodlar varsa onlar çalışır. çünkü break komutu sadece döngünün sonlanmasını sağlar
           // 1-30 arasındaki sayıları yazdıralım, 9 un katı olan ilk sayıyı bulduğunda döngünde çıkılsın.
            for (int i = 1; i <= 30; i++)
            {
                if (i  %4 == 0)
                {
                    break;
                }
                lstSonuc.Items.Add(i);
            }

            MessageBox.Show("döngüden çıkıldı");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return komutu döngüden ve içinde bulunulan metottan çıkılması için kullanılır. döngüden sonra kod parçaları varsa bunlar çalışmaz.
            for (int i = 1; i <= 30; i++)
            {
                if (i % 4 == 0)
                {
                    return;
                }
                lstSonuc.Items.Add(i);
            }
            MessageBox.Show("döngüden çıkıldı. mesaj kutusu açılmayacak ve buradaki mesaj görünmeyecek.");
        }
    }
}

