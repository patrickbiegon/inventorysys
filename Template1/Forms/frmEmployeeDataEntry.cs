using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmEmployeeDataEntry : frmDataEntry
    {

        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageEmployee.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        #region Showing the form AS_
        public static void showAs_Add(frmManageEmployee.MsgHandler msg)
        {
            dbAction = "add";
            modRefreshData = msg;
            frmEmployeeDataEntry f = new frmEmployeeDataEntry();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageEmployee.MsgHandler msg, string[] obj)
        {
            modRefreshData = msg;
            frmEmployeeDataEntry f = new frmEmployeeDataEntry();
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
            f.textBox12.Text = obj[11];
            f.textBox13.Text = obj[12];

            if (obj[13] != "")
            {
                string[] reportTo = new string[1];
                new clsDB().ADO().SelectData("Select LastName + ', ' + FirstName as FullName from Employees Where EmployeeID=" + obj[13], reportTo);

                f.textBox14.Text = reportTo[0];
            }


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
            f.textBox12.ReadOnly = true;
            f.textBox13.ReadOnly = true;
            //f.textBox14.ReadOnly = true;

            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Visible = false;
            f.btnCancel.Text = "Close";

            f.ShowDialog();
        }

        public static void showAs_Update(frmManageEmployee.MsgHandler msg, string[] obj)
        {
            dbAction = "update";
            modRefreshData = msg;
            frmEmployeeDataEntry f = new frmEmployeeDataEntry();
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
            f.textBox12.Text = obj[11];
            f.textBox13.Text = obj[12];

            if (obj[13] != "")
            {
                string[] reportTo = new string[1];
                new clsDB().ADO().SelectData("Select LastName + ', ' + FirstName as FullName from Employees Where EmployeeID=" + obj[13], reportTo);

                f.textBox14.Text = reportTo[0];
            }


            f.textBox1.Enabled = false;
            f.textBox1.Visible = true;
            f.label1.Visible = true;

            f.btnSave.Text = "Update";

            f.ShowDialog();
        }

        private void saveData()
        {
            string[] reportTo = new string[1];
            string[] fname = textBox14.Text.Split(',');

            new clsDB().ADO().SelectData("Select EmployeeID from Employees Where LastName='" + fname[0] + "' And FirstName='" + fname[1].Trim() + "'", reportTo);

            string sql = "Insert Into Employees(LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,ReportsTo) values('" +
                         textBox2.Text + "','" +
                         textBox3.Text + "','" +
                         textBox4.Text + "','" +
                         textBox5.Text + "',#" +
                         textBox6.Text + "#,#" +
                         textBox7.Text + "#,'" +
                         textBox8.Text + "','" +
                         textBox9.Text + "','" +
                         textBox10.Text + "','" +
                         textBox11.Text + "','" +
                         textBox12.Text + "','" +
                         textBox13.Text + "'," +
                         reportTo[0] + ")";

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
                textBox12.Clear();
                textBox13.Clear();
                textBox12.Text = "";
            }

            //set to exit the form
            isClosing = true;
        }

        private void updateData()
        {

            string[] reportTo = new string[1];
            string[] fname = textBox14.Text.Split(',');

            new clsDB().ADO().SelectData("Select EmployeeID from Employees Where LastName='" + fname[0] + "' And FirstName='" + fname[1].Trim() + "'", reportTo);

            string sql = "Update Employees " +
                         "Set  LastName='" + textBox2.Text + "'," +
                         "FirstName='" + textBox3.Text + "'," +
                         "Title='" + textBox4.Text + "'," +
                         "TitleOfCourtesy='" + textBox5.Text + "'," +
                         "BirthDate=#" + textBox6.Text + "#," +
                         "HireDate=#" + textBox7.Text + "#," +
                         "Address='" + textBox8.Text + "'," +
                         "City='" + textBox9.Text + "'," +
                         "Region='" + textBox10.Text + "'," +
                         "PostalCode='" + textBox11.Text + "'," +
                         "Country='" + textBox12.Text + "'," +
                         "HomePhone='" + textBox13.Text + "'," +
                         "ReportsTo=" + reportTo[0] + " " +
                         "Where EmployeeID = " + textBox1.Text;


            bool isSave = new clsDB().ADO().ExecuteSql(sql);

            if (!isSave) { return; }

            //invoke the delegate to execute the function(RefreshData) 
            modRefreshData("Activated!!");

            MessageBox.Show("Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question);

            isClosing = true;
        }
        #endregion

        private frmEmployeeDataEntry()
        {
            InitializeComponent();
            new clsDB().ADO().FillCombobox(textBox14, "Select LastName + ', ' + FirstName as FullName from Employees");
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