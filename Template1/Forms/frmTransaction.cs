using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmTransaction : Form
    {
        string sql = "Select * from Orders";

        clsDataNav navCustomers;

        public frmTransaction()
        {
            InitializeComponent();
            navCustomers = new clsDataNav(sql);

            btnFirst_Click(new object(), new EventArgs());
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            object[] obj = navCustomers.First();

            Navi(obj);


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            object[] obj = navCustomers.Previous();

            Navi(obj);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            object[] obj = navCustomers.Next();

            Navi(obj);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            object[] obj = navCustomers.Last();
            Navi(obj);

        }

        private void Navi(object[] obj)
        {
            string[] cust = new string[11];
            new clsDB().ADO().SelectData("Select * from Customers Where CustomerID='" + Convert.ToString(obj[1]) + "'", cust);

            string[] emp = new string[1];
            new clsDB().ADO().SelectData("Select LastName + ', ' + FirstName As Fullname from Employees Where EmployeeID=" + Convert.ToString(obj[2]), emp);

            string[] shipper = new string[1];
            new clsDB().ADO().SelectData("Select CompanyName from Shippers Where ShipperID=" + Convert.ToString(obj[6]), shipper);

            string[] sumtotal = new string[1];
            new clsDB().ADO().SelectData("Select Sum(([Order Details].UnitPrice *  [Order Details].Quantity)-( [Order Details].UnitPrice *  [Order Details].Quantity *  [Order Details].Discount)) as Total from [Order Details] Where OrderID=" + Convert.ToString(obj[0]), sumtotal);

            cmbSalesPerson.Text = emp[0];

            cmbBillto.Text = cust[1];
            textBox1.Text = cust[4];
            textBox2.Text = cust[5];
            textBox3.Text = cust[6];
            textBox4.Text = cust[7];
            textBox5.Text = cust[8];

            cmbShipVia.Text = shipper[0];
            cmbShipto.Text = Convert.ToString(obj[8]);
            textBox10.Text = Convert.ToString(obj[9]);
            textBox9.Text = Convert.ToString(obj[10]);
            textBox8.Text = Convert.ToString(obj[11]);
            textBox7.Text = Convert.ToString(obj[12]);
            textBox6.Text = Convert.ToString(obj[13]);

            if(DBNull.Value != (obj[3]))
                dtpTransDate.Value = Convert.ToDateTime(obj[3]);

            if (DBNull.Value != (obj[4]))
            dtpRequiredDate.Value = Convert.ToDateTime(obj[4]);

            if (DBNull.Value != (obj[5]))
            dtpShippedDate.Value = Convert.ToDateTime(obj[5]);

            txtSubtotal.Text = sumtotal[0];
            txtFrieght.Text = Convert.ToString(obj[7]);


            new clsDB().ADO().FillLvw(listView1, "SELECT Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount,(([Order Details].UnitPrice *  [Order Details].Quantity)-( [Order Details].UnitPrice *  [Order Details].Quantity *  [Order Details].Discount)) as Total FROM Products INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID Where OrderID=" + Convert.ToString(obj[0]));

            double frieght = Convert.ToDouble(txtFrieght.Text);
            double subt = Convert.ToDouble(txtSubtotal.Text);
            double grandt = frieght + subt;
            txtGrandtotal.Text = Convert.ToString(grandt);

        }
    }
}