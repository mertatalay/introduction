using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int backbrown, backgreen, backgray;
        //RAM'in çalışması yapısını araştırın.
        Random rnd = new Random();
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // pbAt1.Right = 10; //bir tool'u  sadece  sol (left) ve alt (bottom) özelliklerine değer ataması gerçekleştirilir. sağ (right) ve üst (top) değerleri sadece okunabilir (read only)
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(label4.Text);
            decimal bahis1 = a * yatir1deger.Value;
            label9.Text=Convert.ToString(bahis1);
            btnBaslat.Enabled=true;
            button2.Enabled=false;
            button3.Enabled=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(label4.Text);
            decimal bahis2 = a * yatir1deger.Value;
            label9.Text = Convert.ToString(bahis2);
            btnBaslat.Enabled = true;
            button1.Enabled=false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(label4.Text);
            decimal bahis3 = a * yatir1deger.Value;
            label9.Text = Convert.ToString(bahis3);
            btnBaslat.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atları koşturma
            if (BackColor == Color.Brown)
            {
                pbAt1.Left += rnd.Next(40, 50);
                pbAt2.Left += rnd.Next(10, 30);
                pbAt3.Left += rnd.Next(10, 30);
            }
            else if (BackColor == Color.Green)
            {
                pbAt1.Left += rnd.Next(25, 35);
                pbAt2.Left += rnd.Next(40, 60);
                pbAt3.Left += rnd.Next(10, 30);
            }
            else 
            {
                pbAt1.Left += rnd.Next(25, 35);
                pbAt2.Left += rnd.Next(20, 40);
                pbAt3.Left += rnd.Next(50, 60);
            }
            

            //Kazanma Durumu
            if (pbAt1.Right>=lblFinish.Left)
            {
               
                timer1.Stop();
              DialogResult dr=  MessageBox.Show("1. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr==DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbAt2.Right>=lblFinish.Left)
            {
                

                timer1.Stop();
                DialogResult dr = MessageBox.Show("2. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if(pbAt3.Right>=lblFinish.Left)
            {
                

                timer1.Stop();
                DialogResult dr = MessageBox.Show("3. at kazandı!\nTekrar Oynamak İster misin? :))", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }

            //Spiker
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            {
                lblSpiker.Text = "1. at önde gidiyor...";
            }
            else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            {
                lblSpiker.Text = "2. at önde gidiyor...";
            }
            else
            {
                lblSpiker.Text = "3. at önde gidiyor";
            }

            //uygulama start olduğunda üç farklı zemin renginden bir tanesini tanımlansın bunlar;
                //kahverengi
                //yeşil
                //gri
            // zemin rengi kahverengi ise 1. at kazansın.
            // zemin rengi yeşil ise 2. at kazansın.
            // zemin rengi gri ise 3. at kazansın.

            //yatir butonuna tıklanmadan yarış başlamayacak.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBaslat.Enabled= false;
            Random c = new Random();

            int color = c.Next(1, 4);
            if (color == 1)
            {
                BackColor = Color.Brown;
            }
            else if(color == 2)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Gray;
            }

            

            
        }
    }
}
