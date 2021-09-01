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
    public partial class Form8 : Form
    {

        /* Ternary- if 
        if(koşul)
        {
        // koşul true çalışacaklar
        }
        else
        {
        // koşul false ise çalışacaktır
        }

            // Karşılaştırma Sonucunun bir değişkene atanması gerekir.
        // birden fazla kod yazılamıyor.

            var degisken = kosul ? true ise çalışacak kod : 
                                   false ise çalışacak kod;
        */
        public Form8()
        {

            InitializeComponent();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            //girilen sayının tek mi çift mi olduğunu bulup gösteren uygulamayı yazınız.
            var girelenDeger = txtSayi.Text;
            var sayi = Convert.ToInt32(girelenDeger);

            //var sonuc = "";
            //if (sayi % 2 == 0)
            //{
            //    sonuc = "çift";
            //}
            //else
            //{
            //    sonuc = "Tek";
            //}
            //txtSonuc.Text = sonuc;

            var sonuc = (sayi % 2 == 0) ? "çift" : "tek";

            txtSonuc.Text = sonuc;
        }
    }
}

