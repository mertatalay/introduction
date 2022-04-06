using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehirler = { "Bayburt", "Yozgat", "Uşak", "Bileck" };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach== koleksiyon olarak adalandırılır. Kesinlikle iterasyon bulunmamaktadır. Tip bağımlı bir döngüdür.

            foreach(string sehir in sehirler)
            {
              //  MessageBox.Show(sehir);
            }


        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            //127,54,76,876,4532,75,85,45,190
            //yukarıdaki sayılardan ikiye tam bölünenleri listbox 1  e tam bölünmeyenleri listbox 2 ye aktarın.daha sonra da hem 2 ye hem 3 e bölünenlerin kaç adet olduğunu mesaj kutusunda gösterin

            int[] sayilar = { 127, 54, 76, 876, 4532, 75, 85, 45, 190 };
            foreach(int sayi in sayilar)
            {
               int sonuc = sayi % 2;
                if(sonuc == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }

                
            }
            foreach(int sayi1 in listBox1.Items)
            {
                int sonuc1 = sayi1 % 6;
                if (sonuc1 == 0)
                {
                    MessageBox.Show(sayi1.ToString());
                }
            }

        }
    }
}
