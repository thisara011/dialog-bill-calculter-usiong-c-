using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog_bill_calculter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            double day, night,cost, total;
            day = Convert.ToDouble(txt_2.Text);
            night = Convert.ToDouble(txt_3.Text);

            if(cmb_1.SelectedIndex == 0 ) 
            {
                if (day <= 50 && night <= 10)
                {
                    cost = 800;
                }
                else if (day > 50 && night <= 10)

                { cost = ((day - 50) * 10) + 800; }

                else if(day >= 50 && night < 10)
                {
                    cost = ((night - 10) * 20) + 800;
                 }
                else 
                {
                    cost = ((night - 10) * 20) + ((day - 50) * 10) + 800;
                }

                if (cost <= 1000)
                { total = cost + 250;
                }
                else
                { total = cost + 350;
                }
                txt_4.Text = Convert.ToString(total);

            }
            else if (cmb_1.SelectedIndex == 1)
            {
                if (day <= 10 && night <= 100)
                {
                    cost = 1200;
                }
                else if (day > 10 && night <= 100)

                { cost = ((day - 10) * 20) + 1200; }

                else if (day >= 10 && night < 100)
                {
                    cost = ((night - 10) * 10) + 1200;
                }
                else
                {
                    cost = ((night - 100) * 20) + ((day - 10) * 20) + 1200;
                }

                if (cost <= 1500)
                {
                    total = cost + 350;
                }
                else
                {
                    total = cost + 450;
                }
                txt_4.Text = Convert.ToString(total);
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_2.Clear();
            txt_3.Clear();
            txt_4.Clear();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
