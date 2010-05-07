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
    public partial class frmManageUser : frmDataEntry
    {
        clsDataNav rs = new clsDataNav("Select * From User_tbl");
        public frmManageUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            try
            {
                OleDbConnection dbConn = new OleDbConnection();
                OleDbCommand dbCommand = new OleDbCommand();

 
                String sql = "INSERT INTO [User_tbl] values('" + textBox1.Text + "','" + textBox2.Text + "')";
               
                bool isSave = new clsDB().ADO().ExecuteSql(sql);

                if (!isSave) { return; }
 

                DialogResult dr = MessageBox.Show("Successfully Saved! \n Do you want to add another data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                dbConn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}