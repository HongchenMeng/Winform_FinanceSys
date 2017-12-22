using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PersonnelSys.BLL;
using FinanceSys.PublicLibrary;
using System.Net;
using FinanceSys.PublicLibrary.BLL;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_IncomeAddCon : Form
    {
        public Form_IncomeAddCon()
        {
            InitializeComponent();
            cbxPayment.Text = cbxPayment.Items[0].ToString();
            cbxType.Text = cbxType.Items[0].ToString();
            this.txtcontractno.Focus();
        }
        
        private PersonnelSys.BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();
        private FinanceManagerSys.BLL.Wage_BLL wagebll = new FinanceSys.FinanceManagerSys.BLL.Wage_BLL();
        private FinanceManagerSys.BLL.Contract_BLL conbll = new FinanceSys.FinanceManagerSys.BLL.Contract_BLL();

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                if (conbll.Exists(int.Parse(this.txtcontractno.Text.Trim()))==true)
                {
                    App_Code.Message.InfoMsg("合同编号出现重复");
                    return;
                }
                else
                {
                    if (InsertIncome() == 1 && InsertContract() == 1)
                    {
                        App_Code.Message.InfoMsg("操作成功");
                        Log_BLL.Add(DateTime.Now, "财务收入(合同收入)", App_Code.Canshu.LoginName, "财务收入(合同收入)", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 8);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
        
        private void Form_IncomeAddCon_Load(object sender, EventArgs e)
        {
            Load_Emp();//加载员工信息
        }

        private void Load_Emp()
        {
            DataTable dt = empbll.GetListByOperation("业务员");
            if (dt != null && dt.Rows.Count > 0)
            {
                this.cbxEmp.Items.Clear();
                this.cbxEmp.DataSource = dt;
                DataRow dr = dt.NewRow();
                dr[dt.Columns[1].ToString()] = "--无--";
                dt.Rows.InsertAt(dr, 0);
                this.cbxEmp.DisplayMember = dt.Columns[1].ToString();
                this.cbxEmp.ValueMember = dt.Columns[1].ToString();
            }
            else {
                this.cbxEmp.Items.Clear();
                this.cbxEmp.DataSource = dt;
                DataRow dr = dt.NewRow();
                dr[dt.Columns[1].ToString()] = "--无--";
                dt.Rows.InsertAt(dr, 0);
                this.cbxEmp.DisplayMember = dt.Columns[1].ToString();
                this.cbxEmp.ValueMember = dt.Columns[1].ToString();
            }
        }

        private bool InputCheck()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtcontractno.Text))
                {
                    App_Code.Message.InfoMsg("输入合同编号");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtParty.Text))
                {
                    App_Code.Message.InfoMsg("输入甲方名称");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtB.Text))
                {
                    App_Code.Message.InfoMsg("输入乙方名称");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtDemoname.Text))
                {
                    App_Code.Message.InfoMsg("输入项目名称");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtMoney.Text) || this.txtMoney.Text.Equals("0.00"))
                {
                    App_Code.Message.InfoMsg("输入项目金额");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtOperperson.Text))
                {
                    App_Code.Message.InfoMsg("输入操作员名称");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                return false;
            }

        }

        private int InsertContract()
        {
            FinanceManagerSys.Model.Contract_Model model = new FinanceSys.FinanceManagerSys.Model.Contract_Model();
            FinanceManagerSys.BLL.Contract_BLL bll = new FinanceSys.FinanceManagerSys.BLL.Contract_BLL();
            model.B = this.txtB.Text.Trim();
            model.Money = decimal.Parse(this.txtMoney.Text.Trim());
            model.ContractNo = this.txtcontractno.Text.Trim();            
            model.DemoName = this.txtDemoname.Text.Trim();
            model.EmpName = cbxEmp.Text;
            model.Signedtime = DateTime.Parse(dtptime.Text);
            model.Party = this.txtParty.Text.Trim();            
            model.Cost = decimal.Parse(this.txtDemocost.Text.Trim());            
            model.OperPerson = this.txtOperperson.Text.Trim();            
            model.Remark = this.txtRemark.Text.Trim();
            model.Addtime = DateTime.Now;
            model.Payment = cbxPayment.Text;
            model.Schedule = string.Empty;
            model.InvoiceNo = string.Empty;


            if (!string.IsNullOrEmpty(this.txtTic.Text) && !this.txtTic.Text.Equals("0.00"))
            {
                wagebll.UpdateTic(cbxEmp.Text, decimal.Parse(this.txtTic.Text.Trim()));
            }
            if (bll.Add(model) > 0) return 1; else return 0;
        }

        private int InsertIncome()
        {
            FinanceManagerSys.Model.Income_Model model = new FinanceSys.FinanceManagerSys.Model.Income_Model();
            FinanceManagerSys.BLL.Income_BLL bll = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();

            model.B = this.txtB.Text.Trim();
            model.BreakMoney = 0;
            model.ContractNo = this.txtcontractno.Text.Trim();
            model.Deductap = 0;
            model.DemoCost = decimal.Parse(this.txtTic.Text.Trim());
            model.DemoName = this.txtDemoname.Text.Trim();
            model.EmpName = cbxEmp.Text;
            model.Incometime = DateTime.Parse(dtptime.Text);
            model.InvoiceMoney = 0;
            model.IsBank = string.Empty;
            model.Money = decimal.Parse(this.txtMoney.Text.Trim());
            model.OperPerson = this.txtOperperson.Text.Trim();
            model.Party = this.txtParty.Text.Trim();
            model.Remark = this.txtRemark.Text.Trim();
            model.Type = cbxType.Text;

            if (bll.Add(model) > 0) return 1; else return 0;
        }

        private void txtDemocost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtDemocost.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值");
                        this.txtDemocost.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtDemocost.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                this.txtDemocost.Clear();
                return;
            }
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

        private void txtTic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtTic.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值");
                        this.txtTic.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtTic.Text.Trim());
                    }
                }

            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                this.txtTic.Clear();
                return;
            }
        }

        private void txtMoney_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtMoney.Clear();
        }

        private void txtDemocost_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtDemocost.Clear();
        }

        private void txtTic_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtTic.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmp.Text.Equals("--无--"))
                this.txtTic.ReadOnly = true;
            else
                this.txtTic.ReadOnly = false;
        }
    }
}
