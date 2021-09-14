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
    public partial class StringFonkisyonlar : Form
    {
        public StringFonkisyonlar()
        {
            InitializeComponent();
        }
        string ornekIfade = "bilge adam";
        private void e_Click(object sender, EventArgs e)
        {
            // Karşılaştırma yapılan değer alfabedeki sırasına göre karşılaştırılan değerden sonraysa 1 değer; aynıysa 0 değeri, önceyse -1 değeri alır.

            var sonuc = ornekIfade.CompareTo("abilge adam"); // 1
            var sonuc1 = ornekIfade.CompareTo("bilge adam"); // 0
            var sonuc2 = ornekIfade.CompareTo("zbilge adam");// -1
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //  içerme durumunu kontrol eder. true - false değeri döner
            var sonuc = ornekIfade.Contains("adam");
            if (sonuc)
            {
                MessageBox.Show("Bu değer Örnek ifade içinde geçiyor");
            }
            else
            {
                MessageBox.Show("Bu Değeri içirmiyor");
            }
            // ternary if
            var sonuc1 = ornekIfade.Contains("ilge ") ? "yer alıyor" : "yer almıyor";
            MessageBox.Show(sonuc1);
        }

        private void btnStartsEndWith_Click(object sender, EventArgs e)
        {
            //
            var sonuc = ornekIfade.StartsWith("bilge") ? MessageBox.Show("bilge ile başlıyor") : MessageBox.Show("Bu değer ile başlamıyor");
            var sonuc1 = ornekIfade.EndsWith("adam") ? MessageBox.Show("Adam ile bitiyor") : MessageBox.Show("Bu değer ile bitmiyor");

        }

        private void btnIndexOfLastIndexOf_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.IndexOf('a'); // = 6. karakterde a yı buldu ilk kez.
            var sonuc1 = ornekIfade.LastIndexOf("adam"); // = 6. karakterde ilk kez "adam" karakterini buldu 
            var sonuc2 = ornekIfade.IndexOf("adam"); // başta sonda aynı çıktı.
            var sonuc3 = ornekIfade.LastIndexOf("a");  // = 8 çünkü sondaki "a" harfinin yeri 8.karakterde.
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Remove(4); // 4. karakterden sonrasını sildik. =bilg
            var sonuc1 = ornekIfade.Remove(3, 4); //3-4. karakteri sildik gerisi gelmeye devam etti. = bildam
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Replace('a', 'e');
            // a'ların hepsini 'e'ile değiş dedik.
            var sonuc1 = ornekIfade.Replace("adam", "kadın"); // adam olan yeri kadın ile değiştircek.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //@bilgeadam.com lu bir mail adresi oluşturalım. türkçe karakter olmucak hepsi küçük olucak boşlukları almıcaz.
            var adSoyad = txtAdSoyad.Text;
            var donusturulen = adSoyad
                .ToLower()
                .Replace('ı', 'i')
                .Replace('ç', 'c')
                .Replace('ğ', 'g')
                .Replace('ü', 'u')
                .Replace('ö', 'o')
                .Replace('ş', 's')
                .Replace(" ", "");

            var mail = $"{donusturulen}@bilgeadam.com";
            txtSonuc.Text = mail;





        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Insert(0, "bil"); // bilge adamın en başına bil ekledik ve bilbilge adam oldu yenisi
            var sonuc1 = ornekIfade.Insert(5, "cik"); // bilgecik adam
            var sonuc2 = ornekIfade.Insert(ornekIfade.Length, "cık");// son ifadeye ekleme yolu bilge adamcık olucak
            var sonuc3 = ornekIfade
                .Insert(ornekIfade.Length, "@gmail.com").Replace(" ", "");
        }

        private void btnToLowerToUpper_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.ToLower();
            var sonuc1 = ornekIfade.ToUpper();
            // işletim sisteminizin dili ingilizce olursa program default olarak sistemdeki dili algılayarak buna göre çalışır, eğer spesifik olarak bir dile göre yazmanız gereken birşey varsa CultureInfo kullanarak ayar yapabilirsiniz.
            var sonuc2 = ornekIfade.ToLower(new System.Globalization.CultureInfo("en-US", false));
        }

        private void btnSubsstring_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Substring(5); // 5. ifadeden başla geri kalanı getir dedik. " adam" çıktı 5.karakter boşluk olduğu için onu da ekledi.
            var sonuc1 = ornekIfade.Substring(6, 4);// 6. ifadeden başla bize 4 karakter getir dedik o da "adam" çıktı.

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            var ayrilanlar = ornekIfade.Split(' '); // ayırma işlemi yapar
            var metin = "merhaba, benim adım, nur";
            var ayrilanlar1 = metin.Split(',' , ' '); // örneğin "merhaba" "benim" "adım" "nur" "," " " hepsini tek tek ayırdı ve 6 ayrı değer olarak getirdi.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kelimeSayisi = richTextBox1.Text;
            var kelimeleriBul = kelimeSayisi.Split(' ');


            //foreach (var item in kelimeleriBul)
            //{
            //    txtKelime.Text += item;

            //}
            txtKelime.Text = kelimeleriBul.Length.ToString();
            
        }

        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            //char[] harflerDizisi = new char[0];
            //foreach (var item in ornekIfade) ;
            //{
            //    Array.Resize(ref harflerDizisi, harflerDizisi.Length + 1);
            //    harflerDizisi[harflerDizisi.Length - 1] = harf;
            //}
            // kısa metod hali 
            char[]  harfler = ornekIfade.ToCharArray(); // ifadede ki tüm karakterleri tek tek ayırdık.
            char[]  harfler1 = ornekIfade.ToCharArray(6, 4); // 6 dan sonra gelen 4 tane karakteri yine tek tek ayırdık
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var metin = "            bilge adam         ";
            var bosluksuz = metin.Trim();
        }
        // lorem ipsum metninden belli bir kısmı textboxa girin ve kaç kelimeden oluştuğunu bulunuz.
    }
}
