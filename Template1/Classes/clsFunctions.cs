 
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    class clsFunctions
    {
        public static bool isNumeric(object obj)
        {
            try
            {
                double x = Convert.ToDouble(obj);
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public static bool isDate(object obj)
        {
            try
            {
                DateTime x = Convert.ToDateTime(obj);
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public static void showError(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg,System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
