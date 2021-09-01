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
    //Kullanıcıdan alınan ürün bilgisine göre yönlendirecek reyonu gösteren bir uygulama yapınız.
    // Bilgisayar, cep telefonu, minibook yazarsa "teknoloji reyonu".
    // parfüm, deodorant, şampuan yazarsa "kişisel bakım reyonu".
    // domates, biber, patlıcan yazarsa "sebze reyonu".
    // bunlar dışında birşey yazılırsa "ürün bulunmamaktadır" yazıcak uygulamayı yapınız.
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnUrunNerde_Click(object sender, EventArgs e)
        {
            var UrunAdi = txtUrunAdi.Text.ToLower();
            var UrunYeri = "";

            if (UrunAdi == "bilgisayar" || UrunAdi == " cep telefonu" || UrunAdi== "minibook" )
            {
                UrunYeri = "Teknoloji Reyonu";
            }
            else if ( UrunAdi == "parfüm" || UrunAdi == "deodorant" || UrunAdi == "şampuan")
            {
                UrunYeri = "Kişisel Bakım Reyonu";
            }
            else if ( UrunAdi == "domates" || UrunAdi == "biber" || UrunAdi == "patlıcan")
            {
                UrunYeri = "Sebze Reyonu";
            }
            
            
                
            
            else
            {
                UrunYeri = "Geçerli bir ürün giriniz";
            }
            txtUrununYeri.Text = UrunYeri;

        }

        private void txtUrununYeri_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
