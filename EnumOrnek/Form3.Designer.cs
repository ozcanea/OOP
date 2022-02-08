namespace EnumOrnek
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKontrolluEnum = new System.Windows.Forms.Button();
            this.btnEnum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(222, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 160);
            this.listBox1.TabIndex = 14;
            // 
            // btnKontrolluEnum
            // 
            this.btnKontrolluEnum.Location = new System.Drawing.Point(92, 172);
            this.btnKontrolluEnum.Margin = new System.Windows.Forms.Padding(2);
            this.btnKontrolluEnum.Name = "btnKontrolluEnum";
            this.btnKontrolluEnum.Size = new System.Drawing.Size(126, 25);
            this.btnKontrolluEnum.TabIndex = 13;
            this.btnKontrolluEnum.Text = "Kontrollü Enum Değeri";
            this.btnKontrolluEnum.UseVisualStyleBackColor = true;
            this.btnKontrolluEnum.Click += new System.EventHandler(this.btnKontrolluEnum_Click);
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(93, 105);
            this.btnEnum.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(126, 25);
            this.btnEnum.TabIndex = 12;
            this.btnEnum.Text = "Enum Değeri";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sayı Giriniz : ";
            // 
            // txtEnum
            // 
            this.txtEnum.Location = new System.Drawing.Point(92, 37);
            this.txtEnum.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnum.Name = "txtEnum";
            this.txtEnum.Size = new System.Drawing.Size(127, 20);
            this.txtEnum.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 233);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKontrolluEnum);
            this.Controls.Add(this.btnEnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnum);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKontrolluEnum;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnum;
    }
}