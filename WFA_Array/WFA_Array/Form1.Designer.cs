﻿namespace WFA_Array
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnenkucuksayi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(69, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 522);
            this.listBox1.TabIndex = 0;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(502, 64);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(285, 96);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnenkucuksayi
            // 
            this.btnenkucuksayi.Location = new System.Drawing.Point(516, 248);
            this.btnenkucuksayi.Name = "btnenkucuksayi";
            this.btnenkucuksayi.Size = new System.Drawing.Size(271, 139);
            this.btnenkucuksayi.TabIndex = 2;
            this.btnenkucuksayi.Text = "en küçük sayı";
            this.btnenkucuksayi.UseVisualStyleBackColor = true;
            this.btnenkucuksayi.Click += new System.EventHandler(this.btnenkucuksayi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2226, 1009);
            this.Controls.Add(this.btnenkucuksayi);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnenkucuksayi;
    }
}

