
namespace k06_KararYapilari
{
    partial class Form3
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
            this.txtVize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblOrtalama1 = new System.Windows.Forms.Label();
            this.lblHarfNotu1 = new System.Windows.Forms.Label();
            this.lblDurum1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize Notu  :";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(82, 32);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Notu :";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(82, 56);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(82, 82);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(17, 136);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(61, 13);
            this.lblOrtalama.TabIndex = 5;
            this.lblOrtalama.Text = "Ortalama   :";
            this.lblOrtalama.Click += new System.EventHandler(this.lblOrtalama_Click);
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Location = new System.Drawing.Point(17, 164);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(62, 13);
            this.lblHarfNotu.TabIndex = 6;
            this.lblHarfNotu.Text = "Harf Notu  :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(17, 191);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(62, 13);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum       :";
            // 
            // lblOrtalama1
            // 
            this.lblOrtalama1.AutoSize = true;
            this.lblOrtalama1.Location = new System.Drawing.Point(97, 136);
            this.lblOrtalama1.Name = "lblOrtalama1";
            this.lblOrtalama1.Size = new System.Drawing.Size(0, 13);
            this.lblOrtalama1.TabIndex = 8;
            this.lblOrtalama1.Click += new System.EventHandler(this.lblOrtalama1_Click);
            // 
            // lblHarfNotu1
            // 
            this.lblHarfNotu1.AutoSize = true;
            this.lblHarfNotu1.Location = new System.Drawing.Point(100, 164);
            this.lblHarfNotu1.Name = "lblHarfNotu1";
            this.lblHarfNotu1.Size = new System.Drawing.Size(0, 13);
            this.lblHarfNotu1.TabIndex = 9;
            // 
            // lblDurum1
            // 
            this.lblDurum1.AutoSize = true;
            this.lblDurum1.Location = new System.Drawing.Point(100, 191);
            this.lblDurum1.Name = "lblDurum1";
            this.lblDurum1.Size = new System.Drawing.Size(0, 13);
            this.lblDurum1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 264);
            this.Controls.Add(this.lblDurum1);
            this.Controls.Add(this.lblHarfNotu1);
            this.Controls.Add(this.lblOrtalama1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblHarfNotu);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblOrtalama1;
        private System.Windows.Forms.Label lblHarfNotu1;
        private System.Windows.Forms.Label lblDurum1;
    }
}