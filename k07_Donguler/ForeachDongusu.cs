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
    public partial class ForeachDongusu : Form
    {
        /*
         Foreach döngüsü liste ya da dizi gibi bir koleksiyonda döner ve her dönüşte gelen değeri bir değişken üzerinde tutar.
        //Koleksiyon içinde okunacak değer olduğu sürece dönmeye devam eder. 
        foreach(var item in koleksiyon)
        {
         // yapılacak işlemler
        }
        
         */
        public ForeachDongusu()
        {
            InitializeComponent();
            string[] isimler = { "bahar", "serdar", "ömer", "leyla", "batuhan", "çiğdem", "eray", "orkun", "batuhan", "mustafa" };
            foreach ( var isim in isimler)
            {
                MessageBox.Show(isim);
            }
        }
    }
}
