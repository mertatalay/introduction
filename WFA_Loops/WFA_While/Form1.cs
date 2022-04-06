using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Merhaba Dünya 1");
            listBox1.Items.Add("Merhaba Dünya 2");
            listBox1.Items.Add("Merhaba Dünya 3");
            listBox1.Items.Add("Merhaba Dünya 4");
            listBox1.Items.Add("Merhaba Dünya 5");

            //Döngüler bir işi bir koşul dahilinde tekrar tekrar yapmamızı sağlayan yapılardır.

            //int sayac = 1;
           // while (sayac <= 10)
           //{
            ////    listBox1.Items.Add(sayac.ToString());
              //  sayac++;
            //}

            int sayac1 = 1;
            string deger = "Merhaba Dünya";
            while(sayac1 <= 10)
            {
                string format = string.Format("index: {0} deger: {1}", sayac1, deger);
                listBox1.Items.Add(format);
                sayac1++;
            }
            
        }

        private void btntoplam_Click(object sender, EventArgs e)
        {
            int sayac = 1;
            int tektoplam = 0;
            int cifttoplam = 0;
            
            
            while (sayac <= 100)
            {
                
               
                if (sayac%2==0)
                {
                    cifttoplam += sayac;
                }
                
                else
                {
                    tektoplam += sayac;
                }
               sayac++;
            }
            label3.Text=tektoplam.ToString();
            label4.Text=cifttoplam.ToString();
        }

        private void btnfaktoriyel_Click(object sender, EventArgs e)
        {
            //kullanıcıdan alınan sayının faktöriyelini hesaplayın
            try
            {

             
            int a=Convert.ToInt32(txtfaktoriyel.Text);
            int sonuc = 1;

            while (a>1)
            {
                sonuc *= a;
                a--;
            }
            label6.Text = a.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        
    }
}
