using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Array(ilkel diziler)

            /*
                  aynı tip(int,string,byte vs..) verileri tek bir yapı altında tutmamıza olanak sağlayan yapılardır  
             
             
             */

            //1.yol
            int[] sayilar = new int[3];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            

           // MessageBox.Show(sayilar[3].ToString());

            //2.yol

            string[] sehirler = { "istanbul", "Ankara", "İzmir" };
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //ekle butonuna basıldıktan sonra sehirleri listbox a ekleyin

            string[] cities = { "Londra", "Amsterdam", "Berlin", "Roma" };

            for (int i = 0; i <cities.Length; i++) 
            {
                string city = cities[i];

                listBox1.Items.Add(city);

                //length ile karakter uzunluğundan yararlaanarak dinamik bir yapı elde ederiz.bu sayede array içerisine istediğimiz kadar değer ekleyebiliriz.

            }
        }

        private void btnenkucuksayi_Click(object sender, EventArgs e)
        {
            //-34,-5,-768,467,657,-999,-324 bu sayılarından en küçük olanı bulun

            
            int[] sayi = { -34, -5, -768, -467,- 657, -999, -324, };
            int enkucuk = sayi[0];

              for(int i = 0; i < sayi.Length; i++)
            {
                if (enkucuk>sayi[i])
                {
                    enkucuk = sayi[i];
                }
                

                

            }
            MessageBox.Show(enkucuk.ToString());


        }
    }
}
