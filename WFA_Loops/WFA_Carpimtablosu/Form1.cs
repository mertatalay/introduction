using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Carpimtablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklendiğinde 1 den 10 a kadar çarpım tablosunu listbox a ekleyin.

            /*
             1*1=1
            1*2=


            2*1=2
            2*2=4


             */
            int sonuc=0;
            

            for(int carpan=1; carpan<10; carpan++)
            {
                for(int sayi=1; sayi<10; sayi++)
                {
                    sonuc = sayi * carpan;
                    string format = string.Format(" {0} * {1}={2} ", sayi, carpan, sonuc);
                   

                    



                    listBox1.Items.Add(format);

                }

                

               
            }
            
            

        }
    }
}
