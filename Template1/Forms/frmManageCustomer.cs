 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmManageCustomer : frmManageRecord
    {

        string msql = "Select * from Customers";
        
        //this will create a single instance of form
        public static frmManageCustomer CreateInstance()
        {
            frmManageCustomer f;
            if (thisform == null)
            {
                thisform = new frmManageCustomer();
            }
            //dynamic casting
            f = (frmManageCustomer) thisform;
            return f;
        }

        #region METHODS_PROPERTIES
        public void RefreshData(string s)
        {
            new clsDB().ADO().FillLvw(listView1, msql + getOrderby);
        }

        private string getOrderby
        {
            get
            {
                string select = "";

                if (cmbOrderby.Text == "Company Name")
                {
                    select = " Order By CompanyName";
                }
                else if (cmbOrderby.Text == "Contact Name")
                {
                    select = " Order By ContactName";
                }
                else
                {
                    select = " Order By CustomerID";
                }
                return select;
            }
        }

        private void AddRecord()
        {
            //create a single instance of frmSupplierDE, then pass the delegate method to be invoke 
             frmCustomerDataEntry.showAs_Add(new MsgHandler(RefreshData));
        }

        private void ViewRecord()
        {
            string[] obj = new string[12];

            try
            {
                new clsDB().ADO().SelectData(msql + " Where CustomerID='" + listView1.SelectedItems[0].Text + "'", obj);

                frmCustomerDataEntry.showAs_View(new MsgHandler(RefreshData), obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Selected!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateRecord()
        {
            string[] obj = new string[12];


            try
            {
                new clsDB().ADO().SelectData(msql + " Where CustomerID='" + listView1.SelectedItems[0].Text + "'", obj);

                frmCustomerDataEntry.showAs_Update(new MsgHandler(RefreshData), obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Selected!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRecord()
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?" +
                                                  "\nCustomer ID: " + listView1.SelectedItems[0].Text +
                                                  "\nCompany Name: " + listView1.SelectedItems[0].SubItems[1].Text,
                                                  "About to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    new clsDB().ADO().ExecuteSql("Delete * from Customers Where CustomerID='" + listView1.SelectedItems[0].Text + "'");
                    RefreshData(" ");
                }
            }
            catch (Exception ex) { }
        }


        public void DbAction(string msg)
        {

            if (msg == "add")
            {
                //code here
                AddRecord();
            }
            else if (msg == "update")
            {
                //code here
                UpdateRecord();
            }
            else if (msg == "view")
            {
                //code here
                ViewRecord();
            }
            else if (msg == "delete")
            {
                DeleteRecord();
            }

            else
            {
                Close();
            }

        }
        #endregion

        private frmManageCustomer()
        {
            InitializeComponent();
            RefreshData(" ");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = msql;

            if (cmbSearchby.Text == "Customer ID")
            {
                sql += " Where CustomerID Like '" + txtSearch.Text + "%'";
            }
            if (cmbSearchby.Text == "Company Name")
            {
                sql += " Where CompanyName Like '" + txtSearch.Text + "%'";
            }
            else if (cmbSearchby.Text == "Contact Name")
            {
                sql += " Where ContactName Like '" + txtSearch.Text + "%'";
            }


            new clsDB().ADO().FillLvw(listView1, sql + getOrderby);
        }

        private void cmbOrderby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateRecord();
        }


    }
}