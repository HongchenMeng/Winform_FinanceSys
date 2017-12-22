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

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_OutlayAdd : Form
    {
        public Form_OutlayAdd()
        {
            InitializeComponent();
            cbotype.Text = cbotype.Items[0].ToString();
            this.txtParty.Focus();
            
        }
        private FinanceSys.PersonnelSys.BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();
        private FinanceManagerSys.BLL.Outlay_BLL outlaybll = new FinanceSys.FinanceManagerSys.BLL.Outlay_BLL();
        
        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            string type = cbotype.Text;
            switch (type)
            {
                case "报销":
                    this.cbotype2.Visible = true;
                    cbotype2.Items.Add("招待费");
                    cbotype2.Items.Add("差旅费");
                    cbotype2.Items.Add("住宿费");
                    cbotype2.Items.Add("停车费");
                    cbotype2.Items.Add("汽油费");
                    cbotype2.Items.Add("通行费");
                    cbotype2.Items.Add("通讯费");
                    cbotype2.Text = cbotype2.Items[0].ToString();
                    break;
                case "税费":
                    cbotype2.Items.Clear();
                    this.cbotype2.Visible = true;
                    cbotype2.Items.Add("营业税");
                    cbotype2.Items.Add("所得税");
                    cbotype2.Items.Add("印花税");
                    cbotype2.Text = cbotype2.Items[0].ToString();
                    break;
                default:
                    this.cbotype2.Visible = false;
                    break;
            }
            #endregion
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                if (this.AddOutlay() > 0)
                {
                    App_Code.Message.InfoMsg("支出成功");
                    this.DialogResult = DialogResult.OK;
                    Log_BLL.Add(DateTime.Now, "财务支出", App_Code.Canshu.LoginName, "财务支出", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 9);
                    this.Close();
                }
            }
        }

        private void Form_OutlayAdd_Load(object sender, EventArgs e)
        {
            this.InitEmpInfo();
        }
        
        private void InitEmpInfo()
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
            else
            {
                this.cbxEmp.Items.Clear();
                this.cbxEmp.DataSource = dt;
                DataRow dr = dt.NewRow();
                dr[dt.Columns[1].ToString()] = "--无--";
                dt.Rows.InsertAt(dr, 0);
                this.cbxEmp.DisplayMember = dt.Columns[1].ToString();
                this.cbxEmp.ValueMember = dt.Columns[1].ToString();
            }
        }

        

        private int AddOutlay() 
        {
            Model.Outlay_Model model = new FinanceSys.FinanceManagerSys.Model.Outlay_Model();
            model.Party = this.txtParty.Text.Trim();
            model.B = this.txtBname.Text.Trim();
            model.ContractNo = this.txtcontractno.Text.Trim();
            model.DemoName = this.txtDemoname.Text.Trim();
            model.EmpName = this.cbxEmp.Text;
            model.Type = cbotype2.Visible == true ? cbotype.Text + "&" + cbotype2.Text : cbotype.Text;
            model.Money = decimal.Parse(this.txtmoney.Text.Trim());
            model.OperPerson = this.txtOperPerson.Text.Trim();
            model.Outlayetime = DateTime.Parse(dtpoutlaytime.Text);
            model.Remark = this.txtRemark.Text.Trim();

            return outlaybll.Add(model);
        }
        /// <summary>
        /// 验证文本框
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtParty.Text))
                {
                    App_Code.Message.InfoMsg("输入甲方名称");
                    return false;
                }
                if (string.IsNullOrEmpty(this.txtmoney.Text.Trim()) || this.txtmoney.Text.Equals("0.00"))
                {
                    App_Code.Message.InfoMsg("输入支出金额");
                    return false;
                }
                if (string.IsNullOrEmpty(this.txtBname.Text))
                {
                    App_Code.Message.InfoMsg("输入乙方名称");
                    return false;
                }
                if (string.IsNullOrEmpty(this.txtOperPerson.Text))
                {
                    App_Code.Message.InfoMsg("输入操作员");
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

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtmoney.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值。");
                        this.txtmoney.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtmoney.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值。");
                this.txtmoney.Clear();
                return;
            }
        }

        private void txtmoney_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtmoney.Clear();
        }
    }
}
