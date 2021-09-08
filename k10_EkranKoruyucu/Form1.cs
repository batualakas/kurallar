using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_EkranKoruyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // formun içindekiler yüklendikten sonra resmin rastgele olarak yer değiştirmesini istiyoruz
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // interval verdiğiniz değere göre sürekli tetiklenir.
            Random rnd = new Random();
            var formunGenisligi = this.Width-pictureBox1.Width;
            var formunYuksekligi = this.Height-pictureBox1.Height;
            var rastgeleSayi1 = rnd.Next(0, formunGenisligi);
            var rastgelesayi2 = rnd.Next(0, formunYuksekligi);

            pictureBox1.Left = rastgeleSayi1;
            pictureBox1.Height = rastgelesayi2;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //uygulamadan çıkmak istiyoruz.
            Application.Exit();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }
    }
}
