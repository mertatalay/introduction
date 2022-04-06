using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global alan
        //değişkenlerin tanımlanması
        private void btnTopla_Click(object sender, EventArgs e)
        {
            //numeric up down her zaman bize değeri decimal olarak teslim eder.

            Decimal sonuc;
            sonuc = nudToplaSayi1.Value + nudToplaSayi2.Value;
            lblToplam.Text=Convert.ToString(sonuc);

            

            

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = nudCikarSayi1.Value - nudCikarSayi2.Value;
            lblCikarma.Text = Convert.ToString(sonuc);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = nudCarpSayi1.Value * nudCarpSayi2.Value;
            lblCarp.Text = Convert.ToString(sonuc);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = nudBolSayi1.Value / nudBolSayi2.Value;
            lblBol.Text = Convert.ToString(sonuc);
        }
    }
}
