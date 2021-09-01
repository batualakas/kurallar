
namespace k06_KararYapilari
{
    partial class Form6
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
            this.txtMevsim = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtAylar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniAy = new System.Windows.Forms.TextBox();
            this.btnMevsim = new System.Windows.Forms.Button();
            this.txtYeniMevsim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevsimleri Giriniz";
            // 
            // txtMevsim
            // 
            this.txtMevsim.Location = new System.Drawing.Point(45, 65);
            this.txtMevsim.Name = "txtMevsim";
            this.txtMevsim.Size = new System.Drawing.Size(100, 20);
            this.txtMevsim.TabIndex = 1;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(45, 91);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Ayları Getir";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtAylar
            // 
            this.txtAylar.Location = new System.Drawing.Point(45, 134);
            this.txtAylar.Name = "txtAylar";
            this.txtAylar.Size = new System.Drawing.Size(206, 20);
            this.txtAylar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ayı Giriniz";
            // 
            // txtYeniAy
            // 
            this.txtYeniAy.Location = new System.Drawing.Point(376, 64);
            this.txtYeniAy.Name = "txtYeniAy";
            this.txtYeniAy.Size = new System.Drawing.Size(100, 20);
            this.txtYeniAy.TabIndex = 5;
            // 
            // btnMevsim
            // 
            this.btnMevsim.Location = new System.Drawing.Point(376, 90);
            this.btnMevsim.Name = "btnMevsim";
            this.btnMevsim.Size = new System.Drawing.Size(100, 23);
            this.btnMevsim.TabIndex = 6;
            this.btnMevsim.Text = "Mevsimi Getir";
            this.btnMevsim.UseVisualStyleBackColor = true;
            this.btnMevsim.Click += new System.EventHandler(this.btnMevsim_Click);
            // 
            // txtYeniMevsim
            // 
            this.txtYeniMevsim.Location = new System.Drawing.Point(376, 133);
            this.txtYeniMevsim.Name = "txtYeniMevsim";
            this.txtYeniMevsim.Size = new System.Drawing.Size(100, 20);
            this.txtYeniMevsim.TabIndex = 7;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYeniMevsim);
            this.Controls.Add(this.btnMevsim);
            this.Controls.Add(this.txtYeniAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAylar);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtMevsim);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMevsim;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox txtAylar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniAy;
        private System.Windows.Forms.Button btnMevsim;
        private System.Windows.Forms.TextBox txtYeniMevsim;
    }
}