using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Windows.Forms;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_Account : Form
    {
        public  static DateTime time;//参数      
        private FinanceManagerSys.BLL.Outlay_BLL outbll = new FinanceSys.FinanceManagerSys.BLL.Outlay_BLL();
        private FinanceManagerSys.BLL.Income_BLL incomebll = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();
        public Form_Account()
        {
            InitializeComponent();
            this.txttime.Text = time.ToShortDateString();           
        }         
       
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            dgvAccount.AutoGenerateColumns = false;
            try
            {
                int t = dgvAccount.Rows.Add();
                int hk = 0;
                int incomecount = incomebll.GetSys(time);
                int breakcount = incomebll.GetBreakCount();
                dgvAccount.Rows[t].Cells["HK"].Value = hk.ToString();
                dgvAccount.Rows[t].Cells["shouru"].Value = (incomebll.GetIncomeCount(time) - hk).ToString();
                dgvAccount.Rows[t].Cells["zhichu"].Value = outbll.GetOutSys(time).ToString();
                dgvAccount.Rows[t].Cells["yumoney"].Value = (incomebll.GetIncomeCount(time) - outbll.GetOutSys(time)).ToString();
            }
            catch
            {
                //App_Code.Message.ErrorMsg("没有查询到数据");
                return;
            }
        }

        private void btnwhere_Click(object sender, EventArgs e)
        {
            FinanceManagerSys.Form_Money money = new Form_Money();
            money.filter = "filter";
            money.ShowDialog();
            this.Hide();
        }
    }
}
