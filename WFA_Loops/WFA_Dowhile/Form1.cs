using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //do while
            //do while, while döngüsü ile aynı yapıya sahiptir. Tek farkı , do whlie döngüsü koşul her ne olursa olsun en az birkez çalıştır.
            int i = 1;
            do
            {
                listBox1.Items.Add(i);
                i++;
            }
            while (i <= 100);
        }
    }
}
