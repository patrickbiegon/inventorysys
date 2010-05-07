 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Template1
{
    public partial class frmManageRecordTab : Form
    {
        clsDataNav navRecord = new clsDataNav("Select * from Employees");

        public frmManageRecordTab()
        {
            InitializeComponent();
            btnFirst_Click(new object(),new EventArgs());
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            object[] str = navRecord.First();
            textBox1.Text = Convert.ToString(str[0]);
            textBox2.Text = Convert.ToString(str[1]);
            textBox3.Text = Convert.ToString(str[2]);
            textBox4.Text = Convert.ToString(str[3]);
            textBox5.Text = Convert.ToString(str[4]);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            object[] str = navRecord.Previous();
            textBox1.Text = Convert.ToString(str[0]);
            textBox2.Text = Convert.ToString(str[1]);
            textBox3.Text = Convert.ToString(str[2]);
            textBox4.Text = Convert.ToString(str[3]);
            textBox5.Text = Convert.ToString(str[4]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            object[] str = navRecord.Next();
            textBox1.Text = Convert.ToString(str[0]);
            textBox2.Text = Convert.ToString(str[1]);
            textBox3.Text = Convert.ToString(str[2]);
            textBox4.Text = Convert.ToString(str[3]);
            textBox5.Text = Convert.ToString(str[4]);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            object[] str = navRecord.Last();
            textBox1.Text = Convert.ToString(str[0]);
            textBox2.Text = Convert.ToString(str[1]);
            textBox3.Text = Convert.ToString(str[2]);
            textBox4.Text = Convert.ToString(str[3]);
            textBox5.Text = Convert.ToString(str[4]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}