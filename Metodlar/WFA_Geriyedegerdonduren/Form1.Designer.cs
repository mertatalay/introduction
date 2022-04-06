namespace WFA_Geriyedegerdonduren
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
            this.btntopla = new System.Windows.Forms.Button();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.btnkontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntopla
            // 
            this.btntopla.Location = new System.Drawing.Point(127, 164);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(296, 119);
            this.btntopla.TabIndex = 0;
            this.btntopla.Text = "Topla";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // txtdeger
            // 
            this.txtdeger.Location = new System.Drawing.Point(900, 66);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(195, 44);
            this.txtdeger.TabIndex = 1;
            // 
            // btnkontrol
            // 
            this.btnkontrol.Location = new System.Drawing.Point(900, 141);
            this.btnkontrol.Name = "btnkontrol";
            this.btnkontrol.Size = new System.Drawing.Size(195, 60);
            this.btnkontrol.TabIndex = 2;
            this.btnkontrol.Text = "kontrol et";
            this.btnkontrol.UseVisualStyleBackColor = true;
            this.btnkontrol.Click += new System.EventHandler(this.btnkontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2339, 1081);
            this.Controls.Add(this.btnkontrol);
            this.Controls.Add(this.txtdeger);
            this.Controls.Add(this.btntopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.Button btnkontrol;
    }
}

