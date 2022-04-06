using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Derleme Hataları (Syntax Errors)
            //Çalışma zamanı hataları (Runtime errors)
            //Mantıksal hatalar (Logical errors) => 100% yazılımcı kaynaklı hatalardır.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //break point => duraklama noktası
           
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtDeger.Text);
            MessageBox.Show(sayi.ToString());
        }

        private void btnOnaylaYonetimli_Click(object sender, EventArgs e)
        {
            //Try Catch (dene ve yakala)
            //try bloğu içerisinde hata olabilecek işlemler yeralmalıdır. Örneğin kullanıcıdan alınan bir değerin convert sınıfı ile farklı bir tipe dönüştürülmesi gibi. bu durumda kullanıcı tip dönüşümlerine hakim olmadığı için text box içerisine dilediği herhangi bir metni girebilir. Bu durumda convert sınıfı dönüştürme eylemini gerçekleştiremeyeceği için uygulama runtime hatası verir. Bu durum bizim aslında hiç istemediğimiz bir durum olduğundan bu tip işlemlerde kesinlikle try catch bloğu kullanılmalıdır. 
            //catch bloğu try içerisinde meydana gelen hatanın ardından devreye giren kod alanıdır. Bu alan içerisinde kullanıcıyı yönlendirebilir, değeri farklı bir yerde saklayabilir, log kayıtlarına aktarabilir ya da istersek farklı bir kod akışından devam ettirebiliriz.


            try
            {
                int sayi = Convert.ToInt32(txtDeger.Text);
                MessageBox.Show(sayi.ToString());
            }
            catch
            {
                MessageBox.Show("bir hata meydana geldi!");
            }


        }

        private void btnDetayli_Click(object sender, EventArgs e)
        {
            //meydana gelen herhangi bir hatada catch bloğu devreye girmektedir. Ancak hatanın sebebini doğrudan görmek ya da o sebebe göre kod akışını yönlendirmek istersek bu durumda aşağıda kullanmış olduğumuz gibi catch (Exeption ex) parametresini tanımlayabiliriz. Exeption genel hataları temsil etmektedir. ex parametresi içerisinde bulunan message isimli değişken sayesinde alınan hatanın mesajı doğrudan kullanıcıya iletilir.
            try
            {
                int sayi = Convert.ToInt32(txtDeger.Text);
                MessageBox.Show(sayi.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOnaylaDetayYonetim_Click(object sender, EventArgs e)
        {
            //FormatException
            //OverFlowExeption
            //DivideByZeroException
            //Custom

            try
            {
                int sayi = Convert.ToInt32(txtDeger.Text);
                MessageBox.Show(sayi.ToString());
            }
            catch(FormatException)//format hatası
            {
                MessageBox.Show("Format Hatası");
            }
            catch (OverflowException)//değer aşımı hatası
            {
                MessageBox.Show(int.MinValue+" "+int.MaxValue+" değerini aştınız!");
            }
            catch (DivideByZeroException)//sıfıra bölünme hatası
            {
                MessageBox.Show("sıfıra bölme işlemi yapılamaz!");
            }
            finally
            {
                MessageBox.Show("işlem veritabanına kaydedil!");
            }
        }

        private void btnOnaylaLog_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                int sayi1 = Convert.ToInt32(txtDeger.Text);
                lstOnay.Items.Add(sayi1);

            }
            catch (FormatException)
            {
                MessageBox.Show("format hatası meydana geldi");
                lstFormatExeption.Items.Add(txtDeger.Text);
            }
            catch(OverflowException)
            {
                MessageBox.Show("Değer aşımı hatası meydana geldi");
                lstOverFlow.Items.Add(txtDeger.Text);

            }
        }
    }
}
