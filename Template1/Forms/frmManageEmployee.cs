using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmManageEmployee : frmManageRecord
    {

        string msql = "Select EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,ReportsTo " +
                      "from Employees";

        #region METHODS_PROPERTIES
        public void RefreshData(string s)
        {
            new clsDB().ADO().FillLvw(listView1, msql + getOrderby);
        }

        //this will create a single instance of form
        public static frmManageEmployee CreateInstance()
        {
            frmManageEmployee f;
            if (thisform == null)
            {
                thisform = new frmManageEmployee();
            }
            //dynamic casting
            f = (frmManageEmployee)thisform;
            return f;
        }

        private string getOrderby
        {
            get
            {
                string select = "";

                if (cmbOrderby.Text == "Last Name")
                {
                    select = " Order By LastName";
                }
                else if (cmbOrderby.Text == "First Name")
                {
                    select = " Order By FirstName";
                }
                else if (cmbOrderby.Text == "Title")
                {
                    select = " Order By Title";
                }
                else
                {
                    select = " Order By EmployeeID";
                }
                return select;
            }
        }

        private void AddRecord()
        {
            //create a single instance of frmSupplierDE, then pass the delegate method to be invoke 
            frmEmployeeDataEntry.showAs_Add(new MsgHandler(RefreshData));
        }

        private void ViewRecord()
        {
            string[] obj = new string[14];


            try
            {
                new clsDB().ADO().SelectData(msql + " Where EmployeeID=" + listView1.SelectedItems[0].Text, obj);

                frmEmployeeDataEntry.showAs_View(new MsgHandler(RefreshData), obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Record Selected!", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateRecord()
        {
            string[] obj = new string[14];


            try
            {
                new clsDB().ADO().SelectData(msql + " Where EmployeeID=" + listView1.SelectedItems[0].Text, obj);

                frmEmployeeDataEntry.showAs_Update(new MsgHandler(RefreshData), obj);
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
                                                  "\nEMployee ID: " + listView1.SelectedItems[0].Text +
                                                  "\nLast Name: " + listView1.SelectedItems[0].SubItems[1].Text +
                                                  "\nFirst Name: " + listView1.SelectedItems[0].SubItems[2].Text,
                                                  "About to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    new clsDB().ADO().ExecuteSql("Delete * from Products Where EmployeeID=" + listView1.SelectedItems[0].Text);
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

        //-----------------------------------------------------------------------------//

        private frmManageEmployee()
        {
            InitializeComponent();
            RefreshData(" ");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = msql;

            if (cmbSearchby.Text == "Employee ID")
            {
                if (txtSearch.Text != "")
                {
                    sql += " Where EmployeeID=" + txtSearch.Text;
                }
            }
            if (cmbSearchby.Text == "Last Name")
            {
                sql += " Where LastName Like '" + txtSearch.Text + "%'";
            }
            else if (cmbSearchby.Text == "First Name")
            {
                sql += " Where FirstName Like '" + txtSearch.Text + "%'";
            }
            else if (cmbSearchby.Text == "Title")
            {
                sql += " Where Title Like '" + txtSearch.Text + "%'";
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