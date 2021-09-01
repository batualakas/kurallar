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
    public partial class Form6 : Form
    /* switch-case : Eşitlik kontrolü yapılması gerektiği durumlarda bu yapı kullanılabilir. if'e göre daha hızlıdır çünkü eşitlik durumunu kontrol ederken diğer koşulları tek tek incelemez, direkt olarak koşulun sağlandığı case'e gider. 
     * örnek: 
      switch(değer)
      {
      case eşitlik durumu :
     // yapılacak işlemler;
     break;

      }
       */
    {
        public Form6()
        //Kullanıcıdan mevsimleri aldıktan sonra o mevsimdeki ayları gösteren bir uygulama yapınız...
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // BİRİNCİ YÖNTEM
            //var girilenMevsim = txtMevsim.Text.ToLower();
            //var aylar = "";
            //if (girilenMevsim == "kış")
            //{
            //    aylar = "aralık-ocak-şubat";
            //}
            //else if(girilenMevsim== "ilkbahar")
            //{
            //    aylar = "mart-nisan-mayıs";
            //}
            //else if ( girilenMevsim== "yaz")
            //{
            //    aylar = "haziran-temmuz-ağustos";

            //}
            //else if (girilenMevsim == "sonbahar")
            //{
            //    aylar = "eylül-ekim-kasım";
            //}
            //else
            //{
            //    aylar = "böyle bir mevsim yok";
            //}
            //txtAylar.Text = aylar;
            var girilenMevsim = txtMevsim.Text.ToLower();
            var aylar = "";
            switch (girilenMevsim)
            {
                case "kış":
                    aylar = "aralık-ocak-şubat";
                    break;
                case "ilkbahar":
                    aylar = "mart-nisan-mayıs";
                    break;
                case "yaz":
                    aylar = "haziran-temmuz-ağustos";
                    break;
                case "sonbahar":
                    aylar = " eylül-ekim-kasım";
                    break;
                default:
                    aylar = "böyle bir mevsim yok";
                    break;

            }

            MessageBox.Show(aylar);
            txtAylar.Text = aylar;





        }

        private void btnMevsim_Click(object sender, EventArgs e)
            
        {
            var yeniAy = txtYeniAy.Text;
            var Mevsim = "";
            switch (yeniAy)
            {
                case "ocak":
                case "şubat":
                case "aralık":

                    Mevsim = "kış";
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    Mevsim = "ilkbahar";
                    break;
                case "haziran":
                case "temmuz":
                case "ağustos":
                    Mevsim = "yaz" ;
                    break;
                case "eylül":
                case "ekim ":
                case "kasım":
                    Mevsim ="sonbahar";
                    break;
                default:
                    Mevsim="böyle bir ay yok";
                    break;

                    
            }
            txtYeniMevsim.Text = (Mevsim);
        }
    }
}
