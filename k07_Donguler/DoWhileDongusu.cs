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
    public partial class DoWhileDongusu : Form
    {
        // Do while döngüsü, while döngüsü gibi çalışır anca while'da önce koşulu kontrol eder sonra içerideki işlemleri koşul sağlanıyorsa yapar; do while döngüsünde ise öncelikle işlemler yapılır sonra koşul kontrol edilir, koşul sağlandığı sürece döngü çalışmaya devam eder.
        /*
         do 
        {
            //işlemler
        }
        while(koşul);

        */
        public DoWhileDongusu()
        {
            InitializeComponent();
            int i = 0;
            do

            {
                MessageBox.Show("Merhaba Dünya");
                i++;
            } while (i < 3);
        }
    }
}
