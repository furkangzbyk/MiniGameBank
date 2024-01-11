using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBank
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int sure = 15;
        DialogResult deger;
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAZANDINIZ!!", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer2.Enabled = false;
        }

        private void Form7_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ", "KENARA DEĞDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sure==0)
            {
                timer2.Enabled = false; 
                deger=MessageBox.Show("SÜRE BİTTİ!","TEKRAR OYNAMAK İSTERMİSİNİZ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deger== DialogResult.Yes)
                {
                    sure = 15;
                    sure--;
                    timer2.Enabled=true;
                }
                else if (deger== DialogResult.No)
                {
                 this.Close();   
                }
                else
                {
                    sure--;
                    label4.Text = Convert.ToString(sure);
                    timer2.Enabled = true;   
                }

              

            }
        }
    }
}
