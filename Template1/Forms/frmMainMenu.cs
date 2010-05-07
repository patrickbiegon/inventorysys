using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Template1.Forms;

namespace Template1
{
    public partial class frmMainMenu : Form
    {
        private frmMain.MsgHandler Selected; 

        public frmMainMenu(frmMain.MsgHandler s)
        {
            InitializeComponent();
            Selected = s; 
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
       /*     //PUT SOME  CODE TO FILTER WHICH DATA IS SELECTED
            if (listView1.SelectedItems[0].Text == "Manage Supplier")
            {
                Selected("manageSupplier");
            }
            else if (listView1.SelectedItems[0].Text == "Manage Product")
            {
                Selected("manageProduct");
            }
            else if (listView1.SelectedItems[0].Text == "Manage Customer")
            {
                Selected("manageCustomer");
            }
            else if (listView1.SelectedItems[0].Text == "Manage Employee")
            {
                Selected("manageEmployee");
            }
            else if (listView1.SelectedItems[0].Text == "Manage Shipper")
            {
                Selected("manageShipper");
            }*/
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {
            Selected("manageSupplier");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmployee_Click(object sender, EventArgs e)
        {
            Selected("manageProduct");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Selected("manageCustomer");
        }

        private void lblPayroll_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            Selected("manageEmployee");
        }

        private void lblSecurity_Click(object sender, EventArgs e)
        {
            Selected("manageShipper");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.ShowDialog(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        public String str;
        private void label2_Click(object sender, EventArgs e)
        {
            
            if (str != "ADMIN")
                MessageBox.Show("Access Denied" + str);
            else
            {
                frmTransaction f = new frmTransaction();
                f.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}