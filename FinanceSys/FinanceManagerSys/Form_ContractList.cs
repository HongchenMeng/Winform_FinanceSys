using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PublicLibrary;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_ContractList : Form
    {
        private FinanceManagerSys.BLL.Contract_BLL contractbll = new FinanceSys.FinanceManagerSys.BLL.Contract_BLL();
        public Form_ContractList()
        {
            InitializeComponent();
        }

        private void Form_IncomeList_Load(object sender, EventArgs e)
        {
            this.Bind();
            App_Code.Page.TotalPage = GetCount();//分页总数
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
        }

        private void toolbtnRefresh_Click(object sender, EventArgs e)
        {
            this.Bind();
        }

        private void Bind()
        {
            App_Code.Page.curPage = 1;
            DataTable dt = contractbll.GetList(0, App_Code.Page.pageCount);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvIncome.DataSource = null;
                dgvIncome.DataSource = dt;
                dgvIncome.Columns["编号"].Visible = false;
                dgvIncome.Columns["发票编号"].Visible = false;
                dgvIncome.ScrollBars = ScrollBars.Both;
            }
            else { this.IsEnabled(); }
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
        }
        private void IsEnabled()
        {
            toolbtnRefresh.Enabled = false;
            toolSearch.Enabled = false;
            btnBack.Enabled = false;
            btnFind.Enabled = false;
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }
        private void toolSearch_Click(object sender, EventArgs e)
        {
            DataTable dtInfo = new DataTable();
            if (!string.IsNullOrEmpty(cbxContract.Text) && !string.IsNullOrEmpty(txtSerach.Text))
            {
                switch (this.cbxContract.Text)
                {
                    case "合同编号":
                        dtInfo = contractbll.GetListByContract(this.txtSerach.Text.Trim());
                        break;
                    case "甲方名称":
                        dtInfo = contractbll.GetListByParty(this.txtSerach.Text.Trim());
                        break;
                    case "乙方名称":
                        dtInfo = contractbll.GetListByB(this.txtSerach.Text.Trim());
                        break;
                    case "项目名称":
                        dtInfo = contractbll.GetListByDemoName(this.txtSerach.Text.Trim());
                        break;
                    default:
                        break;
                }
                if (dtInfo.Rows.Count == 0)
                {
                    App_Code.Message.InfoMsg("没有您所要查找的记录。");
                    return;
                }
                else
                {
                    dgvIncome.DataSource = null;
                    dgvIncome.DataSource = dtInfo;
                    dgvIncome.Columns["编号"].Visible = false;
                }
            }
            else {
                App_Code.Message.InfoMsg("输入查询的内容。");
                return;
            }
        } 
        /// <summary>
        /// 获取分页总数
        /// </summary>
        /// <returns></returns>
        private int GetCount()
        {
           int result = contractbll.ContractCount();
           int Total = 0;
           if (result != 0)
           {
               int count = contractbll.ContractCount() % App_Code.Page.pageCount;
               if (count == 0)
                   Total = contractbll.ContractCount() / App_Code.Page.pageCount;
               else
                   Total = contractbll.ContractCount() / App_Code.Page.pageCount + 1;
           }
           else
               Total = 0;

           return Total;
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            App_Code.Page.curPage = 1;
            DataTable dt = contractbll.GetList(0, App_Code.Page.pageCount);
            if (dt != null && dt.Rows.Count > 0)
            {
                //绑定数据
                dgvIncome.DataSource = null;
                dgvIncome.DataSource = dt;
                dgvIncome.Columns["编号"].Visible = false;
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
        }
        /// <summary>
        /// 上页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (App_Code.Page.curPage > 1)
                App_Code.Page.curPage--;
            else
                App_Code.Page.curPage = 1;
           DataTable dt = contractbll.GetList((App_Code.Page.curPage - 1) * App_Code.Page.pageCount, App_Code.Page.pageCount);
           if (dt != null && dt.Rows.Count > 0)
           {
                //绑定数据
               dgvIncome.DataSource = null;
               dgvIncome.DataSource = dt;
               dgvIncome.Columns["编号"].Visible = false;
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (App_Code.Page.curPage<App_Code.Page.TotalPage)
                App_Code.Page.curPage++;

            DataTable dt = contractbll.GetList((App_Code.Page.curPage - 1) * App_Code.Page.pageCount, App_Code.Page.pageCount);
            if (dt != null && dt.Rows.Count > 0)
            {
                //绑定数据
                dgvIncome.DataSource = null;
                dgvIncome.DataSource = dt;
                dgvIncome.Columns["编号"].Visible = false;
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            App_Code.Page.curPage = App_Code.Page.TotalPage;
            DataTable dt = contractbll.GetList((App_Code.Page.curPage - 1) * App_Code.Page.pageCount, App_Code.Page.pageCount);
            if (dt != null && dt.Rows.Count > 0)
            {
                //绑定数据
                dgvIncome.DataSource = null;
                dgvIncome.DataSource = dt;
                dgvIncome.Columns["编号"].Visible = false;
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtPage.Text.Trim() == "")
            {
                App_Code.Message.InfoMsg("请输入所要查询的页数。");
                return;
            }
            try
            {
               App_Code.Page.curPage = int.Parse(this.txtPage.Text);
            }
            catch (FormatException)
            {
                App_Code.Message.InfoMsg("所要查询的页数请输入数字。");
                return;
            }
            if (App_Code.Page.curPage > App_Code.Page.TotalPage || App_Code.Page.curPage < 1)
            {
                App_Code.Message.InfoMsg("没有您所要查询的页数。");
                return;
            }

            DataTable dat = contractbll.GetList((App_Code.Page.curPage - 1) * App_Code.Page.pageCount, App_Code.Page.pageCount);

            if (dat != null)
            {                
                //绑定数据
                dgvIncome.DataSource = null;
                dgvIncome.DataSource = dat;
                dgvIncome.Columns["编号"].Visible = false;
            }
            this.lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
