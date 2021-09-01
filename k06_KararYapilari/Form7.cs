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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanciAdi = txtKullanici.Text;
            var parola = txtParola.Text;

            switch (kullanciAdi)
            {
                case "admin":
                    switch (parola)
                    {
                        case "1234":
                            MessageBox.Show("Giriş Başarılı");
                            break;
                        default:
                            MessageBox.Show("Parolanız yanlış");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullancı Adınız Yanlış ");
                        break;
            }
        }
    }
}
