using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Geriyedegerdondurmeyen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void mesaj()
        {
            string mesajver = textBox1.Text;
            MessageBox.Show(mesajver);
        }
        void mesaj1()
        {
            MessageBox.Show("merhaba");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mesaj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj1();
        }
    }
}
