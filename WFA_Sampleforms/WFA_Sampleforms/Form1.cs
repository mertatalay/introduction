using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Sampleforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsayibir_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void txtsayiiki_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayibir = 0;
            int sayiiki = 0;
            int toplam = 0;
            sayibir = Convert.ToInt32(txtsayibir.Text);
            sayiiki = Convert.ToInt32(txtsayiiki.Text);
            toplam = sayibir + sayiiki;
            listBox2.Items.Add(toplam);
           
            

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
           
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           // int sayibir = 0;
            //int sayiiki = 0;
           // int toplam = 0;
           // sayibir = Convert.ToInt32(txtsayibir.Text);
            //sayiiki=Convert.ToInt32(txtsayiiki.Text);
           // toplam = sayibir + sayiiki;
           // MessageBox.Show(toplam.ToString());
           // button1.Visible = false;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string ad, soyad, sehir;
            lblad.Text = txtad.Text;
            lblsoyad.Text = txtsoyad.Text;
            lblsehir.Text=txtsehir.Text;
            listBox3.Items.Add(lblad.Text);
            listBox3.Items.Add(lblsoyad.Text);
            listBox3.Items.Add(lblsehir.Text);

            txtad.Text ="" ;
            txtsoyad.Text = "";
            txtsehir.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;
            MessageBox.Show(
        }
    }
}
