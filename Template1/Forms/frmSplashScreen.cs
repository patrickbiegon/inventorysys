 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();

            //THE EFFECTS STARTS HERE
            this.CenterToScreen();
            this.Opacity = .01;
            tmrFader.Interval = 40;
            tmrFader.Enabled = true;
        }

        private void tmrFader_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + .01;
            if (this.Opacity == 1)
            {
                tmrFader.Enabled = false;
                Visible = false;
                Close();
            }
        }
    }
}