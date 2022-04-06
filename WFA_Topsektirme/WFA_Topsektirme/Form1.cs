using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Topsektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hizdikey = 10;
        int hizyatay = 10;
        private void pbtop_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Left:
                    pbtop.Left -= hizyatay;

                    break;

                case Keys.Right:
                    
                  pbtop.Left +=  hizyatay;

                    break;

                case Keys.Up:

                    pbtop.Top -= hizdikey;

                    break;
                case Keys.Down:
                    pbtop.Top += hizdikey;

                    break;
                case Keys.D:
                    pbtop.Left += hizyatay;
                    

                    break;





                case Keys.S:
                    timer1.Stop();
                    break;
                


            }

            
                

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTop.Left += hizYatay;


            pbTop.Top += hizDikey;
        }
    }
}
