namespace ReferenceAndValueTypes
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
            this.btnReference = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReference
            // 
            this.btnReference.Location = new System.Drawing.Point(12, 59);
            this.btnReference.Name = "btnReference";
            this.btnReference.Size = new System.Drawing.Size(148, 152);
            this.btnReference.TabIndex = 0;
            this.btnReference.Text = "Reference";
            this.btnReference.UseVisualStyleBackColor = true;
            this.btnReference.Click += new System.EventHandler(this.btnReference_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(210, 59);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(148, 152);
            this.btnValue.TabIndex = 1;
            this.btnValue.Text = "Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 294);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnReference);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReference;
        private System.Windows.Forms.Button btnValue;
    }
}

