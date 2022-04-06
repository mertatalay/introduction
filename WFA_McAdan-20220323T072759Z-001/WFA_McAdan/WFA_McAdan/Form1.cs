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
        int whooper = 25;
        int stackhouse = 35;
        int tavuklu = 20;
        int kucuk = 0;
        int orta = 3;
        int buyuk = 5;
        int ekstra = 2;
        int toplamtutar;
        int deger,deger1,deger2,deger3,deger4,deger5;

        string[] ekstralar = { "ketçap", "Mayonez", "Ranch", "Buffalo", "Chaddar", "S.Mayonez" };
        string[] ebat = { "küçük", "orta", "büyük" };
        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("whooper Menu");
            cmbMenu.Items.Add("Stackhouse Menu");
            cmbMenu.Items.Add("Tavuklu Bişey Menu");
            rbKucuk.Checked = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
            int adet = Convert.ToInt32(nudAdet.Value);


            if(cmbMenu.SelectedIndex == 0)
            {
                if (rbKucuk.Checked)
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (whooper + kucuk + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbKucuk.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
               
                    

                       
                    
                            
                    














                }
                else if (rbOrta.Checked)
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (whooper + orta + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbOrta.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }
                else
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (whooper + buyuk + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbBuyuk.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }

            }
            if(cmbMenu.SelectedIndex==1)
            {
                if (rbKucuk.Checked)
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (stackhouse + kucuk + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbKucuk.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }

                else if (rbOrta.Checked)
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (stackhouse + orta + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbOrta.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }
                else
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (stackhouse + buyuk + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbBuyuk.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }
            }
            if (cmbMenu.SelectedIndex == 2)
            {
                if (rbKucuk.Checked)
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (tavuklu + kucuk + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbKucuk.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }
                else if (rbOrta.Checked)
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (tavuklu + orta + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4} TL", cmbMenu.Text.ToString(), rbOrta.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                            }
                        }
                    }
                }
                else 
                {
                    foreach (Control kontrol in this.groupBox1.Controls)
                    {
                        if (kontrol is CheckBox)
                        {
                            if (((CheckBox)kontrol).Checked == true)
                            {



                                toplamtutar = (tavuklu + buyuk + ekstra) * adet;

                                string format = string.Format("{0},{1},{2},adet:{3},Fiyat:{4}  TL", cmbMenu.Text.ToString(), rbBuyuk.Text.ToString(), ((CheckBox)kontrol).Text.ToString(), adet, toplamtutar);

                                listBox1.Items.Add(format);
                                label14.Text = listBox1.Items.Add(format).ToString();
                            }
                        }
                    }
                }
            }












































        }
    }
}
