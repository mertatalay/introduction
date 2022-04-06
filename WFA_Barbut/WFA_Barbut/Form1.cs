using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rastgele;
        int rastgele1;
        int bakiye;
        int miktar1,miktar;
        int kazan, kazan1;
        int kalan, kalan1,kalan2,kalan3;
        Random rnd = new Random();
        private void btnzar1_Click(object sender, EventArgs e)
        {
            
             rastgele=rnd.Next(1,7);
            lblzar1.Text = rastgele.ToString();
            btnzar1.Enabled = false;
            btnzar2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnzar2.Enabled = false;
            btnzar1.Enabled = false;
        }

        private void btnzar2_Click(object sender, EventArgs e)
        {
            
            
            rastgele1 = rnd.Next(1,7);
            lblzar2.Text = rastgele1.ToString();
            btnzar2.Enabled = false;
            if (rastgele<rastgele1)
            {
                lblsonuc.Text = "2.oyuncu kazandı";
                kazan = miktar + miktar1 + Convert.ToInt32(label7.Text);
                label7.Text = Convert.ToString(kazan);
                
            }
            if(rastgele1<rastgele)             {
                lblsonuc.Text = "1.oyuncu kazandı";
                kazan1 = miktar + miktar1 + Convert.ToInt32(label2.Text);
               label2.Text=Convert.ToString(kazan1);

            }
            else
            {
                rastgele = rastgele1;
                btnzar1.Enabled = true;
                btnzar2.Enabled = true;

            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            miktar=Convert.ToInt32(numericUpDown5.Value.ToString());
            label10.Text=numericUpDown5.Value.ToString();
            kalan=Convert.ToInt32(label2.Text.ToString());
            kalan1 = kalan - miktar;
            label2.Text = Convert.ToString(kalan1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            miktar1 = Convert.ToInt32(numericUpDown6.Value.ToString());
           label10.Text = Convert.ToString( miktar+miktar1 );
            btnzar1.Enabled = true;
            kalan2 = Convert.ToInt32(label7.Text.ToString());
            kalan3 = kalan2 - miktar1;
            label7.Text = Convert.ToString(kalan3);
        }
    }
}
