using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PublicLibrary.BLL;
using FinanceSys.PublicLibrary;
using System.Net;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_EmployeeAdd : Form
    {
        private FinanceSys.PublicLibrary.BLL.CompanyInfo_BLL publicbll = new CompanyInfo_BLL();
        private FinanceSys.PersonnelSys.BLL.Department_BLL departbll = new FinanceSys.PersonnelSys.BLL.Department_BLL();
        private FinanceSys.PersonnelSys.BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();
        private FinanceSys.PersonnelSys.Model.Employee_Model empmodel;
        
        public  int id = 0;
        public string depart = string.Empty;
        public string state = string.Empty;
        public string canshu = string.Empty;
        public Form_EmployeeAdd()
        {
            InitializeComponent();
            InitDepaert();// 初始化部门列表           
            cbxSex.Text = cbxSex.Items[0].ToString();
            cbxState.Text = cbxState.Items[0].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                UpdateEmp(id);
                this.DialogResult = DialogResult.OK;
            }           
            else
            {
                if (!string.IsNullOrEmpty(cbxDepart.Text))
                {
                    if (Check() == true)
                    {
                        AddEmp();
                        if (canshu.Equals("empadd"))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        if (canshu.Equals("add"))
                        {
                            //this.Close();
                            //Form_EmployeeList list = new Form_EmployeeList();
                            //list.ShowDialog();                         
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                {
                    App_Code.Message.InfoMsg("请先添加部门。");
                    return;
                }
            }

        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        private void AddEmp()
        {
            empmodel = new FinanceSys.PersonnelSys.Model.Employee_Model();
            empmodel.EmpName = this.txtName.Text.Trim();
            empmodel.Sex = cbxSex.Text;
            empmodel.EntryTime = DateTime.Parse(dtpEntrytime.Text);
            empmodel.DepartID = int.Parse(cbxDepart.SelectedValue.ToString());
            empmodel.Job = this.txtJob.Text.Trim();
            empmodel.Mobile = this.txtMobile.Text.Trim();
            empmodel.OfficePhone = this.txtOffice.Text.Trim();
            empmodel.Status = cbxState.Text;
            empmodel.Remark = this.txtRemark.Text.Trim();

            if (empbll.Add(empmodel) > 0)
            { 
                App_Code.Message.InfoMsg("添加成功。");
                Log_BLL.Add(DateTime.Now, "员工添加", App_Code.Canshu.LoginName, "员工添加", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 2);                 
            }
            else { App_Code.Message.InfoMsg("添加失败。"); }
        }
        /// <summary>
        /// 修改员工信息
        /// </summary>
        private void UpdateEmp(int id)
        {
            empmodel = new FinanceSys.PersonnelSys.Model.Employee_Model();
            empmodel.ID = id;
            empmodel.EmpName = this.txtName.Text.Trim();
            empmodel.Sex = cbxSex.Text;
            empmodel.EntryTime = DateTime.Parse(dtpEntrytime.Text);
            empmodel.DepartID = int.Parse(cbxDepart.SelectedValue.ToString());
            empmodel.Job = this.txtJob.Text.Trim();
            empmodel.Mobile = this.txtMobile.Text.Trim();
            empmodel.OfficePhone = this.txtOffice.Text.Trim();
            empmodel.Status = cbxState.Text;
            empmodel.Remark = this.txtRemark.Text.Trim();

            if (empbll.Update(empmodel) > 0)
            {
                App_Code.Message.InfoMsg("修改成功。");
                Log_BLL.Add(DateTime.Now, "员工信息修改", App_Code.Canshu.LoginName, "员工信息修改", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 3);
                this.Close();
            }
            else { App_Code.Message.InfoMsg("修改失败。"); }
        }

        /// <summary>
        /// 初始化部门列表
        /// </summary>
        private void InitDepaert()
        {
            DataTable dt = departbll.GetList("");
            if (dt != null && dt.Rows.Count != 0)
            {              
                //初始化修改信息界面的部门列表
                this.cbxDepart.Items.Clear();
                this.cbxDepart.DataSource = dt;
                this.cbxDepart.DisplayMember = dt.Columns[1].ToString();
                this.cbxDepart.ValueMember = dt.Columns[0].ToString();
                cbxDepart.Text = cbxDepart.Items[0].ToString();
            }
        }

        private void Form_EmployeeAdd_Load(object sender, EventArgs e)
        {            
            if (id!=0)
            {
                ShowInfo(id);
            }
            if (id != 0 && state.Equals("离职"))
            {
                empmodel = new FinanceSys.PersonnelSys.Model.Employee_Model();
                empmodel = empbll.GetModel(id);
                LeavesTwo(empmodel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 双击时传递的参数接收
        /// </summary>
        private void ShowInfo(int id)
        {
            empmodel = new FinanceSys.PersonnelSys.Model.Employee_Model();
            empmodel = empbll.GetModel(id);
            switch (empmodel.Status)
            {                    
                case "离职":
                    Leaves(empmodel);
                    break;
                default:
                    NoLeave(empmodel);
                    break;
            }           
        }

        private void Leaves(FinanceSys.PersonnelSys.Model.Employee_Model empmodel)
        {
            this.txtJob.ReadOnly = true;
            this.txtName.ReadOnly = true;
            cbxSex.Enabled = false;
            dtpEntrytime.Enabled = false;
            cbxDepart.Enabled = false;
            this.txtJob.ReadOnly = true;
            this.txtMobile.ReadOnly = true;
            this.txtOffice.ReadOnly = true;
            cbxState.Enabled = false;
            this.txtRemark.ReadOnly = true;
            this.txtName.Text = empmodel.EmpName;
            cbxSex.Text = empmodel.Sex;
            dtpEntrytime.Text = empmodel.EntryTime.ToString();
            cbxDepart.Text = departbll.GetModel(empmodel.DepartID).DepartName;
            this.txtJob.Text = empmodel.Job;
            this.txtMobile.Text = empmodel.Mobile;
            this.txtOffice.Text = empmodel.OfficePhone;
            cbxState.Text = empmodel.Status;
            this.txtRemark.Text = empmodel.Remark;
            btnOK.Enabled = false;
        }
        private void LeavesTwo(FinanceSys.PersonnelSys.Model.Employee_Model empmodel)
        {
            this.txtJob.ReadOnly = true;
            this.txtName.ReadOnly = true;
            cbxSex.Enabled = false;
            dtpEntrytime.Enabled = false;
            cbxDepart.Enabled = false;
            this.txtJob.ReadOnly = true;
            this.txtMobile.ReadOnly = true;
            this.txtOffice.ReadOnly = true;
            this.txtRemark.ReadOnly = true;
            this.txtName.Text = empmodel.EmpName;
            cbxSex.Text = empmodel.Sex;
            dtpEntrytime.Text = empmodel.EntryTime.ToString();
            cbxDepart.Text = departbll.GetModel(empmodel.DepartID).DepartName;
            this.txtJob.Text = empmodel.Job;
            this.txtMobile.Text = empmodel.Mobile;
            this.txtOffice.Text = empmodel.OfficePhone;
            cbxState.Text = empmodel.Status;
            this.txtRemark.Text = empmodel.Remark;
        }
        private void NoLeave(FinanceSys.PersonnelSys.Model.Employee_Model empmodel)
        {
            this.txtName.Text = empmodel.EmpName;
            cbxSex.Text = empmodel.Sex;
            dtpEntrytime.Text = empmodel.EntryTime.ToString();
            cbxDepart.Text = departbll.GetModel(empmodel.DepartID).DepartName;
            this.txtJob.Text = empmodel.Job;
            this.txtMobile.Text = empmodel.Mobile;
            this.txtOffice.Text = empmodel.OfficePhone;
            cbxState.Text = empmodel.Status;
            this.txtRemark.Text = empmodel.Remark;
        }
        /// <summary>
        /// 验证文本框
        /// </summary>
        /// <returns></returns>
        private bool Check() {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                App_Code.Message.InfoMsg("输入员工姓名。");
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtJob.Text))
            {
                App_Code.Message.InfoMsg("输入员工职位。");
                return false;
            }
            else if(empbll.Exists(this.txtName.Text.Trim())==true)
            {
                App_Code.Message.InfoMsg("员工姓名出现重复。");
                return false;
            }
            else {
                return true;
            }
        }
    }
}
