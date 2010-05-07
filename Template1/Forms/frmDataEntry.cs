 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmDataEntry : Form
    {
        public bool isClosing = false;

        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isClosing = true;
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmDataEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prevents the close button of form to perform close
            if (!isClosing)
            {
                e.Cancel = true;
                return;
            }
            isClosing = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

            isClosing = true;
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}