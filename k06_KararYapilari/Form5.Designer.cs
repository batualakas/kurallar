﻿
namespace k06_KararYapilari
{
    partial class Form5
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
            this.txtSiparisAdeti = new System.Windows.Forms.TextBox();
            this.btnFiyatHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtKazanc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtİndirimsiz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Adeti";
            // 
            // txtSiparisAdeti
            // 
            this.txtSiparisAdeti.Location = new System.Drawing.Point(108, 27);
            this.txtSiparisAdeti.Name = "txtSiparisAdeti";
            this.txtSiparisAdeti.Size = new System.Drawing.Size(100, 20);
            this.txtSiparisAdeti.TabIndex = 1;
            this.txtSiparisAdeti.Text = "24";
            // 
            // btnFiyatHesapla
            // 
            this.btnFiyatHesapla.Location = new System.Drawing.Point(108, 65);
            this.btnFiyatHesapla.Name = "btnFiyatHesapla";
            this.btnFiyatHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnFiyatHesapla.TabIndex = 2;
            this.btnFiyatHesapla.Text = "Hesapla";
            this.btnFiyatHesapla.UseVisualStyleBackColor = true;
            this.btnFiyatHesapla.Click += new System.EventHandler(this.btnFiyatHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödenecek Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Location = new System.Drawing.Point(119, 183);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 20);
            this.txtToplamTutar.TabIndex = 4;
            // 
            // txtKazanc
            // 
            this.txtKazanc.Location = new System.Drawing.Point(119, 148);
            this.txtKazanc.Name = "txtKazanc";
            this.txtKazanc.Size = new System.Drawing.Size(100, 20);
            this.txtKazanc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "İndirim Tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Tutar";
            // 
            // txtİndirimsiz
            // 
            this.txtİndirimsiz.Location = new System.Drawing.Point(119, 117);
            this.txtİndirimsiz.Name = "txtİndirimsiz";
            this.txtİndirimsiz.Size = new System.Drawing.Size(100, 20);
            this.txtİndirimsiz.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 297);
            this.Controls.Add(this.txtİndirimsiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKazanc);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiyatHesapla);
            this.Controls.Add(this.txtSiparisAdeti);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiparisAdeti;
        private System.Windows.Forms.Button btnFiyatHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtKazanc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtİndirimsiz;
    }
}