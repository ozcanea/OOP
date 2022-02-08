namespace Encapsulation
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
            this.txtGecmeNotu = new System.Windows.Forms.TextBox();
            this.lblGecmeNotu = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtGecmeNotu
            // 
            this.txtGecmeNotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGecmeNotu.Location = new System.Drawing.Point(188, 31);
            this.txtGecmeNotu.Name = "txtGecmeNotu";
            this.txtGecmeNotu.Size = new System.Drawing.Size(182, 29);
            this.txtGecmeNotu.TabIndex = 0;
            // 
            // lblGecmeNotu
            // 
            this.lblGecmeNotu.AutoSize = true;
            this.lblGecmeNotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecmeNotu.Location = new System.Drawing.Point(50, 34);
            this.lblGecmeNotu.Name = "lblGecmeNotu";
            this.lblGecmeNotu.Size = new System.Drawing.Size(117, 24);
            this.lblGecmeNotu.TabIndex = 1;
            this.lblGecmeNotu.Text = "Geçme Notu";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(295, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(54, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 303);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 446);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGecmeNotu);
            this.Controls.Add(this.txtGecmeNotu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGecmeNotu;
        private System.Windows.Forms.Label lblGecmeNotu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox listBox1;
    }
}

