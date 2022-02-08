namespace Delegete
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
            this.lblDb = new System.Windows.Forms.Label();
            this.lblXml = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblSms = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(75, 89);
            this.lblDb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(0, 13);
            this.lblDb.TabIndex = 16;
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(75, 64);
            this.lblXml.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(0, 13);
            this.lblXml.TabIndex = 17;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(75, 39);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(0, 13);
            this.lblMail.TabIndex = 18;
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new System.Drawing.Point(75, 15);
            this.lblSms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(0, 13);
            this.lblSms.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Db Log :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Xml Log :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mail Log :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sms Log :";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(21, 136);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(152, 37);
            this.btnLog.TabIndex = 20;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 211);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.lblXml);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.Label lblXml;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
    }
}

