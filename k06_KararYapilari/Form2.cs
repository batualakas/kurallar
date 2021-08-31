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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSifreKontrol_Click(object sender, EventArgs e)
        {
            // Girilen Şifrenin uzunluğu 8 karakterden azsa şifre güvensiz yazıcak.
            // Eşitse daha güçlü şifre kullanılabilir.
            // 8 den çoksa güçlü şifre yazacak bir uygulama yazınız

            var girilenSifre = txtSifre.Text;
            
            

            if(girilenSifre.Length < 8)
            {
                MessageBox.Show("Şifre Güçsüz");
            }

            else if (girilenSifre.Length == 8) 
            {
                MessageBox.Show("Daha Güçlü Şifre olabilir");
            }
            else
            {
                MessageBox.Show("Şifre güzell");
            }

            // Bir Kullancı adı şifre isteyelim admin ve parola 1234 ise hoşgeldiniz yazısı yazdıralım. kullanıcı adı admin değilse kullanıcınız adınız hatalı. parola 1234 değilse parolanız hatalı. ikiside yanlışsa kullanıcı adı ve parolanız hatalı mesajını gösterelim.
            
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var id = txtKullaniciAdi.Text.ToLower();
            var yeniId = Convert.ToString(id);
            var password = txtParola.Text;
            var yeniSifre = Convert.ToInt32(password);

            if (yeniId == "admin" && yeniSifre == 1234)
            {
                MessageBox.Show("Hoşgeldiniz :)");
            }

            else if (yeniId != "admin" && yeniSifre == 1234) 
            {
                MessageBox.Show("Kullanıcı Adınız Hatalı");
            }

            else if (yeniId == "admin" && yeniSifre != 1234) 
            {
                MessageBox.Show("Şifreniz Hatalı");
            }
            else
            {
                MessageBox.Show("Kullancı Adınız ve Şifreniz Hatalı");
            }
        }
    }
}
