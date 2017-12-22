using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_PayMonth : Form
    {
        public Form_PayMonth()
        {
            InitializeComponent();
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            Form_WageGrantList grant = new Form_WageGrantList();
            grant.times = dtppaymonth.Text;
            this.Hide();
            grant.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
