using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PersonnelSys;
using FinanceSys.FinanceManagerSys;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_EmpWageAdd : Form
    {

        #region
        private BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();
        private FinanceManagerSys.BLL.Wage_BLL wagebll = new FinanceSys.FinanceManagerSys.BLL.Wage_BLL();
        private FinanceManagerSys.Model.Wage_Model wagemodel = new FinanceSys.FinanceManagerSys.Model.Wage_Model();
        public string str = string.Empty;
        public string time = string.Empty;
        public string name = string.Empty;
        #endregion

        public Form_EmpWageAdd()
        {
            InitializeComponent();
            this.txtBasicWage.Focus();
        }

        private void InitEmpInfo()
        {
           DataTable dt = empbll.GetList();
           if (dt != null && dt.Rows.Count > 0)
           {
               this.cbxEmp.Items.Clear();
               this.cbxEmp.DataSource = dt;
               this.cbxEmp.DisplayMember = dt.Columns[1].ToString();
               this.cbxEmp.ValueMember = dt.Columns[0].ToString();
           }
           else
           {
               this.btnOK.Enabled = false;
           }
        }

        private void Form_EmpWageAdd_Load(object sender, EventArgs e)
        {
            InitEmpInfo();//加载员工名称
            if (!string.IsNullOrEmpty(name))
            {
                this.ShowWageInfo(name);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxEmp.Text))
            {
                if (wagebll.Exists(cbxEmp.Text)>0)
                {
                    this.UpWageInfo(wagebll.Exists(cbxEmp.Text));
                    this.DialogResult = DialogResult.OK;
                    App_Code.Message.InfoMsg("修改成功");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (InputCheck())
                    {
                        if (this.AddWageInfo() > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            App_Code.Message.InfoMsg("添加成功");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else { App_Code.Message.InfoMsg("添加失败"); }
                    }
                }
            }
            else { App_Code.Message.InfoMsg("先添加员工信息"); }
        }
        /// <summary>
        /// 验证文本框
        /// </summary>
        /// <returns></returns>
        private bool InputCheck() {
            try
            {
                if (string.IsNullOrEmpty(this.cbxEmp.Text))
                {
                    App_Code.Message.InfoMsg("请先添加员工信息");
                    return false;
                }
                else if (string.IsNullOrEmpty(this.txtBasicWage.Text))
                {
                    App_Code.Message.InfoMsg("输入员工基本工资");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("请输入正确的数值");
                return false;
            }
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="id"></param>
        private void UpWageInfo(int id)
        {
            FinanceManagerSys.Model.Wage_Model wagemodel = new FinanceSys.FinanceManagerSys.Model.Wage_Model();
            wagemodel.ID = id;
            try
            {
                wagemodel.Allowance = decimal.Parse(this.txtAllowance.Text.Trim());
                wagemodel.BasicWage = decimal.Parse(this.txtBasicWage.Text.Trim());
                wagemodel.Bonus = decimal.Parse(this.txtBonus.Text.Trim());
                wagemodel.EmpName = this.cbxEmp.Text;
                wagemodel.Month = DateTime.Parse(dtptime.Text);
                wagemodel.Jobsubsidies = decimal.Parse(this.txtJobsubsidies.Text.Trim());
                wagemodel.Other = decimal.Parse(this.txtOther.Text.Trim());
                wagemodel.Overtimepay = decimal.Parse(this.txtOvertimepay.Text.Trim());
                wagemodel.PersonalIncomeTax = decimal.Parse(this.txtPersonalIncomeTax.Text.Trim());
                wagemodel.Remark = this.txtRemark.Text.Trim();
                wagemodel.SocialSecurity = decimal.Parse(this.txtSocialSecurity.Text.Trim());                
                wagebll.Update(wagemodel);
            }
            catch
            {
                App_Code.Message.InfoMsg("输入正确的数值");
            }
        }

        private int AddWageInfo()
        {
            FinanceManagerSys.Model.Wage_Model wagemodel = new FinanceSys.FinanceManagerSys.Model.Wage_Model();
            try
            {
                wagemodel.Month = DateTime.Parse(this.dtptime.Text);
                wagemodel.Allowance = decimal.Parse(this.txtAllowance.Text.Trim());
                wagemodel.BasicWage = decimal.Parse(this.txtBasicWage.Text.Trim());
                wagemodel.Bonus = decimal.Parse(this.txtBonus.Text.Trim());
                wagemodel.EmpName = this.cbxEmp.Text;
                wagemodel.Jobsubsidies = decimal.Parse(this.txtJobsubsidies.Text.Trim());
                wagemodel.Other = decimal.Parse(this.txtOther.Text.Trim());
                wagemodel.Overtimepay = decimal.Parse(this.txtOvertimepay.Text.Trim());
                wagemodel.PersonalIncomeTax = decimal.Parse(this.txtPersonalIncomeTax.Text.Trim());
                wagemodel.Remark = this.txtRemark.Text.Trim();
                wagemodel.SocialSecurity = decimal.Parse(this.txtSocialSecurity.Text.Trim());                
            }
            catch
            {
                App_Code.Message.InfoMsg("输入正确的数值");
                return 0;
            }

            return wagebll.Add(wagemodel);
        }

        private void ShowWageInfo(string name)
        {
            wagemodel = wagebll.GetModel(name);
            this.dtptime.Text = wagemodel.Month.ToString();
            this.cbxEmp.Text = wagemodel.EmpName;
            this.txtBasicWage.Text = wagemodel.BasicWage.ToString();
            this.txtBonus.Text = wagemodel.Bonus.ToString();
            this.txtAllowance.Text = wagemodel.Allowance.ToString();
            this.txtJobsubsidies.Text = wagemodel.Jobsubsidies.ToString();
            this.txtOvertimepay.Text = wagemodel.Overtimepay.ToString();
            this.txtPersonalIncomeTax.Text = wagemodel.PersonalIncomeTax.ToString();
            this.txtSocialSecurity.Text = wagemodel.SocialSecurity.ToString();
            this.txtRemark.Text = wagemodel.Remark;
            this.txtOther.Text = wagemodel.Other.ToString();            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBasicWage_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string txt = this.txtBasicWage.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtBasicWage.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtBasicWage.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtBasicWage.Clear();
                return;
            }
        }

        private void txtBasicWage_MouseDown(object sender, MouseEventArgs e)
        {
            txtBasicWage.Clear();
        }

        private void txtOvertimepay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtOvertimepay.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtOvertimepay.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtOvertimepay.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtOvertimepay.Clear();
                return;
            }
        }

        private void txtOvertimepay_MouseDown(object sender, MouseEventArgs e)
        {
            txtOvertimepay.Clear();
        }

        private void txtJobsubsidies_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtJobsubsidies.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtJobsubsidies.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtJobsubsidies.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtJobsubsidies.Clear();
                return;
            }
        }

        private void txtJobsubsidies_MouseDown(object sender, MouseEventArgs e)
        {
            txtJobsubsidies.Clear();
        }

        private void txtAllowance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtAllowance.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtAllowance.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtAllowance.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtAllowance.Clear();
                return;
            }
        }

        private void txtAllowance_MouseDown(object sender, MouseEventArgs e)
        {
            txtAllowance.Clear();
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtBonus.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtBonus.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtBonus.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtBonus.Clear();
                return;
            }
        }

        private void txtBonus_MouseDown(object sender, MouseEventArgs e)
        {
            txtBonus.Clear();
        }

        private void txtPersonalIncomeTax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtPersonalIncomeTax.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtPersonalIncomeTax.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtPersonalIncomeTax.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtPersonalIncomeTax.Clear();
                return;
            }
        }

        private void txtPersonalIncomeTax_MouseDown(object sender, MouseEventArgs e)
        {
            txtPersonalIncomeTax.Clear();
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtOther.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtOther.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtOther.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtOther.Clear();
                return;
            }
        }

        private void txtOther_MouseDown(object sender, MouseEventArgs e)
        {
            txtOther.Clear();
        }

        private void txtSocialSecurity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtSocialSecurity.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtSocialSecurity.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtSocialSecurity.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtSocialSecurity.Clear();
                return;
            }
        }

        private void txtSocialSecurity_MouseDown(object sender, MouseEventArgs e)
        {
            txtSocialSecurity.Clear();
        }
     
    }
}
