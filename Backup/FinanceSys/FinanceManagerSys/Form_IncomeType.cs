using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_IncomeType : Form
    {
        public Form_IncomeType()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbxYes.Checked == false && cbxNo.Checked == false) {
                App_Code.Message.InfoMsg("请选择收入类型");
                return;
            }
            else
            {
                if (cbxYes.Checked)
                {
                    Form_IncomeAddCon incomecomadd = new Form_IncomeAddCon();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    incomecomadd.ShowDialog();
                }
                else if(cbxNo.Checked)
                {
                    Form_IncomeAdd incomeadd = new Form_IncomeAdd();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    incomeadd.type = "No";
                    incomeadd.ShowDialog();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxYes.Checked == true)
                cbxYes.Checked = false;
        }

        private void cbxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNo.Checked == true)
                cbxNo.Checked = false;
        }
    }
}
