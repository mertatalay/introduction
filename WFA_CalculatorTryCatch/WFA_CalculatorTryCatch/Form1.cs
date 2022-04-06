using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_CalculatorTryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2;
        double toplam;
        
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                toplam = sayi1 + sayi2;
                label3.Text = toplam.ToString();
                listBox1.Items.Add("toplama: " + toplam);
            }
            catch(FormatException ex)
            {
                label4.Visible = true;
                label4.Text = ex.Message;
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text+""+ex.Message);
            }
            catch(OverflowException ex)
            {
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text + "" + ex.Message);
            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cikarma;
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                cikarma = sayi1 - sayi2;
                label3.Text = cikarma.ToString();
                listBox1.Items.Add("Çıkarma: " + cikarma);
            }
            catch (FormatException ex)
            {
                label4.Visible = true;
                label4.Text = ex.Message;
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text + "" + ex.Message);
            }
            catch (OverflowException ex)
            {
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text + "" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int carp;
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                carp = sayi1 * sayi2;
                label3.Text = carp.ToString();
                listBox1.Items.Add("Çarpma: " + carp);
            }
            catch (FormatException ex)
            {
                label4.Visible = true;
                label4.Text = ex.Message;
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text + "" + ex.Message);
            }
            catch(OverflowException ex)
            {
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text + "" + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int bol;
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                bol = sayi1 / sayi2;
                label3.Text = bol.ToString();
                listBox1.Items.Add("Bölme: " + bol);
            }
            catch (Exception ex)
            {
                label4.Visible = true;
                label4.Text = ex.Message;
                listBox2.Items.Add(textBox1.Text + "" + textBox2.Text + "" + ex.Message);
            }
            
            
               
            



        }
        
    }
}
