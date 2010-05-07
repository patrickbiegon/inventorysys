 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmManageProduct : frmManageRecord
    {

        string msql = "Select DISTINCT ProductID,ProductName,CompanyName,CategoryName,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued " +
                     "from ((Products Inner Join Suppliers On Products.SupplierID=Suppliers.SupplierID)Inner Join Categories On Products.CategoryID=Categories.CategoryID)";


        #region METHODS_PROPERTIES
        public void RefreshData(string s)
        {
            new clsDB().ADO().FillLvw(listView1, msql + getOrderby);
        }

        //this will create a single instance of form
        public static frmManageProduct CreateInstance()
        {
            frmManageProduct f;
            if (thisform == null)
            {
                thisform = new frmManageProduct();
            }
            f = (frmManageProduct)thisform;
            return f;
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
                else if (cmbOrderby.Text == "Product Name")
                {
                    select = " Order By ProductName";
                }
                else if (cmbOrderby.Text == "Category")
                {
                    select = " Order By CategoryName";
                }
                else
                {
                    select = " Order By ProductID";
                }
                return select;
            }
        }

        private void AddRecord()
        {
            //create a single instance of frmSupplierDE, then pass the delegate method to be invoke 
            frmProductDataEntry.showAs_Add(new MsgHandler(RefreshData));
        }

        private void ViewRecord()
        {
            string[] obj = new string[12];


            try
            {
                new clsDB().ADO().SelectData(msql + " Where ProductID=" + listView1.SelectedItems[0].Text, obj);

                frmProductDataEntry.showAs_View(new MsgHandler(RefreshData), obj);
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
                new clsDB().ADO().SelectData(msql + " Where ProductID=" + listView1.SelectedItems[0].Text, obj);

                frmProductDataEntry.showAs_Update(new MsgHandler(RefreshData), obj);
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
                                                  "\nProduct ID: " + listView1.SelectedItems[0].Text +
                                                  "\nProduct Name: " + listView1.SelectedItems[0].SubItems[1].Text,
                                                  "About to Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    new clsDB().ADO().ExecuteSql("Delete * from Products Where ProductID=" + listView1.SelectedItems[0].Text);
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

        private frmManageProduct()
        {
            InitializeComponent();
            RefreshData(" ");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = msql;

            if (cmbSearchby.Text == "Product ID")
            {
                if (txtSearch.Text != "")
                {
                    sql += " Where ProductID=" + txtSearch.Text;
                }
            }
            if (cmbSearchby.Text == "Product Name")
            {
                sql += " Where ProductName Like '" + txtSearch.Text + "%'";
            }
            else if (cmbSearchby.Text == "Supplier")
            {
                sql += " Where Suppliers.CompanyName Like '" + txtSearch.Text + "%'";
            }
            else if (cmbSearchby.Text == "Category")
            {
                sql += " Where Categories.CategoryName Like '" + txtSearch.Text + "%'";
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