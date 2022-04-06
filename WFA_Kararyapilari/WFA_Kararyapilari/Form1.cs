using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kararyapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //CTRL+K+S kombinasyonu ile regiom oluşturabiliriz.


            bool check = checkBox1.Checked;
            if (check)
                MessageBox.Show("Şemsiyeni yanına al");
            else
            {
                MessageBox.Show("Güneş gözlüğünü al");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textbox a girilen değer admin veya mod ise message kutusunda hoş geldiniz. Değilse sizi tanımıyorum.

            string gelendeger = textBox1.Text.ToLower();
            bool sart = gelendeger == "admin" || gelendeger == "mod";
            if (sart)
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("sizi tanımıyorum");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textbox a girilen dğer admin ise hoşgeldin admin
            //mod ise hoşgeldin mod
            //user şse hoşgeldin kullanıcı
            //bunlar dışında ise seni tanımıyorum

            string gelendeger= textBox1.Text.ToLower();

            //karar yapısı

            if(gelendeger == "admin")
            {
                MessageBox.Show("hoşgeldin admin");
            }
            else if(gelendeger == "mod")
            {
                MessageBox.Show("hoşgeldin mod");
            }
            else if (gelendeger == "user")
            {
                MessageBox.Show("hoşgeldin kullanıcı");
            }
            else
            {
                MessageBox.Show("sizi tanımıyorum");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textbox a girilen deger 0 dan küçük olmayacak ve 100 den büyük olmayacak
            try
            {
                int deger = Convert.ToInt32(textBox1.Text);
                bool sart = deger < 100 && deger > 100;
                if (sart)
                {
                    MessageBox.Show("Tebrikler doğru tanımlama");
                }
                else if (deger < 0)
                {
                    MessageBox.Show("0 dan küçük değer giremezsiniz");

                }
                else if (deger > 100)
                {
                    MessageBox.Show("100 den büyük değer giremezsiniz");
                }






            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal değer girin");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //textbox vizenin %30 u 
            //textbox final in %70 ini alıp not ortalamasını bulun
            //not ortalaması 
            // 0 ile 30  arasında ff
            //31 ile 50 arasında dd
            //51 ile 70 arasında bb
            //71 ile 100 arasında aa
            //mesajını label da gösterin
            try
            {

                int vize, final;
                vize = Convert.ToInt32(textBox1.Text);
                final = Convert.ToInt32(textBox2.Text);
                double ortalama = (vize * 0.30) + (final * 70);
                string harfnotu = "";
                if (ortalama <=30)
                {
                    harfnotu = "ff";
                }
                else if (ortalama >= 31 && ortalama < 51)
                {
                    harfnotu = "dd";
                }
                else if (ortalama >= 51 && ortalama < 71)
                {
                    harfnotu = "dd";
                }
                else if(ortalama>=71 && ortalama <=100)
                {
                    harfnotu = "aa";
                }
                label3.Text = ortalama + harfnotu;
                    
            }
            
            
            
            
            catch
            {
                MessageBox.Show("Hata meydana geldi");
            }


            
           

            



        }
    }
    
}
