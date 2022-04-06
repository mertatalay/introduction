using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Geriyedegerdonduren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string deger = "admin";
        string kontrolet(string metin)
        {
            string mesaj = "";
            if (metin == deger)
            {
                mesaj = "Hoşgeldin admin";
            }
            else
            {
                mesaj = "Seni tanımıyorum";

            }
            return mesaj;

        }

        
        
        int topla()
        {
            int sayi1 = 10;
            int sayi2 = 10;
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        private void btntopla_Click(object sender, EventArgs e)
        {
            //Geriye Değer Döndüren Metot
                 //Parametre alan
                 //Parametre almayan   


            int toplamsonuc=topla();
            MessageBox.Show(toplamsonuc.ToString());
        }

        private void btnkontrol_Click(object sender, EventArgs e)
        {
           MessageBox.Show()
        }
    }
}
