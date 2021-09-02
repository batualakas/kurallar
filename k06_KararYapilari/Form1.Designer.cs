
namespace k06_KararYapilari
{
    partial class Form1
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTikla = new System.Windows.Forms.Button();
            this.btnGectiKaldi = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTekCift = new System.Windows.Forms.TextBox();
            this.btnTekCift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(15, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bir İsim Giriniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTikla
            // 
            this.btnTikla.Location = new System.Drawing.Point(26, 60);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(75, 23);
            this.btnTikla.TabIndex = 2;
            this.btnTikla.Text = "Tıklayınız";
            this.btnTikla.UseVisualStyleBackColor = true;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // btnGectiKaldi
            // 
            this.btnGectiKaldi.Location = new System.Drawing.Point(163, 153);
            this.btnGectiKaldi.Name = "btnGectiKaldi";
            this.btnGectiKaldi.Size = new System.Drawing.Size(75, 23);
            this.btnGectiKaldi.TabIndex = 3;
            this.btnGectiKaldi.Text = "Geçti/Kaldı";
            this.btnGectiKaldi.UseVisualStyleBackColor = true;
            this.btnGectiKaldi.Click += new System.EventHandler(this.btnGectiKaldi_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(149, 127);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(100, 20);
            this.txtNot.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bir Not Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bir Sayı Giriniz";
            // 
            // txtTekCift
            // 
            this.txtTekCift.Location = new System.Drawing.Point(12, 133);
            this.txtTekCift.Name = "txtTekCift";
            this.txtTekCift.Size = new System.Drawing.Size(100, 20);
            this.txtTekCift.TabIndex = 7;
            this.txtTekCift.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTekCift
            // 
            this.btnTekCift.Location = new System.Drawing.Point(26, 167);
            this.btnTekCift.Name = "btnTekCift";
            this.btnTekCift.Size = new System.Drawing.Size(75, 23);
            this.btnTekCift.TabIndex = 8;
            this.btnTekCift.Text = "Tek/Çift";
            this.btnTekCift.UseVisualStyleBackColor = true;
            this.btnTekCift.Click += new System.EventHandler(this.btnTekCift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 202);
            this.Controls.Add(this.btnTekCift);
            this.Controls.Add(this.txtTekCift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.btnGectiKaldi);
            this.Controls.Add(this.btnTikla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTikla;
        private System.Windows.Forms.Button btnGectiKaldi;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTekCift;
        private System.Windows.Forms.Button btnTekCift;
    }
}

