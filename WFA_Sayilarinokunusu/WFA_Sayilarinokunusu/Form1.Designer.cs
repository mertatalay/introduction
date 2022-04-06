namespace WFA_Sayilarinokunusu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnoku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1029, 44);
            this.textBox1.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(509, 145);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(1029, 345);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "label1";
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnoku
            // 
            this.btnoku.Location = new System.Drawing.Point(1654, 65);
            this.btnoku.Name = "btnoku";
            this.btnoku.Size = new System.Drawing.Size(314, 107);
            this.btnoku.TabIndex = 2;
            this.btnoku.Text = "oku";
            this.btnoku.UseVisualStyleBackColor = true;
            this.btnoku.Click += new System.EventHandler(this.btnoku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2521, 1148);
            this.Controls.Add(this.btnoku);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnoku;
    }
}

