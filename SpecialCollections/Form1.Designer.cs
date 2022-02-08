namespace SpecialCollections
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
            this.btnSorted = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnHybridDictionary = new System.Windows.Forms.Button();
            this.btnListDictionary = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHashtable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSorted
            // 
            this.btnSorted.Location = new System.Drawing.Point(267, 100);
            this.btnSorted.Margin = new System.Windows.Forms.Padding(2);
            this.btnSorted.Name = "btnSorted";
            this.btnSorted.Size = new System.Drawing.Size(159, 21);
            this.btnSorted.TabIndex = 25;
            this.btnSorted.Text = "SORTEDLIST";
            this.btnSorted.UseVisualStyleBackColor = true;
            this.btnSorted.Click += new System.EventHandler(this.btnSorted_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(267, 76);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(2);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(159, 21);
            this.btnQueue.TabIndex = 24;
            this.btnQueue.Text = "QUEUE";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnHybridDictionary
            // 
            this.btnHybridDictionary.Location = new System.Drawing.Point(95, 112);
            this.btnHybridDictionary.Margin = new System.Windows.Forms.Padding(2);
            this.btnHybridDictionary.Name = "btnHybridDictionary";
            this.btnHybridDictionary.Size = new System.Drawing.Size(159, 21);
            this.btnHybridDictionary.TabIndex = 23;
            this.btnHybridDictionary.Text = "HYBRIDDICTIONARY";
            this.btnHybridDictionary.UseVisualStyleBackColor = true;
            this.btnHybridDictionary.Click += new System.EventHandler(this.btnHybridDictionary_Click);
            // 
            // btnListDictionary
            // 
            this.btnListDictionary.Location = new System.Drawing.Point(95, 87);
            this.btnListDictionary.Margin = new System.Windows.Forms.Padding(2);
            this.btnListDictionary.Name = "btnListDictionary";
            this.btnListDictionary.Size = new System.Drawing.Size(159, 21);
            this.btnListDictionary.TabIndex = 22;
            this.btnListDictionary.Text = "LISTDICTIONARY";
            this.btnListDictionary.UseVisualStyleBackColor = true;
            this.btnListDictionary.Click += new System.EventHandler(this.btnListDictionary_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(95, 137);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 108);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnHashtable
            // 
            this.btnHashtable.Location = new System.Drawing.Point(95, 63);
            this.btnHashtable.Margin = new System.Windows.Forms.Padding(2);
            this.btnHashtable.Name = "btnHashtable";
            this.btnHashtable.Size = new System.Drawing.Size(159, 21);
            this.btnHashtable.TabIndex = 20;
            this.btnHashtable.Text = "HASHTABLE";
            this.btnHashtable.UseVisualStyleBackColor = true;
            this.btnHashtable.Click += new System.EventHandler(this.btnHashtable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 308);
            this.Controls.Add(this.btnSorted);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnHybridDictionary);
            this.Controls.Add(this.btnListDictionary);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHashtable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorted;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnHybridDictionary;
        private System.Windows.Forms.Button btnListDictionary;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHashtable;
    }
}

