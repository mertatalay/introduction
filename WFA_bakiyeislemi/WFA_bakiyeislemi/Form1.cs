using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_bakiyeislemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal bakiye;
        int miktar;
        decimal cek;
        decimal cekilentutar;
        decimal kalan;
        decimal sayibir;
        decimal sayiiki;
        decimal avtoplam;
        decimal ekmek = 4;
        decimal yumurta = 4;
        decimal cay = 35;
        decimal cikolata = 30;
        decimal peynir = 45;
        decimal deger,deger1,deger2,deger3,deger4;
       
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            bakiye = Convert.ToDecimal(label2.Text="500");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            decimal sayibir = numericUpDown1.Value;

            if (sayibir <= bakiye)
            {
                bakiye = bakiye - sayibir;
                label2.Text = bakiye.ToString();
                listBox1.Items.Add("Çekilen Tutar" + sayibir + "---- " + "Bakiye" + bakiye);
            }
            else if (bakiye == 0)
            {
                button1.Enabled = false;
            }

            else
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
            
           

           
            
            
               
            
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal sayiiki = numericUpDown2.Value;

            if (sayiiki >= 1)
            {
                bakiye = bakiye + sayiiki;
                label2.Text = bakiye.ToString();
                listBox1.Items.Add("Yatırılan Tutar" + sayiiki + "---- " + "Bakiye" + bakiye);
            }
            else
            {
                MessageBox.Show("1 tl den küçük değer girilemez");
            }
            
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                deger = ekmek;

            }
            else 
            {

                deger = 0;
                
            }
            if(checkBox2.Checked == true)
            {
                 deger1 = yumurta;
            }
            else
            {
                deger1 = 0;

            }
            if(checkBox3.Checked == true)
            {
                 deger2 = cay;
            }
            else
            {

                deger2 = 0;
            }
            if(checkBox4.Checked == true)
            {
                 deger3 = cikolata;
            }
            else
            {
                deger3 = 0;

            }
            if(checkBox5.Checked == true)
            {
                 deger4 = peynir;

            }
            else
            {
                deger4= 0;
                
                
            }
            avtoplam = deger + deger1 + deger2 + deger3 + deger4;
            if (avtoplam > bakiye)
            {
                MessageBox.Show("Yetersiz bakiye");
            }
            else
            {
                
                
                listBox2.Items.Add(avtoplam);
            }
            bakiye = bakiye - avtoplam;
            listBox1.Items.Add("Harcama: " + avtoplam + "Kalan Bakiye: "+bakiye);
            







            //listBox2.Items.Add("Ekmek: "+deger+"Yumurta: "+deger1+"Çay: "+ deger2+"Çikolata: "+deger3+"Peynir: "+deger4);


















        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
