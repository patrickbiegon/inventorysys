using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmShipperDataEntry : frmDataEntry
    {
        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageShipper.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        #region Showing the form AS_
        public static void showAs_Add(frmManageShipper.MsgHandler msg)
        {
            dbAction = "add";
            modRefreshData = msg;
            frmShipperDataEntry f = new frmShipperDataEntry();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageShipper.MsgHandler msg, string[] obj)
        {
            modRefreshData = msg;
            frmShipperDataEntry f = new frmShipperDataEntry();
            f.textBox1.Text = obj[0];
            f.textBox2.Text = obj[1];
            f.textBox3.Text = obj[2];
     

            f.textBox1.ReadOnly = true;
            f.textBox2.ReadOnly = true;
            f.textBox3.ReadOnly = true;


            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Visible = false;
            f.btnCancel.Text = "Close";

            f.ShowDialog();
        }

        public static void showAs_Update(frmManageShipper.MsgHandler msg, string[] obj)
        {
            dbAction = "update";
            modRefreshData = msg;
            frmShipperDataEntry f = new frmShipperDataEntry();
            f.textBox1.Text = obj[0];
            f.textBox2.Text = obj[1];
            f.textBox3.Text = obj[2];

            f.textBox1.Enabled = false;
            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Text = "Update";

            f.ShowDialog();
        }

        private void saveData()
        {
            string sql = "Insert Into Shippers(CompanyName,Phone) values('" +
                         textBox2.Text + "','" +
                         textBox3.Text + "')";

            bool isSave = new clsDB().ADO().ExecuteSql(sql);

            if (!isSave) { return; }

            //invoke the delegate to execute the function(RefreshData) 
            modRefreshData("Activated!!");

            DialogResult dr = MessageBox.Show("Successfully Saved! \n Do you want to add another data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }

            //set to exit the form
            isClosing = true;
        }

        private void updateData()
        {
            string sql = "Update Shippers " +
                         "Set  CompanyName='" + textBox2.Text + "'," +
                         "Phone='" + textBox3.Text + "'," +
                         "Where ShipperID = " + textBox1.Text;


            bool isSave = new clsDB().ADO().ExecuteSql(sql);

            if (!isSave) { return; }

            //invoke the delegate to execute the function(RefreshData) 
            modRefreshData("Activated!!");

            MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question);

            isClosing = true;
        }
        #endregion


        public frmShipperDataEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dbAction == "add")
            {
                saveData();
            }
            else
            {
                updateData();
            }
            Close();
        }
    }
}