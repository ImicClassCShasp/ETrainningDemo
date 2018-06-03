using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eCenterTrainning
{
    public partial class frmFlashScreen : Form
    {
        public frmFlashScreen()
        {
            InitializeComponent();
        }
        double counterTick = 0.02;
        private void timerShow_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > counterTick * 5)
                this.Opacity -= counterTick;
            else
            {
                ((Timer)sender).Enabled = false;
                ((Timer)sender).Stop();
                this.Close();
            }
        } 
        private void frmFlashScreen_Shown(object sender, EventArgs e)
        {
            timerShow.Start();
        }
    }
}
