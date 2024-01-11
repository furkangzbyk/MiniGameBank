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
    public partial class Form5 : Form
    {


        int boruHızı = 8;
        int gravity = 10;
        int score = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            yakısıklıflappy.Top += gravity;
            BoruAlt.Left -= boruHızı;
            BoruUst.Left -= boruHızı;
            scoretext.Text = "Score: " + score;
            if (BoruAlt.Left < -150) {

                BoruAlt.Left = 800;
                score++;

            }
            if (BoruUst.Left < -180) {

                BoruUst.Left = 950;
                score++;
            }
            if (yakısıklıflappy.Bounds.IntersectsWith(BoruAlt.Bounds) || yakısıklıflappy.Bounds.IntersectsWith(BoruUst.Bounds) || yakısıklıflappy.Bounds.IntersectsWith(zemin1.Bounds) || yakısıklıflappy.Bounds.IntersectsWith(zemin2.Bounds) || yakısıklıflappy.Bounds.IntersectsWith(zemin3.Bounds)) {

                endGame();

            }

            if (score > 5) {
                boruHızı = 15;
            }
            if (yakısıklıflappy.Top < -25) {
                endGame();
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {

            gametimer.Stop();
            scoretext.Text = "Game Over!!!";

        }
    }
}
