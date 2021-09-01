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
    public partial class Form5 : Form
    {
        public Form5()
        //kullanıcı dışarıdan kaç adet kitap sipariş edeceği bilgisini girsin
        //eğer sipariş adedi 20 den küçükse birim fiyat üzerinden satış yapılsın. 20 <x < 50 ise  birim fiyat üzerinden % 5 indirim uygulansın. 50 < x < 100 ise %10 100 < x < 200 %20, 200 + ise %25 indirim yapılsın kullanıcıya ödemesi gerek tutarı yazınız. birim fiyatı = 10 tl
        {
            InitializeComponent();
        }

        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            var siparis = txtSiparisAdeti.Text;
            var siparisAdeti = Convert.ToInt32(siparis);
            var birimFiyat = 10;
            var tutar = birimFiyat * siparisAdeti;
            var toplamTutar = Convert.ToDouble(tutar);
            double indirimTutari = 0;
            double indirimliTutar = 0;
            
            


            if (siparisAdeti < 20)
            {
                indirimliTutar= toplamTutar;
            }
            else if (siparisAdeti >= 20 && siparisAdeti < 50)
            {
                indirimliTutar = toplamTutar * 0.95;
            }
            else if (siparisAdeti >= 50 && siparisAdeti < 100)
            {
                indirimliTutar = toplamTutar * 0.90;
            }
            else if (siparisAdeti >= 100 && siparisAdeti < 200)
            {
                indirimliTutar = toplamTutar * 0.80;
            }
            else if (siparisAdeti > 200)
            {
                indirimliTutar = toplamTutar * 0.75;
            }
            indirimTutari = toplamTutar - indirimliTutar;
            txtToplamTutar.Text = Convert.ToString(indirimliTutar);
            txtİndirimsiz.Text = Convert.ToString(toplamTutar);
            txtKazanc.Text = Convert.ToString(indirimTutari);
        }
    }
}
