using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Geriyedegerdonduren
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        //Metot

        Color rastgelerenk()
        {
            Random c = new Random();
            
            Color rastgelerenk = Color.FromArgb(c.Next(0, 256), c.Next(0, 256), c.Next(0, 256));
            return rastgelerenk;
        }
        Color rastgelerenk(int red, int green, int blue)
        {
            Color rastgelerenk =Color.FromArgb(red, green, blue);
            return rastgelerenk;
        }
        

       
        
        private void btnrenk_Click(object sender, EventArgs e)
        {
            lblrenk.BackColor=rastgelerenk();
        }

        private void lblrenk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int kirmizi = 100;
            int yesil = 50;
            int mavi = 40;
           label1.BackColor=rastgelerenk(kirmizi,yesil,mavi);
        }

        private void scrollred_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text =scrollred.Value.ToString();    
        }

        private void scrollgreen_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text =scrollgreen.Value.ToString();
        }

        private void scrollblue_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text =scrollblue.Value.ToString();
        }
    }
}
