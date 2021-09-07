using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class Form1 : Form
    /* 
      Diziler   
    bir değişken üzerinden birden fazla aynı VERİ TİPİNİN değerlerini tutmak için diziler kullanılır.
    Tanımlanması
    1. Yöntem
     int[] sayilar = {1,2,3,4,5,6,7};
    2. Yöntem
    string[] isimler = new string [] {"bahar","serdar","eray"}; 
    3. Yöntem
    var iller= new string [5];
    iller [0] = " ANKARA "
    iller [1] = " ESKİŞEHİR "
    **DİZİLERDE İNDEX 0'dan BAŞLAR.
     */
    {
        public Form1()
        {
            InitializeComponent();
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            //string[] isimler = new string[] { "bahar", "serdar", "eray" };
            var iller = new string[3];
            iller[0] = "ANKARA";
            iller[1] = "İzmir";
            iller[2] = "ESKİSEHİR";
            iller[3] = "PARİS";
           
        }
    }
}
