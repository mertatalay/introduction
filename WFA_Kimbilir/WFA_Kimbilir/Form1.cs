using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kimbilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = { "EDEBALİ MERT ATALAY", "AZAD MAJIDLI", "SILA ŞİRİN ", "UMUT YILBAŞ ", "SARUHAN MERT DEMİRAY", "ONUR DOĞRU", "Emre Bektaşoğlu ", "ENES SERENLİ ", "KAAN ÜNAL ", "BAHADIR ARDA ", "MERT ÇINAR", "BURAK UYSAL ", "AHMET CANER TATLI ", "TUBA KARADUT BUĞDAY", "MAHMURE OKAN", "ARYA KAPIKIRAN", "BERK BASAT" };

        string[] Konular = { };
        Random rnd = new Random();
        int sayac = 30;
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)


        {
            
            

           
            for(int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
            
            
            




















        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            ListViewItem lvi = new ListViewItem();

            int sec=rnd.Next(0,isimler.Length);
            
            DialogResult dr = MessageBox.Show(isimler[sec], "seçildiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if(dr == DialogResult.Yes)
            {

                listView1.Items.Add((string)isimler[sec]);
                listBox1.Items.Remove(isimler[sec].ToString());
                timer1.Stop();
                sayac = 30;
                label1.Text=sayac.ToString();
                int puan = 5;
                lvi.SubItems.Add(puan.ToString());
            }
            else
            {
                timer1.Stop();
                label1.Text = sayac.ToString();
                sayac = 30;
                label1.Text = sayac.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();

            if(sayac == 0)
            {
                timer1.Stop();
            }
        }
    }
}
