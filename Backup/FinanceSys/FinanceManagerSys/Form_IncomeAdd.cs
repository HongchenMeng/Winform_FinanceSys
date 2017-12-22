using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PublicLibrary;
using System.Net;
using FinanceSys.PublicLibrary.BLL;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_IncomeAdd : Form
    {
        public string type = string.Empty;
        public Form_IncomeAdd()
        {
            InitializeComponent();
            //this.cbxType.Text = cbxType.Items[0].ToString();
            this.txtltdname.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                if (InsertIncome() > 0)
                {
                    App_Code.Message.InfoMsg("操作成功");
                    Log_BLL.Add(DateTime.Now, "财务收入(非合同)", App_Code.Canshu.LoginName, "财务收入(非合同)", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 8); this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        

        private int InsertIncome()
        {
            FinanceManagerSys.Model.Income_Model model = new FinanceSys.FinanceManagerSys.Model.Income_Model();
            FinanceManagerSys.BLL.Income_BLL bll = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();

            model.B = "非合同收入";
            model.BreakMoney = 0;
            model.ContractNo = "非合同收入";
            model.Deductap = 0;
            model.DemoCost = 0;
            model.DemoName = this.txtdemoname.Text.Trim();
            model.EmpName = "无";
            model.Incometime=DateTime.Parse(dtpMonth.Text);
            model.InvoiceMoney = 0;
            model.IsBank = "非合同收入";
            model.Money = decimal.Parse(this.txtMoney.Text.Trim());
            model.OperPerson = this.txtOperPerson.Text.Trim();
            model.Party = this.txtltdname.Text.Trim();
            model.Remark = this.txtRemark.Text.Trim();
            model.Type = this.txtType.Text.Trim();
            
            return bll.Add(model);
        }

        private bool InputCheck()
        {
            bool result = false;
            if (string.IsNullOrEmpty(this.txtltdname.Text))
            {
                App_Code.Message.InfoMsg("输入公司名称");
                return result;
            }
            else if (string.IsNullOrEmpty(this.txtOperPerson.Text))
            {
                App_Code.Message.InfoMsg("输入操作员");
                return result;
            }

            return result = true;
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtMoney.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值");
                        this.txtMoney.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtMoney.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                this.txtMoney.Clear();
                return;
            }
        }

        private void txtMoney_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtMoney.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
