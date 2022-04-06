using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Atyarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ileri;
        Random rnd=new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //PBAT1.RİGHT = 10 // bir tool u sadece sol (left) ve alt(bottom özelliklerine değer ataması gerçekleştirilir. sağ(right) ve üst(top) değerleri sadece okunabilir.
            timer1.Start();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atları koşturma
            pbat1.Left += rnd.Next(10, 30);
            pbat2.Left += rnd.Next(10, 30);
            pbat3.Left += rnd.Next(10, 30);
            if(pbat1.Right>pbat2.Right && pbat1.Right > pbat3.Right)
            {
                label5.Text=("1.at önde" + pbat1.Right.ToString());
            }
            else if(pbat2.Right>pbat3.Right && pbat2.Right > pbat1.Right)
            {
                label5.Text = ("2.at önde" + pbat2.Right.ToString());
            }
            else if(pbat3.Right>pbat1.Right && pbat3.Right > pbat2.Right)
            {
                label5.Text = ("3.at önde" + pbat3.Right.ToString());

            }
            //uygulama start olduğunda üç farklı zemin renginden bir tanesi tanımlansın;
            //kahverengi
            //yeşil
            //gri
            //zemin rengi kahverengi ise 1. at kazansın
            //yeşil ise 2. at
            //gri ise 3.at


            //Kazanma Durumu
            if (pbat1.Right >= label4.Left)
            {
                timer1.Stop();
                DialogResult dr= MessageBox.Show("1.at kazandı!\n Tekrar oynamak şster misiniz?","oyun bitti",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(dr== DialogResult.Yes)
                {
                    pbat1.Left = 12;
                    pbat2.Left = 12;
                    pbat3.Left = 12;
                }
                else
                {
                    Application.Exit();
                }

            }
            else if(pbat2.Right >= label4.Right)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("1.at kazandı!\n Tekrar oynamak şster misiniz?", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbat1.Left = 12;
                    pbat2.Left = 12;
                    pbat3.Left = 12;
                }
                else
                {
                    Application.Exit();
                }
            }
            else if(pbat3.Right >= label4.Right)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("1.at kazandı!\n Tekrar oynamak şster misiniz?", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbat1.Left = 12;
                    pbat2.Left = 12;
                    pbat3.Left = 12;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
