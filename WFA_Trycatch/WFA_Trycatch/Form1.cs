using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Trycatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(sayi.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try catch(dene ve yakala)
            //try bloğu içerisinde hata olabilecek işlemler yeralmalıdır. Örneğin kullanıcıdan alınan bir değerin convert sınıfı ile farklı bir tipe dönüştürülmesi gibi. bu durumda kullanıcı tip dönüşümlerine hakim olmadığı için text box içerisine diledğiği herhangi bir metni girebiliri. bu durumda convert snıfı dönüştürme eylemi 

            try
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(sayi.ToString());
            }
            catch
            {
                MessageBox.Show(sayi.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //meydana gelen herhangi bir hatada catch bloğu devreye girmektedir. ancak hatanın sebebini 


        }

        private void button4_Click(object sender, EventArgs e)
        {//format exception
            //overflowexception
            //dividbyzeroexception
            //custom
            try
            {
                int sayi=Convert.ToInt32(textBox1.Text);
                MessageBox.Show(sayi.ToString());

            }
            catch(FormatException)//format hatası
            {
                MessageBox.Show("format hatası");

            }
            catch (OverflowException)//değer aşımı hatası
            {
                MessageBox.Show(int.MinValue + " " + int.MaxValue + " " + "değerini aştınız");
            }
            catch (DivideByZeroException)//sıfıra bölünme hatası
            {

            }
            finally
            {
                MessageBox.Show("veritabaına kaydedildi");
            }
        }
    }  
}
