using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_Break : Form
    {
        public Form_Break()
        {
            InitializeComponent();
        }
        private FinanceManagerSys.BLL.Income_BLL income = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();
        private void txtBreakMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtBreakMoney.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值");
                        this.txtBreakMoney.Clear();
                        this.txtBreakMoney.Focus();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtBreakMoney.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                this.txtBreakMoney.Clear();
                this.txtBreakMoney.Focus();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Break_Load(object sender, EventArgs e)
        {
            int id = App_Code.Canshu.Id;
            if (id != 0 && id != -1)
                this.ShowIncomeInfo(id);
        }

        private void ShowIncomeInfo(int id)
        {            
            FinanceManagerSys.Model.Income_Model model = new FinanceSys.FinanceManagerSys.Model.Income_Model();
            model = income.GetModel(id);
            this.txtB.Text = model.B;
            this.txtcontractno.Text = model.ContractNo;
            this.txtDemocost.Text = model.DemoCost.ToString();
            this.txtDemoname.Text = model.DemoName;            
            this.txtOperperson.Text = model.OperPerson;
            if (model.Money == model.BreakMoney)
            {
                App_Code.Message.InfoMsg("此合同款项已完成");
                this.txtBreakMoney.ReadOnly = true;
                this.txtBreakMoney.Text = model.BreakMoney.ToString();
                this.btnOK.Enabled = false;
            }            
            this.txtMoney.Text = model.Money.ToString();
            this.txtBBreak.Text = model.BreakMoney.ToString();
            this.txtParty.Text = model.Party;
            this.txtRemark.Text = model.Remark;
            this.cbxEmp.Text = model.EmpName;            
            this.txtTic.Text = model.Deductap.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBreakMoney.Text) || this.txtBreakMoney.Text.Equals("0.00"))
            {
                App_Code.Message.InfoMsg("输入回款金额");
                return;
            }
            else
            {
                int id = App_Code.Canshu.Id;
                if (id != 0 && id != -1)
                {
                    if (CheckBreakM())
                    {
                        if (income.Update(id, decimal.Parse(this.txtBreakMoney.Text.Trim())) > 0)
                        {
                            App_Code.Message.InfoMsg("操作成功");
                            income.UpdateState("是", id);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                        else { App_Code.Message.InfoMsg("操作失败"); return; }
                    }
                    else
                    {
                        App_Code.Message.ErrorMsg("回款金额输入错误");
                        return;
                    }
                }
            }
        }

        private bool CheckBreakM()
        {
            decimal money = decimal.Parse(this.txtMoney.Text.Trim());
            decimal breakh = decimal.Parse(this.txtBBreak.Text.Trim());
            decimal breakm = decimal.Parse(this.txtBreakMoney.Text.Trim());
            if (breakh + breakm > money) return false; else return true;
        }

        private void txtBreakMoney_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtBreakMoney.Clear();
        }
    }
}
