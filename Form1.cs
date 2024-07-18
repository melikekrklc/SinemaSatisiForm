using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formuygörn13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa = 0; //global yapmazsak bunu her butona bastığımızda kasa tutarı sıfırlanır . DİKKAT!!!
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            int mısır, su, cips, bilet;

            mısır = Convert.ToInt32(textBoxmısır.Text);
            su = Convert.ToInt32(textBoxsu.Text);
            cips = Convert.ToInt32(textBoxcips.Text);
            bilet = Convert.ToInt32(textBoxbilet.Text);

            toplam = (mısır * 10) + (su * 5) + (cips * 15) + (bilet * 20);
            label6.Text = "Toplam:" + toplam + " " + "TL";

            kasa = kasa + toplam;
            label7.Text = "Kasa Tutarı:" + kasa + " " + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxmısır.Text = " ";
            textBoxsu.Text = " ";
            textBoxcips.Text = " ";
            textBoxbilet.Text = " ";
            label6.Text = "Toplam:00 TL";
        }
    }
}
