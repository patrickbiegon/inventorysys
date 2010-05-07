namespace Template1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDoIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbNewTrans = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAddNew = new System.Windows.Forms.ToolStripButton();
            this.tbView = new System.Windows.Forms.ToolStripButton();
            this.tbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbExit = new System.Windows.Forms.ToolStripButton();
            this.tmrCurTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statUser,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statUser
            // 
            this.statUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statUser.Name = "statUser";
            this.statUser.Size = new System.Drawing.Size(80, 19);
            this.statUser.Text = " User Logged";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(16, 19);
            this.toolStripStatusLabel7.Text = "   ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewTrans,
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuNewTrans
            // 
            this.mnuNewTrans.Name = "mnuNewTrans";
            this.mnuNewTrans.Size = new System.Drawing.Size(163, 22);
            this.mnuNewTrans.Text = "New Transaction";
            this.mnuNewTrans.Click += new System.EventHandler(this.mnuNewTrans_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.table1ToolStripMenuItem,
            this.table2ToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem,
            this.manageShippersToolStripMenuItem,
            this.transactionRecordsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // table1ToolStripMenuItem
            // 
            this.table1ToolStripMenuItem.Name = "table1ToolStripMenuItem";
            this.table1ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.table1ToolStripMenuItem.Text = "Manage Suppliers";
            this.table1ToolStripMenuItem.Click += new System.EventHandler(this.table1ToolStripMenuItem_Click);
            // 
            // table2ToolStripMenuItem
            // 
            this.table2ToolStripMenuItem.Name = "table2ToolStripMenuItem";
            this.table2ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.table2ToolStripMenuItem.Text = "Manage Products";
            this.table2ToolStripMenuItem.Click += new System.EventHandler(this.table2ToolStripMenuItem_Click);
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.manageCustomerToolStripMenuItem.Text = "Manage Customers";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.manageCustomerToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employees";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageShippersToolStripMenuItem
            // 
            this.manageShippersToolStripMenuItem.Name = "manageShippersToolStripMenuItem";
            this.manageShippersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.manageShippersToolStripMenuItem.Text = "Manage Shippers";
            this.manageShippersToolStripMenuItem.Click += new System.EventHandler(this.manageShippersToolStripMenuItem_Click);
            // 
            // transactionRecordsToolStripMenuItem
            // 
            this.transactionRecordsToolStripMenuItem.Name = "transactionRecordsToolStripMenuItem";
            this.transactionRecordsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.transactionRecordsToolStripMenuItem.Text = "Transaction Records";
            this.transactionRecordsToolStripMenuItem.Click += new System.EventHandler(this.transactionRecordsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howDoIToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howDoIToolStripMenuItem
            // 
            this.howDoIToolStripMenuItem.Name = "howDoIToolStripMenuItem";
            this.howDoIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howDoIToolStripMenuItem.Text = "How Do I";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::Template1.Properties.Resources._4ac98ef6b9c9e1440x900_Vista_Energy_Blue_Wallpaper;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNewTrans,
            this.toolStripSeparator1,
            this.tbAddNew,
            this.tbView,
            this.tbUpdate,
            this.tbDelete,
            this.toolStripSeparator2,
            this.tbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(86, 426);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // tbNewTrans
            // 
            this.tbNewTrans.AutoSize = false;
            this.tbNewTrans.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbNewTrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbNewTrans.Image = global::Template1.Properties.Resources.applications;
            this.tbNewTrans.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbNewTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNewTrans.Name = "tbNewTrans";
            this.tbNewTrans.RightToLeftAutoMirrorImage = true;
            this.tbNewTrans.Size = new System.Drawing.Size(85, 49);
            this.tbNewTrans.Text = "New Transaction";
            this.tbNewTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbNewTrans.Click += new System.EventHandler(this.tbNewTrans_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(83, 6);
            // 
            // tbAddNew
            // 
            this.tbAddNew.AutoSize = false;
            this.tbAddNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbAddNew.BackgroundImage = global::Template1.Properties.Resources._4ac98ef6b9c9e1440x900_Vista_Energy_Blue_Wallpaper;
            this.tbAddNew.Image = global::Template1.Properties.Resources.Button_Add_2_;
            this.tbAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddNew.Name = "tbAddNew";
            this.tbAddNew.Size = new System.Drawing.Size(85, 49);
            this.tbAddNew.Text = "Add New";
            this.tbAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbAddNew.Click += new System.EventHandler(this.tbAddNew_Click);
            // 
            // tbView
            // 
            this.tbView.AutoSize = false;
            this.tbView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbView.Image = global::Template1.Properties.Resources.search;
            this.tbView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbView.Name = "tbView";
            this.tbView.Size = new System.Drawing.Size(85, 49);
            this.tbView.Text = "View";
            this.tbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbView.Click += new System.EventHandler(this.tbView_Click);
            // 
            // tbUpdate
            // 
            this.tbUpdate.AutoSize = false;
            this.tbUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbUpdate.Image = global::Template1.Properties.Resources.blog_post_edit;
            this.tbUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(85, 49);
            this.tbUpdate.Text = "Update";
            this.tbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbUpdate.Click += new System.EventHandler(this.tbUpdate_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.AutoSize = false;
            this.tbDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbDelete.Image = global::Template1.Properties.Resources.blog_post_delete;
            this.tbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(85, 49);
            this.tbDelete.Text = "Delete";
            this.tbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(83, 6);
            // 
            // tbExit
            // 
            this.tbExit.AutoSize = false;
            this.tbExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbExit.Image = global::Template1.Properties.Resources.remove;
            this.tbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(85, 49);
            this.tbExit.Text = "Exit";
            this.tbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 474);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewTrans;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem table1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem table2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDoIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageShippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private   System.Windows.Forms.ToolStripStatusLabel statUser;

         
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripButton tbNewTrans;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAddNew;
        private System.Windows.Forms.ToolStripButton tbView;
        private System.Windows.Forms.ToolStripButton tbUpdate;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer tmrCurTime;
    }
}

