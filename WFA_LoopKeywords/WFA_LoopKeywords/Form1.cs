using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LoopKeywords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Döngü kaçış kelimeleri
        private void button1_Click(object sender, EventArgs e)
        {
            //Break
            /*
             Bir döngü içerisinde koşullara sahipseniz ve koşulunuz sağlandığı takdirde döngüye devam etme gereği duymayacaksanız break anahtar kelimesi ile döngüyü sonlandırabiliriz.
             
             */

            // 1 den 100 e kadar rakalmları listbox a ekleyin 50 olduğunda eklenmesin

            for (int i= 1; i <= 100; i++)
            {
                if (i == 50)
                {
                    listBox1.Items.Add(i);

                    break;
                }
                else
                {
                    listBox1.Items.Add(i);
                }

            }
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            //continue -- Döngümüz içerisinde herhangi bir şartın sağlanması durumunda işlemlerimize devam edebilmek için kullanmış olduğumuz anahtar kelimedir. 

            Random rnd=new Random();
            for(int i =1; i <= 10; i++)
            {
                int rastgele =rnd.Next(1,16);
                if (listBox1.Items.Contains(rastgele))
                {
                    i--;
                    continue;
                }
                else
                {
                    listBox1.Items.Add(rastgele);
                }
                    
                
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            //return
            /*
             Döngümüz içeriisnde belirtilen şart sağlanıyorsa döngünün bağlı bulunduğu event (olay) yı terkeder.
             */
        }
    }
}
