namespace AbstractExample
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
            this.btnGuitar = new System.Windows.Forms.Button();
            this.btnDrum = new System.Windows.Forms.Button();
            this.btnFlut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuitar
            // 
            this.btnGuitar.Location = new System.Drawing.Point(115, 48);
            this.btnGuitar.Name = "btnGuitar";
            this.btnGuitar.Size = new System.Drawing.Size(228, 75);
            this.btnGuitar.TabIndex = 0;
            this.btnGuitar.Text = "Guitar";
            this.btnGuitar.UseVisualStyleBackColor = true;
            this.btnGuitar.Click += new System.EventHandler(this.btnGuitar_Click);
            // 
            // btnDrum
            // 
            this.btnDrum.Location = new System.Drawing.Point(115, 129);
            this.btnDrum.Name = "btnDrum";
            this.btnDrum.Size = new System.Drawing.Size(228, 75);
            this.btnDrum.TabIndex = 1;
            this.btnDrum.Text = "Drum";
            this.btnDrum.UseVisualStyleBackColor = true;
            // 
            // btnFlut
            // 
            this.btnFlut.Location = new System.Drawing.Point(115, 210);
            this.btnFlut.Name = "btnFlut";
            this.btnFlut.Size = new System.Drawing.Size(228, 75);
            this.btnFlut.TabIndex = 2;
            this.btnFlut.Text = "Flut";
            this.btnFlut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 334);
            this.Controls.Add(this.btnFlut);
            this.Controls.Add(this.btnDrum);
            this.Controls.Add(this.btnGuitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuitar;
        private System.Windows.Forms.Button btnDrum;
        private System.Windows.Forms.Button btnFlut;
    }
}

