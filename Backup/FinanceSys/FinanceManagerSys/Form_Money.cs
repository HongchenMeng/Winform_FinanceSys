using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_Money : Form
    {
        public string filter = string.Empty;
        public Form_Money()
        {
            InitializeComponent();
            this.cbxMoney.Text = cbxMoney.Items[0].ToString();
            this.cbxMoney.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (filter.Equals("filter"))
            {
                FinanceManagerSys.Form_Account.time = DateTime.Parse(dtpTime.Text);
                FinanceManagerSys.Form_Account account = new Form_Account();
                account.Show();
                this.Hide();
            }
            else
            {
                FinanceManagerSys.Form_Account.time = DateTime.Parse(dtpTime.Text);
                FinanceManagerSys.Form_Account account = new Form_Account();
                account.Show();
                this.Hide();
            }
        }
    }
}
