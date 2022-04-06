using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int rastgele;
        int sayi;
        int tahminhak;
        int girilensayi;
        int tutulansayi;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            rastgele = rnd.Next(1, 11);
            label7.Text=rastgele.ToString();
            tutulansayi=Convert.ToInt32(label7.Text);
            label2.Text = "1 ile 10 arasında bir değer girin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sayi=Convert.ToInt32(textBox1.Text);

            

            if (sayi < tutulansayi)
            {
                label2.Text = "Lütfen daha büyük bir sayı giriniz";
                tahminhak = Convert.ToInt32(label3.Text);
                label3.Text = Convert.ToString(tahminhak - 1);
                listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text);
            }
            else if (sayi > tutulansayi)
            {
                
                label2.Text = "Lütfen daha küçük bir sayı giriniz";
                tahminhak = Convert.ToInt32(label3.Text);
                label3.Text = Convert.ToString(tahminhak - 1);
                listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text);
            }
            else
            {
                sayi = tutulansayi;
                
               
                label3.Text = Convert.ToString(5);
                listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text + "Tebrikler doğru tahmin");
                
                label4.Text = "2";
                textBox1.Text = "";
                rastgele = rnd.Next(1, 21);
                label7.Text = rastgele.ToString();
                tutulansayi = Convert.ToInt32(label7.Text);
                
                if (sayi < tutulansayi)
                {
                    
                    label2.Text = "Lütfen daha büyük bir sayı giriniz";


                    tahminhak = Convert.ToInt32(label3.Text);
                    label3.Text = "5";
                    
                }
                else if (sayi > tutulansayi)
                {
                    label2.Text = "Lütfen daha küçük bir sayı giriniz";
                    tahminhak = Convert.ToInt32(label3.Text);
                    label3.Text = Convert.ToString(tahminhak - 1);
                    listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text);
                }
                else
                {
                    sayi = tutulansayi;
                    label2.Text = "Tebrikler doğru tahmin";
                    label2.Text = "";
                    label3.Text = Convert.ToString(5);
                    listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text + "Tebrikler");
                    label4.Text = "3";
                    textBox1.Text = "";
                    rastgele = rnd.Next(20, 31);
                    label7.Text = rastgele.ToString();
                    tutulansayi = Convert.ToInt32(label7.Text);
                    if (sayi < tutulansayi)
                    {
                        tahminhak = Convert.ToInt32(label3.Text);
                        label3.Text = "5";
                    }
                    else if (sayi > tutulansayi)
                    {
                        label2.Text = "Lütfen daha küçük bir sayı giriniz";
                        tahminhak = Convert.ToInt32(label3.Text);
                        label3.Text = Convert.ToString(tahminhak - 1);
                        listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text);
                    }
                    else
                    {
                        sayi = tutulansayi;
                        label2.Text = "Tebrikler doğru tahmin";
                        label2.Text = "";
                        label3.Text = Convert.ToString(5);
                        listBox1.Items.Add("Tahmin edilen: " + sayi + " Seviye :" + label4.Text + "Tebrikler");
                    }
                }

            }
            
               







        }
    }
}
