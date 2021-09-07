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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1- şifre ve şifre(tekrar)'ların aynı olması gerekiyor.
            // 2- şifrenin uzunluğu 8 karakterden fazla olması gerekiyor.
            // 3- en az 1 büyük harf 1 küçük harf 1 rakam ve 1 sembol içermesi gerekiyor.
            Random rnd = new Random();
            
            var sifre = txtSifre.Text;
            var sifre2 = txtSifreTekrar.Text;
            int[] semboller = new int[15];
            var buyukHarfVarMi = false;
            var kucukHarfVarMi = false;
            var rakamVarMi = false;
            var sembolVarmi = false;

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler birbiri ile uyuşmuyor");
                return;
            }
            if(sifre.Length < 8)
            {
                MessageBox.Show("Şifrenizin Uzunluğu En Az 8 Karakter Olmalıdır");
                return;
            }
            foreach (var karakter in sifre)
            {
                if (karakter>='A' && karakter<= 'Z') // karakter büyük harf mi kontrolü 
                {
                    buyukHarfVarMi = true;
                }
                if (karakter >= 'a' && karakter<= 'z') // karakter küçük harf mi kontrolü
                {
                    kucukHarfVarMi = true;
                }
                if(karakter >= '0' && karakter <= '9') // karakter rakam mı kontrolü
                {
                    rakamVarMi = true;
                }
                if (karakter>= '!' && karakter<= '/') // karakter sembolmü kontorolü
                {
                    sembolVarmi = true;
                }
              
                
                
            }

            


        }
    }
}
