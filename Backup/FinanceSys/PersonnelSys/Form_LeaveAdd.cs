using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_LeaveAdd : Form
    {
            
        public Form_LeaveAdd()
        {
            InitializeComponent();
            cbxType.Text = cbxType.Items[0].ToString();
            this.txtApprovalPerson.Focus();
        }
        private FinanceSys.PersonnelSys.BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();
        private FinanceSys.PersonnelSys.Model.Employee_Model empmodel;
        private FinanceSys.PersonnelSys.BLL.Department_BLL departbll = new FinanceSys.PersonnelSys.BLL.Department_BLL();

        private void Form_Leave_Load(object sender, EventArgs e)
        {
            if (App_Code.Canshu.Id != 0)
            {
                ShowInfo(App_Code.Canshu.Id);
            }
        }
        /// <summary>
        /// 双击时传递的参数接收
        /// </summary>
        private void ShowInfo(int id)
        {
            empmodel = new FinanceSys.PersonnelSys.Model.Employee_Model();
            empmodel = empbll.GetModel(id);
            this.txtEmpName.Text = empmodel.EmpName;
            this.txtDepart.Text = departbll.GetModel(empmodel.DepartID).DepartName;
            this.txtRemark.Text = empmodel.Remark;
            this.txtSex.Text = empmodel.Sex;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.InputCheck())
            {
                if (App_Code.Message.QuestionMsg("确定该员工离职吗。"))
                {
                    if (this.AddLeave())
                    {
                        App_Code.Message.InfoMsg("操作成功。");
                        empbll.UpdateCode(App_Code.Canshu.Id);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    else { App_Code.Message.InfoMsg("操作失败。"); }
                }
            }
        }

        private bool AddLeave()
        {
            PersonnelSys.BLL.Left_BLL bll = new FinanceSys.PersonnelSys.BLL.Left_BLL();
            PersonnelSys.Model.Left_Model model = new FinanceSys.PersonnelSys.Model.Left_Model();

            model.ApprovalDempart = this.txtApprovalDempart.Text.Trim();
            model.ApprovalPerson = this.txtApprovalPerson.Text.Trim();
            model.DepartName = this.txtDepart.Text.Trim();
            model.EID = App_Code.Canshu.Id;
            model.EmpName = this.txtEmpName.Text.Trim();
            model.LeftReason = this.txtReason.Text.Trim();
            model.LeftTime = DateTime.Parse(dtpTime.Text);
            model.LeftType = cbxType.Text;
            model.Remark = this.txtRemark.Text.Trim();
            model.Sex = this.txtSex.Text.Trim();


            if (bll.Add(model) > 0)
            {
                return true;
            }
            else { return false; }
        }

        private bool InputCheck()
        {
            if (string.IsNullOrEmpty(this.txtApprovalPerson.Text))
            {
                App_Code.Message.InfoMsg("填写批准人。");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtApprovalDempart.Text))
            {
                App_Code.Message.InfoMsg("填写批准人所在部门。");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtReason.Text))
            {
                App_Code.Message.InfoMsg("填写离职原因。");
                return false;
            }
            else { return true; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
