using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Labirentodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int geneltoplam;
        int toplam1;
        int toplam2;
        int toplam3;
        int toplam4;
        int toplam5;
        int toplam6;
        int toplam7;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("kaybettiniz");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            MessageBox.Show("kazandınız");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toplam1 = 2;
            button2.Visible = false;
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toplam2 = toplam1 + 2;
            
            
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toplam3 = toplam2 + 2;
            button5.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toplam4 = toplam3 + 2;
            button4.Visible = false;
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            label15.Text = Convert.ToString(Convert.ToInt32(8 + 2));
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toplam5 = toplam4 + 2;
            button6.Visible = false;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            toplam6 = toplam5 + 2;
            button8.Visible = false;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            toplam7 = toplam6 + 10;
            geneltoplam = toplam7;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_MouseHover_1(object sender, EventArgs e)
        {
            label15.Text = Convert.ToString(Convert.ToInt32(20 + 2));
            button9.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            
            label16.Text = textBox1.Text + " " + textBox2.Text;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            button7.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            label7.Visible= true;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label4.Visible = true;
            label13.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
            button9.Visible=true;
            button1.Visible = true;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
