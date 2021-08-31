
namespace k06_KararYapilari
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnSifreKontrol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.chbBeniHatirla = new System.Windows.Forms.CheckBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrenizi Giriniz";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(125, 73);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // btnSifreKontrol
            // 
            this.btnSifreKontrol.Location = new System.Drawing.Point(135, 99);
            this.btnSifreKontrol.Name = "btnSifreKontrol";
            this.btnSifreKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnSifreKontrol.TabIndex = 2;
            this.btnSifreKontrol.Text = "Kontrol Et";
            this.btnSifreKontrol.UseVisualStyleBackColor = true;
            this.btnSifreKontrol.Click += new System.EventHandler(this.btnSifreKontrol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullancı Adınızı giriniz :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(220, 178);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(118, 20);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifrenizi Giriniz :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beni Hatırla";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(263, 234);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // chbBeniHatirla
            // 
            this.chbBeniHatirla.AutoSize = true;
            this.chbBeniHatirla.Location = new System.Drawing.Point(170, 239);
            this.chbBeniHatirla.Name = "chbBeniHatirla";
            this.chbBeniHatirla.Size = new System.Drawing.Size(15, 14);
            this.chbBeniHatirla.TabIndex = 9;
            this.chbBeniHatirla.UseVisualStyleBackColor = true;
            this.chbBeniHatirla.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(220, 207);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(118, 20);
            this.txtParola.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 325);
            this.Controls.Add(this.chbBeniHatirla);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSifreKontrol);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnSifreKontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox chbBeniHatirla;
        private System.Windows.Forms.TextBox txtParola;
    }
}