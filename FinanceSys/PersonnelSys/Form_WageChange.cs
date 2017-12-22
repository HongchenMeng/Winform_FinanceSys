using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PersonnelSys;
using FinanceSys.PublicLibrary;
using System.Net;
using FinanceSys.PublicLibrary.BLL;
namespace FinanceSys.PersonnelSys
{
    public partial class Form_WageChange : Form
    {
        public Form_WageChange()
        {
            InitializeComponent();
            this.txtNewSalary.Focus();
        }
        private BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();
        private FinanceManagerSys.BLL.Wage_BLL wagebll = new FinanceSys.FinanceManagerSys.BLL.Wage_BLL();
        private FinanceManagerSys.BLL.Salary_BLL salarybll = new FinanceSys.FinanceManagerSys.BLL.Salary_BLL();
        
        private void GetBasicWage()
        {
            if (!string.IsNullOrEmpty(cbxEmp.Text))
            {                
                if (wagebll.GetEmpBasicWage(cbxEmp.Text) != 0)
                {
                    this.btnSave.Enabled = true;
                    this.txtOldSalary.Text = wagebll.GetEmpBasicWage(cbxEmp.Text).ToString();
                }
                else
                {
                    this.txtOldSalary.Text = "0.00";
                    this.btnSave.Enabled = false;
                }
            }
        }
        private void InitEmpInfo()
        {
            DataTable dt = empbll.GetList();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.cbxEmp.Items.Clear();
                this.cbxEmp.DataSource = dt;
                this.cbxEmp.DisplayMember = dt.Columns[1].ToString();
                this.cbxEmp.ValueMember = dt.Columns[1].ToString();
            }
            else {
                this.btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (wagebll.GetEmpBasicWage(cbxEmp.Text) == 0)
            {
                this.btnSave.Enabled = false;
                App_Code.Message.InfoMsg("请先添加此员工的工资基本信息");
                return;
            }
            else
            {
                if (this.CheckInput())
                {
                    if (App_Code.Message.QuestionMsg("确定更改吗"))
                    {
                        //if (this.AddSalaryInfo() > 0 && UpdateSalary(cbxEmp.Text, decimal.Parse(this.txtNewSalary.Text.Trim())) > 0)
                        if (this.AddSalaryInfo() > 0)
                        {
                            App_Code.Message.InfoMsg("操作成功");
                            this.DialogResult = DialogResult.OK;//返回窗体值
                            Log_BLL.Add(DateTime.Now, "员工工资调整", App_Code.Canshu.LoginName, "员工工资调整", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 6);
                            this.Close();
                        }
                    }
                }
            }
        }
        private int UpdateSalary(string name,decimal wage)
        {
            return wagebll.Update(name, wage);
        }
        private int AddSalaryInfo()
        {
            FinanceManagerSys.Model.Salary_Model salarymodel = new FinanceSys.FinanceManagerSys.Model.Salary_Model();
            try {
                salarymodel.NewSalary = decimal.Parse(this.txtNewSalary.Text.Trim());
                salarymodel.OldSalary = decimal.Parse(this.txtOldSalary.Text.Trim());
                salarymodel.EmpName = cbxEmp.Text;
                salarymodel.OperPerson = this.txtOperPerson.Text.Trim();
                salarymodel.PubDate = DateTime.Parse(dtpPubDate.Text);
                salarymodel.Reason = this.txtReason.Text.Trim();
                salarymodel.Remark = this.txtRemark.Text.Trim();
            }
            catch {
                App_Code.Message.InfoMsg("请输入正确的数值");
            }

            return salarybll.Add(salarymodel);
        }
        
        private bool CheckInput()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNewSalary.Text.Trim()) || this.txtNewSalary.Text.Equals("0.00"))
                {
                    App_Code.Message.InfoMsg("请输入变动后的工资");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtOperPerson.Text.Trim()))
                {
                    App_Code.Message.InfoMsg("请输入操作员");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                App_Code.Message.InfoMsg("请输入正确的数值");
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Form_WageChange_Load(object sender, EventArgs e)
        {
            InitEmpInfo();
            GetBasicWage();
        }

        private void cbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBasicWage();
        }
        private void txtNewSalary_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string txt = this.txtNewSalary.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtNewSalary.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtNewSalary.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtNewSalary.Clear();
                return;
            }
        }

        private void txtNewSalary_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewSalary.Clear();
        }
    }
}
