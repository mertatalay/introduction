namespace WFA_introduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visual Studio 2023";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(774, 245);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visual studio nun en son sürümüdür. size özel olarak çıkarılmıştır.güle güle kull" +
    "anın. kurulum işlemleri için aşağıdaki butonları kullanabilirsiniz.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(161, 371);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(191, 114);
            this.btniptal.TabIndex = 2;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(521, 371);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(188, 114);
            this.btnileri.TabIndex = 3;
            this.btnileri.Text = "ileri";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            this.btnileri.MouseHover += new System.EventHandler(this.btnileri_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2178, 833);
            this.Controls.Add(this.btnileri);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnileri;
    }
}

