using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k09_ArraySinifi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] ziyaretciler = new string[0];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Textboxtan alınan ad soyadı bir dizide toplayalım sonrasında listbox'a atalım.
            var adSoyad = txtAdSoyad.Text;
            Array.Resize(ref ziyaretciler,ziyaretciler.Length + 1);

            ziyaretciler[ziyaretciler.Length-1] = adSoyad;

            lstZiyaretciler.Items.Add($"{ziyaretciler.Length}. Ziyaretçi = {adSoyad}");
        }
    }
}
