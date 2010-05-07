 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Template1
{
    public partial class frmLogin : Form
    {
        private string User = "";
        private bool isvalid = false;
        private string[] privileges;

        public string[] Privileges
        {
            get { return privileges; }
        }

        public string getUser
        {
            get { return User; }
        }

        public bool isValid
        {
            get { return isvalid; }
        }

        //Use to validate user login entry
        private bool sValidate()
        {
            
            isvalid = true;
            User = txtUsername.Text;
            try
            {
                OleDbConnection dbConn = new OleDbConnection();
                OleDbCommand dbCommand = new OleDbCommand();


                dbConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saad\Desktop\Inventory_21705212172009\Inventory Template\Template1\Database\Inventory.mdb;Persist Security Info=False");
                dbCommand.CommandText = "SELECT * FROM [User_tbl] Where UserID = '" + User + "' And [Password] = '" + txtPassword.Text + "'";
                dbCommand.Connection = dbConn;
                dbConn.Open();
                OleDbDataReader dr;
           
                    dr = dbCommand.ExecuteReader();

                    if (dr.HasRows == false)
                    {
                        MessageBox.Show("Access Denied", "Invalid", MessageBoxButtons.OK);
                        Application.Exit();
                    }
 
                dbConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return true;
        }

        //---------------------------------------------//

        //Constructor()
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No) { return; }
            Application.Exit();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
              sValidate();
               
            Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = System.Char.ToUpper(e.KeyChar);
        }
    }
}