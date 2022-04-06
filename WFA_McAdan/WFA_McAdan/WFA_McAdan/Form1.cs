using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string metin = "";
        int ekstra(int sos)
        {
            foreach (CheckBox box in groupBox1.Controls)
            {
                sos = +sos;
                
                if (box.Checked == true)
                {
                    metin=box.Text;
                    sos = +2;
                }
                else
                {
                    

                }


            }
            return sos;
        }
       

       
        int whooper = 25;
        int stackhouse = 35;
        int tavuklu = 20;
        int kucuk = 0;
        int orta = 3;
        int buyuk = 5;
        
        int toplamtutar;
        int deger,deger1,deger2,deger3,deger4,deger5;
        int sos;

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            
            DialogResult dr=MessageBox.Show("Siparişi onaylamak istediğinizden emin misiniz?", "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                ListViewItem lvi = new ListViewItem();
               
                
                
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Sipairşiniz iptal edildi");
            }
            
           

        }

        string[] ekstralar = { "ketçap", "Mayonez", "Ranch", "Buffalo", "Chaddar", "S.Mayonez" };
        string[] ebatlar = { "küçük", "orta", "büyük" };
        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("Whooper Menu");
            cmbMenu.Items.Add("stackhouse Menu");
            cmbMenu.Items.Add("Tavuklu Bişey Menu");
            rbKucuk.Checked = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
            int adet = Convert.ToInt32(nudAdet.Value);

            if (cmbMenu.SelectedIndex == 0)
            {
                if (rbKucuk.Checked==true)
                {
                    toplamtutar = (whooper + kucuk + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(),rbKucuk.Text.ToString(),metin,adet,toplamtutar);
                    listBox1.Items.Add(format);
                }
                else if (rbOrta.Checked == true)
                {
                    toplamtutar= (whooper + orta + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbOrta.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
                else
                {
                    toplamtutar = (whooper + buyuk + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbBuyuk.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }

            }
            if(cmbMenu.SelectedIndex == 1)
            {
                if (rbKucuk.Checked == true)
                {
                    toplamtutar = (stackhouse + kucuk + ekstra(sos)) * adet;
                    
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbKucuk.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
                else if (rbOrta.Checked == true)
                {
                    toplamtutar = (stackhouse + orta + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbOrta.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
                else
                {
                    toplamtutar = (stackhouse + buyuk + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbBuyuk.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
            }
            if (cmbMenu.SelectedIndex == 2)
            {
                if (rbKucuk.Checked == true)
                {
                    toplamtutar = (tavuklu + kucuk + ekstra(sos)) * adet;
                    
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbKucuk.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
                else if (rbOrta.Checked == true)
                {
                    toplamtutar = (tavuklu + orta + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbOrta.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
                else
                {
                    toplamtutar = (tavuklu + buyuk + ekstra(sos)) * adet;
                    string format = string.Format("Menü : {0}, Ebat Seçimi: {1}, Ekstralar: {2}, Adet: {3}, Fiyat: {4}", cmbMenu.Text.ToString(), rbBuyuk.Text.ToString(), metin, adet, toplamtutar);
                    listBox1.Items.Add(format);
                }
                
            }

            chkBuffalo.Checked = false;
            chkChaddar.Checked = false;
            chkKetcap.Checked = false;
            chkMayonez.Checked = false;
            chkRanch.Checked = false;
            chkSMayonez.Checked = false;
            foreach (Control ctrl in this.Controls)
            {
                
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }
                else if (ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    rb.Checked = false;
                    rbKucuk.Checked = true;
                }
            }







        }
    }
}
