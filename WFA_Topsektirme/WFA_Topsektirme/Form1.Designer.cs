namespace WFA_Topsektirme
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
            this.components = new System.ComponentModel.Container();
            this.pbtop = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbtop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbtop
            // 
            this.pbtop.Image = global::WFA_Topsektirme.Properties.Resources.pngwing_com;
            this.pbtop.Location = new System.Drawing.Point(847, 225);
            this.pbtop.Name = "pbtop";
            this.pbtop.Size = new System.Drawing.Size(235, 218);
            this.pbtop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtop.TabIndex = 0;
            this.pbtop.TabStop = false;
            this.pbtop.Click += new System.EventHandler(this.pbtop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2893, 1208);
            this.Controls.Add(this.pbtop);
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.timer1_Tick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbtop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbtop;
        private System.Windows.Forms.Timer timer1;
    }
}

