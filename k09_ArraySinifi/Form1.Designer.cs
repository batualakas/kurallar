
namespace k09_ArraySinifi
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.lstFiziksel = new System.Windows.Forms.ListBox();
            this.lstOnline = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 12);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(180, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lstFiziksel
            // 
            this.lstFiziksel.FormattingEnabled = true;
            this.lstFiziksel.Location = new System.Drawing.Point(225, 12);
            this.lstFiziksel.Name = "lstFiziksel";
            this.lstFiziksel.Size = new System.Drawing.Size(120, 95);
            this.lstFiziksel.TabIndex = 1;
            // 
            // lstOnline
            // 
            this.lstOnline.FormattingEnabled = true;
            this.lstOnline.Location = new System.Drawing.Point(389, 12);
            this.lstOnline.Name = "lstOnline";
            this.lstOnline.Size = new System.Drawing.Size(120, 95);
            this.lstOnline.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear()";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(13, 72);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(179, 23);
            this.btnIndexOf.TabIndex = 4;
            this.btnIndexOf.Text = "İndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(13, 101);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(179, 23);
            this.btnLastIndexOf.TabIndex = 5;
            this.btnLastIndexOf.Text = "LastIndexOf";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(13, 131);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(179, 23);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.Text = "Reverse()";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(13, 160);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(179, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(12, 190);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(180, 23);
            this.btnResize.TabIndex = 8;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOnline);
            this.Controls.Add(this.lstFiziksel);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListBox lstFiziksel;
        private System.Windows.Forms.ListBox lstOnline;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnResize;
    }
}

