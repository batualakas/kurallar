
namespace k11_Metotlar
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
            this.btnParams = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIstenilenSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(13, 12);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(146, 61);
            this.btnParams.TabIndex = 0;
            this.btnParams.Text = "Params";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(13, 79);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(146, 45);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(174, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 3;
            // 
            // txtIstenilenSayi
            // 
            this.txtIstenilenSayi.Location = new System.Drawing.Point(25, 178);
            this.txtIstenilenSayi.Name = "txtIstenilenSayi";
            this.txtIstenilenSayi.Size = new System.Drawing.Size(100, 20);
            this.txtIstenilenSayi.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 322);
            this.Controls.Add(this.txtIstenilenSayi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnParams);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIstenilenSayi;
    }
}