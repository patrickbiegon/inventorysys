 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmManageRecord : Form
    {

        //USING A DELEGATES TO POINT THE REFRESHDATA FUNCTION OF frmManage Derivatives
        public delegate void MsgHandler(string msg);

        //create a static form
        protected static frmManageRecord thisform;

        public frmManageRecord()
        {
            InitializeComponent();
        }

        private void frmManageRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            thisform = null;
        }
    }
}