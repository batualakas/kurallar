
namespace k07_Donguler
{
    partial class WhileDongusu
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(13, 13);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(224, 23);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "1-) 1\'den 100\'e kadar sayıları yazdır.";
            this.btnOrnek1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(13, 43);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(224, 23);
            this.btnOrnek2.TabIndex = 2;
            this.btnOrnek2.Text = "2-) Rastgele 10 Tane Sayı ekle";
            this.btnOrnek2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(323, 12);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(120, 290);
            this.lstSonuc.TabIndex = 3;
            // 
            // WhileDongusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 325);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "WhileDongusu";
            this.Text = "WhileDongusu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.ListBox lstSonuc;
    }
}