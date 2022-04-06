using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Arackayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();
            #region Örnek
            // ListViewItem lvi = new ListViewItem(); //instance
            //lvi.Text = "Renault"; //0
            //lvi.SubItems.Add("Megane");//1
            //lvi.SubItems.Add("Benzin");//2
            //lvi.SubItems.Add("Otomatik");//3
            //listView1.Items.Add(lvi); 
            #endregion

            cmbmarka.Items.Add("Alfa Romeo");
            cmbmarka.Items.Add("Renault");
            cmbmarka.Items.Add("Ferrari");
            cmbmarka.Items.Add("Porsche");
            cmbmarka.Items.Add("Tesla");


            cmbyakit.Items.Add("Dizel");
            cmbyakit.Items.Add("Benzin");
            cmbyakit.Items.Add("Elektrik");


            cmbvites.Items.Add("Otomatik");
            cmbvites.Items.Add("Manuel");

            cmbmodel.Items.Add("Guilette");
            cmbmodel.Items.Add("159");
            cmbmodel.Items.Add("Megane");
            cmbmodel.Items.Add("Clio");
            cmbmodel.Items.Add("Panamera");
            cmbmodel.Items.Add("Model S");









        }

        private void cmbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodel.Items.Clear();
            switch (cmbmarka.Text)
            {
                case "Alfa Romeo":
                    cmbmodel.Items.Add("Guiletta");
                    cmbmodel.Items.Add("159");
                    break;
                case "Renault":
                    cmbmodel.Items.Add("Megane");
                    cmbmodel.Items.Add("Clio");
                    break;
                case "Ferrari":
                    cmbmodel.Items.Add("Ferrari");
                    break;
                case "Porsche":
                    cmbmodel.Items.Add("Panamera");
                    break;
                case "Tesla":
                    cmbmodel.Items.Add("Models");
                    break;



            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
              
            ListViewItem lvi = new ListViewItem();
            //// eğer subitemlarda bir stil işlemi dahil etmek istiyorsanız bu özelliği false olarak tanımlayalısnız
            lvi.Text = cmbmarka.Text;
            lvi.SubItems.Add(cmbmodel.Text);
            lvi.SubItems.Add(cmbyakit.Text);
            lvi.SubItems.Add(cmbvites.Text);
            lvi.SubItems.Add("");
            lvi.SubItems[4].BackColor=btnrenk.BackColor;
           
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString());
            listView1.Items.Add(lvi);
            lbladet.Text = listView1.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                MessageBox.Show("Renk seçildi");
                btnrenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
            //eğer listview içerisinde en az 1 adet item var ise; Not; count sayma işlemini 1 den başlatır.
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    //listview içeriisnde bulunan itemlardan seçili olanı kaldır.not selecteditems ın ,index numaralrı 1 den başlar.

                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    lbladet.Text= listView1.Items.Count.ToString();
                }


            }
            else
            {
                MessageBox.Show("Silinecek değer bulunamadı");
            }
        }
    }
}