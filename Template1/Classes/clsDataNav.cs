 
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace Template1
{
    class clsDataNav
    {
        clsDB modDB = new clsDB();
        clsADO ado;

        public clsDataNav(string sql)
        {
            ado = modDB.ADO();
            ado.SelectData(sql);
        }

        public object[] First()
        {
            DataSet dt = ado.Recordset(0);
            return dt.Tables["tbl"].Rows[ado.CurrentRow].ItemArray;
        }

        public object[] Previous()
        {
            ado.PreviousRecord();
            DataSet dt = ado.Recordset(ado.CurrentRow);

            return dt.Tables["tbl"].Rows[ado.CurrentRow].ItemArray;
        }

        public object[] Next()
        {
            ado.NextRecord();
            DataSet dt = ado.Recordset(ado.CurrentRow);

            return dt.Tables["tbl"].Rows[ado.CurrentRow].ItemArray;
        }

        public object[] Last()
        {
            DataSet dt = ado.Recordset(ado.RecordCount - 1);
            return dt.Tables["tbl"].Rows[ado.CurrentRow].ItemArray;
        }
    }
}
