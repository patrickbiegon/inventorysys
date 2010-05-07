 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Template1.Forms;

namespace Template1
{
    public partial class frmMain : Form
    {
        public delegate void MsgHandler(string msg);
        MsgHandler modDbAction;

        //crate a form as container
        Form currForm;

        //---------------------------------------------//
        #region METHODS_PROPERTIES

        private void showLogin()
        {
            frmLogin log = new frmLogin();
            log.ShowDialog();
            if (!log.isValid) { Application.Exit(); }

            statUser.Text = log.getUser;
        }

        private void showSplash()
        {
            new frmSplashScreen().ShowDialog();
        }

        

        private void showToolbars(bool[] tb)
        {
            tbNewTrans.Visible = tb[5];
            tbAddNew.Visible = tb[0];
            tbView.Visible = tb[1];
            tbUpdate.Visible = tb[2];
            tbDelete.Visible = tb[3];
            tbExit.Visible = tb[4];
        }

        private void showManageSupplier()
        {
            //Create Only One Instance of Form
            frmManageSupplier f = frmManageSupplier.CreateInstance();

            //Craete a delegation to invoke the dbAction of frmManageRecord
            MsgHandler dbAction = new MsgHandler(f.DbAction);
            modDbAction = dbAction;

            //settings for frmManageSUpplier
            f.MdiParent = this;
            f.listView1.Width = Width ;

            showManaged(f);   
        }

        private void showManageProduct()
        {
            //Create Only One Instance of Form
            frmManageProduct f = frmManageProduct.CreateInstance();

            //Craete a delegation to invoke the dbAction of frmManageRecord
            MsgHandler dbAction = new MsgHandler(f.DbAction);
            modDbAction = dbAction;

            //settings for frmManageProduct
            f.MdiParent = this;
            f.listView1.Width = Width ;

            showManaged(f);   
        }

        private void showManageCustomer()
        { 
            //Create Only One Instance of Form
          frmManageCustomer f = frmManageCustomer.CreateInstance();

            //Craete a delegation to invoke the dbAction of frmManageRecord
            MsgHandler dbAction = new MsgHandler(f.DbAction);
            modDbAction = dbAction;

            //settings for frmManageCustomer
            f.MdiParent = this;
            f.listView1.Width = Width ;

            showManaged(f);    
        }

        private void showManageEmployee()
        {
            //Create Only One Instance of Form
            frmManageEmployee f = frmManageEmployee.CreateInstance();

            //Craete a delegation to invoke the dbAction of frmManageRecord
            MsgHandler dbAction = new MsgHandler(f.DbAction);
            modDbAction = dbAction;

            //settings for frmManageEmployee
            f.MdiParent = this;
            f.listView1.Width = Width ;

            showManaged(f);   
        }

        private void showManageShipper()
        {
            //Create Only One Instance of Form
            frmManageShipper f = frmManageShipper.CreateInstance();

            //Craete a delegation to invoke the dbAction of frmManageRecord
            MsgHandler dbAction = new MsgHandler(f.DbAction);
            modDbAction = dbAction;

            //settings for frmManageShipper
            f.MdiParent = this;
            f.listView1.Width = Width ;

            showManaged(f);   
        }

        private void showManaged(Form f)
        {
            
            currForm = f;

            f.Show();
            f.WindowState = FormWindowState.Maximized;

            showToolbars(new bool[] { true, true, true, true, true, true }); toolStrip1.Visible = true;
        }

        private void showMenu()
        {
            frmMainMenu f = new frmMainMenu(new MsgHandler(showSelected));
            
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;f.str = "ADMIN";
            //showManageCustomer();
        }

        private void showSelected(string msg)
        {
            if (msg == "manageSupplier")
            {
                showManageSupplier();
            }
            else if (msg == "manageProduct")
            {
                showManageProduct();
            }
            else if (msg == "manageCustomer")
            {
                showManageCustomer();
            }
            else if (msg == "manageEmployee")
            {
                showManageEmployee();
            }
            else if (msg == "manageShipper")
            {
                showManageShipper();
            }
        }

        #endregion
        //---------------------------------------------//




        //Constructor
        public frmMain()
        {
            InitializeComponent();
        }

        //Prevent Resizing of Form
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

            showMenu();
            showToolbars(new bool[]{false,false,false,false,false,false});
           
           showLogin();
        }


        //TOOLBAR METHODS
        private void tbAddNew_Click(object sender, EventArgs e)
        {
            modDbAction("add");
        }

        private void tbView_Click(object sender, EventArgs e)
        {
            modDbAction("view");
        }

        private void tbUpdate_Click(object sender, EventArgs e)
        {
            modDbAction("update");
        }

        private void tbDelete_Click(object sender, EventArgs e)
        {
            modDbAction("delete");
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            modDbAction("exit");
            //showToolbars(new bool[] {false, false, false, false, false, false });
            toolStrip1.Visible = false;
            currForm = null;
        }

        //END OF TOOLBAR METHODS


        //MENU BAR METHODS
        private void table1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageSupplier();
            }
        }

        private void table2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageProduct();
            }
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageCustomer();
            }
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageEmployee();
            }
        }

        private void manageShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageShipper();
            }
        }

        private void tbNewTrans_Click(object sender, EventArgs e)
        {
            if (statUser.Text != "ADMIN")
                MessageBox.Show("Access Denied");
            else
            {
                frmTransaction f = new frmTransaction();
                f.ShowDialog();
            }
        }

         
 

        private void mnuNewTrans_Click(object sender, EventArgs e)
        {
            frmTransaction f = new frmTransaction();
            f.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
 
        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr.exe");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("services.msc");
        }

        private void commandLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe","C:");
        }

        private void systemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (statUser.Text != "ADMIN")
                MessageBox.Show("Access Denied");
            else
            {
            new frmManageUser().ShowDialog();
              
            }
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {
            showManageCustomer();
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.ShowDialog();
        }
 
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageRecordTab frm = new frmManageRecordTab();
            frm.ShowDialog();
        }

    }
}