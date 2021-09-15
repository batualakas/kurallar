using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metotlar
{
    public partial class Form3 : Form
    {
        /* 
        Params:
        out:
        ref:
         */
        //PARAMS ÖRNEĞİ BİRDEN FAZLA SAYI GİRİP ONLARIN TOPLAMINI YAPMA
        #region Metotlar 
        private int Topla(params int[] sayilar)
        {
            var toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        #endregion

        //Random sayi üreterek listboxa bu sayıları ekleyen bir metot yazınız.
        //kaç tane random sayı üretmek istediğimizi kullancıya soralım.
        // listboxa daha önce eklenen bir sayı tekrar eklenmesin.
        //random sayı üret(10);
        #region Örnek2
        private int[] RandomSayiUret(int sayi)
        {
            Random rnd = new Random();
           
           


        }
        #endregion

        public Form3()
        {
            InitializeComponent();
        }

        private void btnParams_Click(object sender, EventArgs e)
        {

        }
    }
}
