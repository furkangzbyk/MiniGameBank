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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 fr = new Form7();
            fr.ShowDialog();
        }

        

      
    }
}
