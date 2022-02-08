namespace OOP_Introduction
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
            this.gBShow = new System.Windows.Forms.GroupBox();
            this.btnName = new System.Windows.Forms.Button();
            this.gBSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchByAge = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.gBShow.SuspendLayout();
            this.gBSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBShow
            // 
            this.gBShow.Controls.Add(this.btnInfo);
            this.gBShow.Controls.Add(this.btnName);
            this.gBShow.Location = new System.Drawing.Point(12, 12);
            this.gBShow.Name = "gBShow";
            this.gBShow.Size = new System.Drawing.Size(375, 155);
            this.gBShow.TabIndex = 0;
            this.gBShow.TabStop = false;
            this.gBShow.Text = "Member";
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(83, 36);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(200, 39);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Show Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // gBSearch
            // 
            this.gBSearch.Controls.Add(this.label1);
            this.gBSearch.Controls.Add(this.txtAge);
            this.gBSearch.Controls.Add(this.btnSearchByAge);
            this.gBSearch.Location = new System.Drawing.Point(12, 182);
            this.gBSearch.Name = "gBSearch";
            this.gBSearch.Size = new System.Drawing.Size(375, 155);
            this.gBSearch.TabIndex = 1;
            this.gBSearch.TabStop = false;
            this.gBSearch.Text = "Search Member";
            // 
            // btnSearchByAge
            // 
            this.btnSearchByAge.Location = new System.Drawing.Point(171, 93);
            this.btnSearchByAge.Name = "btnSearchByAge";
            this.btnSearchByAge.Size = new System.Drawing.Size(198, 36);
            this.btnSearchByAge.TabIndex = 0;
            this.btnSearchByAge.Text = "Search";
            this.btnSearchByAge.UseVisualStyleBackColor = true;
            this.btnSearchByAge.Click += new System.EventHandler(this.btnSearchByAge_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(171, 48);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(198, 26);
            this.txtAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Age";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(83, 90);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 39);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Show Personal Informations";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 353);
            this.Controls.Add(this.gBSearch);
            this.Controls.Add(this.gBShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBShow.ResumeLayout(false);
            this.gBSearch.ResumeLayout(false);
            this.gBSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBShow;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.GroupBox gBSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSearchByAge;
        private System.Windows.Forms.Button btnInfo;
    }
}

