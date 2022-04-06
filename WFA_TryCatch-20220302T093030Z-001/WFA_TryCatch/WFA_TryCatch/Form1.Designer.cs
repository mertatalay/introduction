
namespace WFA_TryCatch
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnOnaylaYonetimli = new System.Windows.Forms.Button();
            this.btnDetayli = new System.Windows.Forms.Button();
            this.btnOnaylaDetayYonetim = new System.Windows.Forms.Button();
            this.lstOnay = new System.Windows.Forms.ListBox();
            this.lstFormatExeption = new System.Windows.Forms.ListBox();
            this.btnOnaylaLog = new System.Windows.Forms.Button();
            this.lstOverFlow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(190, 74);
            this.txtDeger.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(432, 44);
            this.txtDeger.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(190, 151);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(440, 80);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnOnaylaYonetimli
            // 
            this.btnOnaylaYonetimli.Location = new System.Drawing.Point(190, 250);
            this.btnOnaylaYonetimli.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnOnaylaYonetimli.Name = "btnOnaylaYonetimli";
            this.btnOnaylaYonetimli.Size = new System.Drawing.Size(440, 83);
            this.btnOnaylaYonetimli.TabIndex = 2;
            this.btnOnaylaYonetimli.Text = "Onayla (Yönetimli)";
            this.btnOnaylaYonetimli.UseVisualStyleBackColor = true;
            this.btnOnaylaYonetimli.Click += new System.EventHandler(this.btnOnaylaYonetimli_Click);
            // 
            // btnDetayli
            // 
            this.btnDetayli.Location = new System.Drawing.Point(190, 353);
            this.btnDetayli.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnDetayli.Name = "btnDetayli";
            this.btnDetayli.Size = new System.Drawing.Size(440, 100);
            this.btnDetayli.TabIndex = 3;
            this.btnDetayli.Text = "Onayla (Detaylı)";
            this.btnDetayli.UseVisualStyleBackColor = true;
            this.btnDetayli.Click += new System.EventHandler(this.btnDetayli_Click);
            // 
            // btnOnaylaDetayYonetim
            // 
            this.btnOnaylaDetayYonetim.Location = new System.Drawing.Point(190, 472);
            this.btnOnaylaDetayYonetim.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnOnaylaDetayYonetim.Name = "btnOnaylaDetayYonetim";
            this.btnOnaylaDetayYonetim.Size = new System.Drawing.Size(440, 94);
            this.btnOnaylaDetayYonetim.TabIndex = 4;
            this.btnOnaylaDetayYonetim.Text = "Onayla (Detay Yönetim)";
            this.btnOnaylaDetayYonetim.UseVisualStyleBackColor = true;
            this.btnOnaylaDetayYonetim.Click += new System.EventHandler(this.btnOnaylaDetayYonetim_Click);
            // 
            // lstOnay
            // 
            this.lstOnay.FormattingEnabled = true;
            this.lstOnay.ItemHeight = 37;
            this.lstOnay.Location = new System.Drawing.Point(1244, 105);
            this.lstOnay.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lstOnay.Name = "lstOnay";
            this.lstOnay.Size = new System.Drawing.Size(698, 485);
            this.lstOnay.TabIndex = 5;
            // 
            // lstFormatExeption
            // 
            this.lstFormatExeption.FormattingEnabled = true;
            this.lstFormatExeption.ItemHeight = 37;
            this.lstFormatExeption.Location = new System.Drawing.Point(2020, 105);
            this.lstFormatExeption.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lstFormatExeption.Name = "lstFormatExeption";
            this.lstFormatExeption.Size = new System.Drawing.Size(698, 485);
            this.lstFormatExeption.TabIndex = 5;
            // 
            // btnOnaylaLog
            // 
            this.btnOnaylaLog.Location = new System.Drawing.Point(190, 586);
            this.btnOnaylaLog.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnOnaylaLog.Name = "btnOnaylaLog";
            this.btnOnaylaLog.Size = new System.Drawing.Size(440, 94);
            this.btnOnaylaLog.TabIndex = 6;
            this.btnOnaylaLog.Text = "Onayla (Log)";
            this.btnOnaylaLog.UseVisualStyleBackColor = true;
            this.btnOnaylaLog.Click += new System.EventHandler(this.btnOnaylaLog_Click);
            // 
            // lstOverFlow
            // 
            this.lstOverFlow.FormattingEnabled = true;
            this.lstOverFlow.ItemHeight = 37;
            this.lstOverFlow.Location = new System.Drawing.Point(2812, 105);
            this.lstOverFlow.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lstOverFlow.Name = "lstOverFlow";
            this.lstOverFlow.Size = new System.Drawing.Size(698, 485);
            this.lstOverFlow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1249);
            this.Controls.Add(this.btnOnaylaLog);
            this.Controls.Add(this.lstOverFlow);
            this.Controls.Add(this.lstFormatExeption);
            this.Controls.Add(this.lstOnay);
            this.Controls.Add(this.btnOnaylaDetayYonetim);
            this.Controls.Add(this.btnDetayli);
            this.Controls.Add(this.btnOnaylaYonetimli);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtDeger);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnOnaylaYonetimli;
        private System.Windows.Forms.Button btnDetayli;
        private System.Windows.Forms.Button btnOnaylaDetayYonetim;
        private System.Windows.Forms.ListBox lstOnay;
        private System.Windows.Forms.ListBox lstFormatExeption;
        private System.Windows.Forms.Button btnOnaylaLog;
        private System.Windows.Forms.ListBox lstOverFlow;
    }
}

