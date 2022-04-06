using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AllButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is Button)
                {
                    Button btn=(Button)ctrl;
                    if(btn.Name != "btndegistir")
                    {
                        btn.BackColor = Color.Red;
                    }
                    
                    
                    
                }

            }
        }
    }
}
