using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Sayilarinokunusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnoku_Click(object sender, EventArgs e)
        {

            string[] birlerbasamagi = { "","bir", "iki", "üç", "dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlarbasamagi = { "","On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

            try
            {
                int gelensayi = Convert.ToInt32(textBox1.Text);
                int birler = gelensayi % 10;
                int onlar = gelensayi / 10;
                string format = onlarbasamagi[onlar] + "" + birlerbasamagi[birler];
                lblresult.Text = format;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            







        }
    }
}
