using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmCustomerDataEntry : frmDataEntry
    {

        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageCustomer.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        #region Showing the form AS_
        public static void showAs_Add(frmManageCustomer.MsgHandler msg)
        {
            dbAction = "add";
            modRefreshData = msg;
            frmCustomerDataEntry f = new frmCustomerDataEntry();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageCustomer.MsgHandler msg, string[] obj)
        {
            modRefreshData = msg;
            frmCustomerDataEntry f = new frmCustomerDataEntry();
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
            f.textBox11.Text = obj[10];

            f.textBox1.ReadOnly = true;
            f.textBox2.ReadOnly = true;
            f.textBox3.ReadOnly = true;
            f.textBox4.ReadOnly = true;
            f.textBox5.ReadOnly = true;
            f.textBox6.ReadOnly = true;
            f.textBox7.ReadOnly = true;
            f.textBox8.ReadOnly = true;
            f.textBox9.ReadOnly = true;
            f.textBox10.ReadOnly = true;
            f.textBox11.ReadOnly = true;

            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Visible = false;
            f.btnCancel.Text = "Close";

            f.ShowDialog();
        }

        public static void showAs_Update(frmManageCustomer.MsgHandler msg, string[] obj)
        {
            dbAction = "update";
            modRefreshData = msg;
            frmCustomerDataEntry f = new frmCustomerDataEntry();
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
            f.textBox11.Text = obj[10];

            f.textBox1.Enabled = false;
            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Text = "Update";

            f.ShowDialog();
        }


        //THIS IS AN EXAMPLE OF RECURSION(FUNCTION THAT CALL ITSELF)
        private string generateID(string str,int itr)
        {
            string[] obj = new string[1];
            string res="";
            bool b = new clsDB().ADO().SelectData("Select CompanyName from Customers Where CustomerID='" + str + "'", obj);

            if (b)
            {
                res = generateID(obj[0].Substring(0, 4).ToUpper() + Convert.ToString(itr + 1), itr + 1);
            }
            else
            {
                res = str;
            }

            return res;  
        }

        private void saveData()
        {
            string sql = "Insert Into Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) values('" +
                         generateID(textBox2.Text.Substring(0,5).ToUpper(),1) + "','" +
                         textBox2.Text + "','" +
                         textBox3.Text + "','" +
                         textBox4.Text + "','" +
                         textBox5.Text + "','" +
                         textBox6.Text + "','" +
                         textBox7.Text + "','" +
                         textBox8.Text + "','" +
                         textBox9.Text + "','" +
                         textBox10.Text + "','" +
                         textBox11.Text + "')";

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
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
            }

            //set to exit the form
            isClosing = true;
        }

        private void updateData()
        {
            string sql = "Update Customers " +
                         "Set  CompanyName='" + textBox2.Text + "'," +
                         "ContactName='" + textBox3.Text + "'," +
                         "ContactTitle='" + textBox4.Text + "'," +
                         "Address='" + textBox5.Text + "'," +
                         "City='" + textBox6.Text + "'," +
                         "Region='" + textBox7.Text + "'," +
                         "PostalCode='" + textBox8.Text + "'," +
                         "Country='" + textBox9.Text + "'," +
                         "Phone='" + textBox10.Text + "'," +
                         "Fax='" + textBox11.Text + "' " +
                         "Where CustomerID = '" + textBox1.Text + "'";


            bool isSave = new clsDB().ADO().ExecuteSql(sql);

            if (!isSave) { return; }

            //invoke the delegate to execute the function(RefreshData) 
            modRefreshData("Activated!!");

            MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question);

            isClosing = true;
        }
        #endregion

        private frmCustomerDataEntry()
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