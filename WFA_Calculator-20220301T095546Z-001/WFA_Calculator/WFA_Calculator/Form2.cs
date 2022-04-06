using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = numericUpDown1.Value * numericUpDown2.Value;
            label3.Text = Convert.ToString(sonuc);
            listBox1.Items.Add(label3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = numericUpDown1.Value + numericUpDown2.Value;
            label3.Text = Convert.ToString(sonuc);
            listBox1.Items.Add(label3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = numericUpDown1.Value - numericUpDown2.Value;
            label3.Text = Convert.ToString(sonuc);
            listBox1.Items.Add(label3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Decimal sonuc;
            sonuc = numericUpDown1.Value / numericUpDown2.Value;
            label3.Text = Convert.ToString(sonuc);
            listBox1.Items.Add(label3.Text);
        }
    }
}
