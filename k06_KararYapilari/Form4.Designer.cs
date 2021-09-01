
namespace k06_KararYapilari
{
    partial class Form4
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
            this.btnUrunNerde = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrununYeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı Giriniz";
            // 
            // btnUrunNerde
            // 
            this.btnUrunNerde.Location = new System.Drawing.Point(12, 54);
            this.btnUrunNerde.Name = "btnUrunNerde";
            this.btnUrunNerde.Size = new System.Drawing.Size(75, 23);
            this.btnUrunNerde.TabIndex = 1;
            this.btnUrunNerde.Text = "Ürün Nerde";
            this.btnUrunNerde.UseVisualStyleBackColor = true;
            this.btnUrunNerde.Click += new System.EventHandler(this.btnUrunNerde_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(116, 18);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtUrununYeri
            // 
            this.txtUrununYeri.Enabled = false;
            this.txtUrununYeri.Location = new System.Drawing.Point(116, 96);
            this.txtUrununYeri.Name = "txtUrununYeri";
            this.txtUrununYeri.Size = new System.Drawing.Size(162, 20);
            this.txtUrununYeri.TabIndex = 3;
            this.txtUrununYeri.TextChanged += new System.EventHandler(this.txtUrununYeri_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürünün Yeri";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrununYeri);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnUrunNerde);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunNerde;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrununYeri;
        private System.Windows.Forms.Label label2;
    }
}