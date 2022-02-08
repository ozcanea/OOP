namespace Structs
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
            this.btnStruct = new System.Windows.Forms.Button();
            this.btnSealedClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(12, 49);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(224, 168);
            this.btnStruct.TabIndex = 0;
            this.btnStruct.Text = "With Struct...";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // btnSealedClass
            // 
            this.btnSealedClass.Location = new System.Drawing.Point(266, 49);
            this.btnSealedClass.Name = "btnSealedClass";
            this.btnSealedClass.Size = new System.Drawing.Size(224, 168);
            this.btnSealedClass.TabIndex = 1;
            this.btnSealedClass.Text = "Sealed Class...";
            this.btnSealedClass.UseVisualStyleBackColor = true;
            this.btnSealedClass.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 270);
            this.Controls.Add(this.btnSealedClass);
            this.Controls.Add(this.btnStruct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.Button btnSealedClass;
    }
}

