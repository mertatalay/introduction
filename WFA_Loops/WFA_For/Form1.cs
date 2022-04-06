using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // for döngüsü; bir işi belirli sayıda yapmamızı sağlyana döngüdür. döngü içerisinde döngünün başlangıç değeri, bitiş değeri ve artış miktarını doğrudan tanımlayabiliriz.

            for(int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            int sonuc = 1;
            for(int i = 1; i <= sayi; i++)
            {
                sonuc*=i;
            }
            label2.Text = sonuc.ToString();
        }

        private void btngeriyesay_Click(object sender, EventArgs e)
        {
            // listbox ın içerisine 1000 den 1 e kadar say

            for(int i = 1000; i >= 0; i--)
            {
                listBox2.Items.Add(i);
            }
        }

        private void btnalfabe_Click(object sender, EventArgs e)
        {
            //btnalfabe ye tıklantığında a dan z ye listbox a ekleyin.
            listBox1.Items.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                string format = string.Format("Harf:{0} kod:{1}", c, Convert.ToInt32(c));
                listBox1.Items.Add(Convert.ToString(format));
            }
                
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            //1 ile 100 arasındaki tek sayıların toplamı ile çift sayıların toplamının farklarının karesi kaçtır.

            int sonuc;
            int cifttoplam = 0;
            int tektoplam = 0;
            int fark;
            int kare;
            for(int i =1; i<=100; i++)
                
            {
                sonuc = i % 2;

                if (sonuc == 0)
                {
                    cifttoplam += i;
                }
                else
                {
                    tektoplam += i;
                }

                

            }
            fark = cifttoplam - tektoplam;
            kare = fark * fark;
            MessageBox.Show(kare.ToString());
        }
    }
}
