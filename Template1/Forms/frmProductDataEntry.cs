 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmProductDataEntry : frmDataEntry
    {

        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageProduct.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        #region Showing the form AS_
        public static void showAs_Add(frmManageProduct.MsgHandler msg)
        {
            dbAction = "add";
            modRefreshData = msg;
            frmProductDataEntry f = new frmProductDataEntry();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageProduct.MsgHandler msg, string[] obj)
        {
            modRefreshData = msg;
            frmProductDataEntry f = new frmProductDataEntry();
            f.textBox1.Text = obj[0];
            f.textBox2.Text = obj[1];
            f.textBox3.Text = obj[2];
            f.textBox4.Text = obj[3];
            f.textBox5.Text = obj[4];
            f.textBox6.Text = obj[5];
            f.textBox7.Text = obj[6];
            f.textBox8.Text = obj[7];
            f.textBox9.Text = obj[8];
            f.textBox10.Text = obj[9];


            f.textBox1.Enabled = false;
            f.textBox2.Enabled = false;
            f.textBox3.Enabled = false;
            f.textBox4.Enabled = false;
            f.textBox5.Enabled = false;
            f.textBox6.Enabled = false;
            f.textBox7.Enabled = false;
            f.textBox8.Enabled = false;
            f.textBox9.Enabled = false;
            f.textBox10.Enabled = false;


            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Visible = false;
            f.btnCancel.Text = "Close";

            f.ShowDialog();
        }

        public static void showAs_Update(frmManageProduct.MsgHandler msg, string[] obj)
        {
            dbAction = "update";
            modRefreshData = msg;
            frmProductDataEntry f = new frmProductDataEntry();
            f.textBox1.Text = obj[0];
            f.textBox2.Text = obj[1];
            f.textBox3.Text = obj[2];
            f.textBox4.Text = obj[3];
            f.textBox5.Text = obj[4];
            f.textBox6.Text = obj[5];
            f.textBox7.Text = obj[6];
            f.textBox8.Text = obj[7];
            f.textBox9.Text = obj[8];
            f.textBox10.Text = obj[9];


            f.textBox1.Enabled = false;
            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Text = "Update";

            f.ShowDialog();
        }

        private void saveData()
        {

            //NOTE: BE CAREFUL WITH SINGLE QOUTES QUERY AS SOMETIMES WILL CAUSE
            //UNWANTED BEHAVIOR

            string[] obj = new string[1];
            new clsDB().ADO().SelectData("Select SupplierID from Suppliers Where CompanyName='" + textBox3.Text + "'", obj);
            string suppid = obj[0];

            new clsDB().ADO().SelectData("Select CategoryID from Categories Where CategoryName='" + textBox4.Text + "'", obj);
            string catid = obj[0];

            //MessageBox.Show(suppid + " | " + catid); //This is a checker

            string sql = "Insert Into Products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel) Values('" +
                                                textBox2.Text + "'," + 
                                                suppid + "," + 
                                                catid + ",'" + 
                                                textBox5.Text + "'," + 
                                                textBox6.Text + "," + 
                                                textBox7.Text + "," + 
                                                textBox8.Text + "," + 
                                                textBox9.Text + ")";



            //MessageBox.Show(sql);    //This is a checker

            bool isSave = new clsDB().ADO().ExecuteSql(sql);

            if (!isSave) { return; }

            //invoke the delegate to execute the function(RefreshData) 
            modRefreshData("Activated!!");

            DialogResult dr = MessageBox.Show("Successfully Saved! \n Do you want to add another data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
            }

            //set to exit the form
            isClosing = true;
        }

        private void updateData()
        {
            //NOTE: BE CAREFUL WITH SINGLE QOUTES QUERY AS SOMETIMES WILL CAUSE
            //UNWANTED BEHAVIOR

            string[] obj = new string[1];
            new clsDB().ADO().SelectData("Select SupplierID from Suppliers Where CompanyName='" + textBox3.Text + "'", obj);
            string suppid = obj[0];

            new clsDB().ADO().SelectData("Select CategoryID from Categories Where CategoryName='" + textBox4.Text + "'", obj);
            string catid = obj[0];

            string sql = "Update Products " +
                         "Set ProductName='" + textBox2.Text + "'" +
                         ",SupplierID=" + suppid + 
                         ",CategoryID=" + catid + 
                         ",QuantityPerUnit='" + textBox5.Text + "'" +
                         ",UnitPrice=" + textBox6.Text + 
                         ",UnitsInStock=" + textBox7.Text + 
                         ",UnitsOnOrder=" + textBox8.Text + 
                         ",ReorderLevel=" + textBox9.Text + 
                         " Where ProductID=" + textBox1.Text; 


            bool isSave = new clsDB().ADO().ExecuteSql(sql);

            if (!isSave) { return; }

            //invoke the delegate to execute the function(RefreshData) 
            modRefreshData("Activated!!");

            MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question);

            isClosing = true;
        }
        #endregion

        private frmProductDataEntry()
        {
            InitializeComponent();

            new clsDB().ADO().FillCombobox(textBox3, "Select CompanyName from Suppliers");
            new clsDB().ADO().FillCombobox(textBox4, "Select CategoryName from Categories");
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