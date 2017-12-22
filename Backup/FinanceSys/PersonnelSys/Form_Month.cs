using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_Month : Form
    {
        public Form_Month()
        {
            InitializeComponent();
        }

        private void Form_Month_Load(object sender, EventArgs e)
        {
            if (rdbbenqi.Checked)
                dtptime.Enabled = false;
            else
                dtptime.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Form_EmpWageAdd wageadd = new Form_EmpWageAdd();
            if (rdbbenqi.Checked)
            {
                this.Hide();
                wageadd.str = "benqi";
                wageadd.time = dtptime.Text;
                wageadd.ShowDialog();
            }
            else {
                this.Hide();
                wageadd.str = "xiaqi";
                wageadd.ShowDialog();    
            }
            
        }
    }
}
