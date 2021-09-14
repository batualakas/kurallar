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
    public partial class DateTimeFonksiyonlar : Form
    {
        public DateTimeFonksiyonlar()
        {
            InitializeComponent();
        }

        DateTime simdikiZaman = DateTime.Now;
        private void btnSimdikiZaman_Click(object sender, EventArgs e)
        {
            // d : day
            // M : Month
            // y : year
            // m : minute
            // direkt böylede kullanılır
             lblSimdikiZaman.Text = simdikiZaman.ToString();
           //böyle tek tek de belirtemiliriz hangi tür zaman istediğimizi
           lblSimdikiZaman.Text = simdikiZaman.ToString("dd/MMMM/yyyy HH:mm:ss");

        }

        private void btnUzunZaman_Click(object sender, EventArgs e)
        {
            lblUzunZaman.Text = simdikiZaman.ToLongDateString(); // = Tarih
            // lblUzunZaman.Text = simdikiZaman.ToLongTimeString(); =Saat

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKisaZaman.Text = simdikiZaman.ToShortDateString(); // = Tarih
            // lblKisaZaman.Text = simdikiZaman.ToShortTimeString(); == Saat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //burda sıkıntı var
            lblGun.Text = simdikiZaman.Day.ToString();
        }

        private void lblAy_Click(object sender, EventArgs e)
        {
            lblAy.Text = simdikiZaman.Month.ToString();
        }

        private void btnZamanEkle_Click(object sender, EventArgs e)
        {
            // Dilediğimiz zamanın üstüne ekstra zaman ekliyoruz. gün ay saniye yıl vs hangi cinsten istersek ekleriz.
            var zaman1=simdikiZaman.AddDays(35);
            var zaman2 = simdikiZaman.AddMonths(4);
            var zaman3 = simdikiZaman.AddYears(45);
            
        }

        private void btnYasHesapla_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = new DateTime(1994, 11, 10);
            var fark = simdikiZaman - dogumTarihi;
            var yas = fark.Days / 365;
            lblYasHesapla.Text = yas.ToString();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var tarih1 = DateTime.Parse("2021-05-06");
            // ingiliz formatlı tarihi değiştirme
            DateTime cevirilenTarih;
            var cevirebildinMi = DateTime.TryParse("2021/13/05", out cevirilenTarih);
            //date time, parasal(currency), harf(İ,ı)

        }
    }
}
