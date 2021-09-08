
namespace k09_ArraySinifi
{
    partial class PasswprdGenerator
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
            this.txtKarakterSayisi = new System.Windows.Forms.TextBox();
            this.chbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chbKucukHarf = new System.Windows.Forms.CheckBox();
            this.chbRakam = new System.Windows.Forms.CheckBox();
            this.chbSembol = new System.Windows.Forms.CheckBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.lstSifreler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaç karakterli bir şifre istiyorsunuz";
            // 
            // txtKarakterSayisi
            // 
            this.txtKarakterSayisi.Location = new System.Drawing.Point(185, 13);
            this.txtKarakterSayisi.Name = "txtKarakterSayisi";
            this.txtKarakterSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKarakterSayisi.TabIndex = 1;
            // 
            // chbBuyukHarf
            // 
            this.chbBuyukHarf.AutoSize = true;
            this.chbBuyukHarf.Location = new System.Drawing.Point(16, 39);
            this.chbBuyukHarf.Name = "chbBuyukHarf";
            this.chbBuyukHarf.Size = new System.Drawing.Size(141, 17);
            this.chbBuyukHarf.TabIndex = 2;
            this.chbBuyukHarf.Text = "Büyük harf ister misiniz ?";
            this.chbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chbKucukHarf
            // 
            this.chbKucukHarf.AutoSize = true;
            this.chbKucukHarf.Location = new System.Drawing.Point(16, 63);
            this.chbKucukHarf.Name = "chbKucukHarf";
            this.chbKucukHarf.Size = new System.Drawing.Size(139, 17);
            this.chbKucukHarf.TabIndex = 3;
            this.chbKucukHarf.Text = "Küçük harf ister misiniz?";
            this.chbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chbRakam
            // 
            this.chbRakam.AutoSize = true;
            this.chbRakam.Location = new System.Drawing.Point(16, 87);
            this.chbRakam.Name = "chbRakam";
            this.chbRakam.Size = new System.Drawing.Size(121, 17);
            this.chbRakam.TabIndex = 4;
            this.chbRakam.Text = "Rakam ister misiniz?";
            this.chbRakam.UseVisualStyleBackColor = true;
            // 
            // chbSembol
            // 
            this.chbSembol.AutoSize = true;
            this.chbSembol.Location = new System.Drawing.Point(16, 111);
            this.chbSembol.Name = "chbSembol";
            this.chbSembol.Size = new System.Drawing.Size(128, 17);
            this.chbSembol.TabIndex = 5;
            this.chbSembol.Text = "Sembol ister misiniz ? ";
            this.chbSembol.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(12, 134);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(98, 23);
            this.btnOlustur.TabIndex = 6;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lstSifreler
            // 
            this.lstSifreler.FormattingEnabled = true;
            this.lstSifreler.Location = new System.Drawing.Point(16, 163);
            this.lstSifreler.Name = "lstSifreler";
            this.lstSifreler.Size = new System.Drawing.Size(128, 147);
            this.lstSifreler.TabIndex = 7;
            // 
            // PasswprdGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 343);
            this.Controls.Add(this.lstSifreler);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.chbSembol);
            this.Controls.Add(this.chbRakam);
            this.Controls.Add(this.chbKucukHarf);
            this.Controls.Add(this.chbBuyukHarf);
            this.Controls.Add(this.txtKarakterSayisi);
            this.Controls.Add(this.label1);
            this.Name = "PasswprdGenerator";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKarakterSayisi;
        private System.Windows.Forms.CheckBox chbBuyukHarf;
        private System.Windows.Forms.CheckBox chbKucukHarf;
        private System.Windows.Forms.CheckBox chbRakam;
        private System.Windows.Forms.CheckBox chbSembol;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.ListBox lstSifreler;
    }
}