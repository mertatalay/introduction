namespace WFA_For
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngeriyesay = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnalfabe = new System.Windows.Forms.Button();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(126, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(879, 633);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1181, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1174, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1181, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 44);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1320, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // btngeriyesay
            // 
            this.btngeriyesay.Location = new System.Drawing.Point(1192, 720);
            this.btngeriyesay.Name = "btngeriyesay";
            this.btngeriyesay.Size = new System.Drawing.Size(343, 89);
            this.btngeriyesay.TabIndex = 5;
            this.btngeriyesay.Text = "geriye say";
            this.btngeriyesay.UseVisualStyleBackColor = true;
            this.btngeriyesay.Click += new System.EventHandler(this.btngeriyesay_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 37;
            this.listBox2.Location = new System.Drawing.Point(1935, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(586, 596);
            this.listBox2.TabIndex = 6;
            // 
            // btnalfabe
            // 
            this.btnalfabe.Location = new System.Drawing.Point(183, 747);
            this.btnalfabe.Name = "btnalfabe";
            this.btnalfabe.Size = new System.Drawing.Size(411, 167);
            this.btnalfabe.TabIndex = 7;
            this.btnalfabe.Text = "Alfabe";
            this.btnalfabe.UseVisualStyleBackColor = true;
            this.btnalfabe.Click += new System.EventHandler(this.btnalfabe_Click);
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(2058, 866);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(396, 121);
            this.btnsonuc.TabIndex = 8;
            this.btnsonuc.Text = "sonuc";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2706, 1169);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.btnalfabe);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btngeriyesay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngeriyesay;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnalfabe;
        private System.Windows.Forms.Button btnsonuc;
    }
}

