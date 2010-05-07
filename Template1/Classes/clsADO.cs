 
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Template1
{
    class clsADO
    {
        private string mConnstring;
        private DataSet dtset = new DataSet("tbl");
        private int Prev=0;
        private int Next=0;
        private int recordCount;

        public int RecordCount
        {
            get { return recordCount; }
        }

        public int CurrentRow
        {
            get { return Prev; }
        }
/*--------------------------------------------------------------------------------------------------------------*/
//      CONSTRUCTOR
/*--------------------------------------------------------------------------------------------------------------*/
        #region Constructor
        //constructor without a parameter defaults to 0
        public clsADO()
        {
            mConnstring = "";
        }

        //constructor with parameter
        public clsADO(string Connstring)
        {
            mConnstring = Connstring;
        }

        //destructor
        ~clsADO()
        {
            mConnstring = "";
        }
        #endregion
/*--------------------------------------------------------------------------------------------------------------*/
//      PROPERTIES
/*--------------------------------------------------------------------------------------------------------------*/
        #region ConnectionString
        public string ConnectionString
        {
            get
            {
                return mConnstring;
            }
            set
            {
                mConnstring = value;
            }
        }
        #endregion
/*--------------------------------------------------------------------------------------------------------------*/
//      METHODS
/*--------------------------------------------------------------------------------------------------------------*/
        #region FillLvw
        public void FillLvw(ListView lvw, String sql)
        {
            
            try
            {
                OleDbConnection conn = new OleDbConnection(mConnstring);
                OleDbDataAdapter dtadapter = new OleDbDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                lvw.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for(int itr = 0; itr < recordCount; itr++)
                {
                    ListViewItem lvitem = new ListViewItem(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[0]),0);
                    for (int x = 1; x <= dtset.Tables["tbl"].Columns.Count - 1; x++)
                    {
                        lvitem.SubItems.Add(Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[x]));
                    }
                    lvw.Items.Add(lvitem);
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion //end of filllvw

        #region FillCombobox
        public void FillCombobox(ComboBox cb, String sql)
        {

            try
            {
                OleDbConnection conn = new OleDbConnection(mConnstring);
                OleDbDataAdapter dtadapter = new OleDbDataAdapter(sql, conn);


                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                cb.Items.Clear();//clears listview

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                for (int itr = 0; itr < recordCount; itr++)
                {
                     cb.Items.Add( Convert.ToString(dtset.Tables["tbl"].Rows[itr].ItemArray[0]));
                }

                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion //end of fillCombobox

        #region SelectData
        public bool SelectData(String sql)
        {
            
            try
            {
                OleDbConnection conn = new OleDbConnection(mConnstring);
                OleDbDataAdapter dtadapter = new OleDbDataAdapter(sql, conn);

                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                conn.Close();
                conn.Dispose();

                if (recordCount >= 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }

        public bool SelectData(String sql, string[] obj)
        {

            try
            {
                OleDbConnection conn = new OleDbConnection(mConnstring);
                OleDbDataAdapter dtadapter = new OleDbDataAdapter(sql, conn);

                conn.Open();

                dtset.Clear();
                dtadapter.Fill(dtset, "tbl");

                recordCount = dtset.Tables["tbl"].Rows.Count;//set RecordCount

                conn.Close();
                conn.Dispose();

                if (recordCount <= 0)
                {
                    return false;
                }

                if (obj != null)
                {
                    obj[0] = Convert.ToString(dtset.Tables["tbl"].Rows[0].ItemArray[0]);

                    for (int x = 1; x <= dtset.Tables["tbl"].Columns.Count - 1; x++)
                    {
                       obj[x] = Convert.ToString(dtset.Tables["tbl"].Rows[0].ItemArray[x]);
                    }
                }

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return false;
        }
        #endregion //end of SelectData

        #region ExecuteSql
        public bool ExecuteSql(string sql)
        {
            
            try
            {
                OleDbConnection conn = new OleDbConnection(mConnstring);
                OleDbCommand cmdExecute = new OleDbCommand(sql, conn);

                conn.Open();
                cmdExecute.ExecuteNonQuery();

                conn.Close();
                cmdExecute.Dispose();
                conn.Dispose();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return false;
        }
        #endregion //end of ExecuteSql

        #region RecordsetPosition
        public DataSet Recordset(int x)
        {
            if (x <= 0 || x > recordCount)
            {
                x = 0;
            }

            Prev = x;
            Next = x;
            object[] obj = dtset.Tables["tbl"].Rows[x].ItemArray;
            return dtset;
        }
        #endregion //end of recordset position

        #region Previous
        public DataSet PreviousRecord()
        {
            if (Next <= 0)
            {
                Prev = 0;
            }
            else
            {
                Prev = Next - 1;
                Next = Prev;
            }
            if (Prev <= 0)
            {
                Prev = 0;
            }
            return Recordset(Prev);
        }
        #endregion //previous

        #region Next
        public DataSet NextRecord()
        {
            Next += 1;
            if (Next >= recordCount)
            {
                Next = recordCount-1;
            }
            return Recordset(Next);
        }
        #endregion //next
    }
}
