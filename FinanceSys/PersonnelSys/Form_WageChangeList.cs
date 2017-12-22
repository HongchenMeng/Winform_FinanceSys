using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.FinanceManagerSys;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_WageChangeList : Form
    {
        public Form_WageChangeList()
        {
            InitializeComponent();
        }
        private FinanceManagerSys.BLL.Salary_BLL salarybll = new FinanceSys.FinanceManagerSys.BLL.Salary_BLL();
        private void Form_WageChangeList_Load(object sender, EventArgs e)
        {

            InitWageChangeInfo();
            App_Code.Page.TotalPage = GetCount();
            this.lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
        }
        private void InitWageChangeInfo()
        {
            App_Code.Page.curPage = 1;
            DataTable dt = salarybll.GetIList(App_Code.Page.curPage);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvPayChange.DataSource = null;
                dgvPayChange.DataSource = dt;
                dgvPayChange.Columns["编号"].Visible = false;
                dgvPayChange.ScrollBars = ScrollBars.Both;
            }
            else {
                this.toolbtnRefresh.Enabled = false;
                btnBack.Enabled = false;
                btnFind.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
            
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            Form_WageChange change = new Form_WageChange();
            if (change.ShowDialog(this) == DialogResult.OK)
            {
                this.InitWageChangeInfo();
            }
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 获取分页总数
        /// </summary>
        /// <returns></returns>
        private int GetCount()
        {
            int result = salarybll.SalaryCount();
            int Total = 0;
            if (result != 0)
            {
                int count = salarybll.SalaryCount() % App_Code.Page.pageCount;
                if (count == 0)
                    Total = salarybll.SalaryCount() / App_Code.Page.pageCount;
                else
                    Total = salarybll.SalaryCount() / App_Code.Page.pageCount + 1;
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
            if (App_Code.Page.curPage == 1)
            {
                App_Code.Message.InfoMsg("已经是'第一页'!请点击下一页");
                return;
            }
            App_Code.Page.curPage = 1;
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
            this.InitWageChangeInfo();
        }
        /// <summary>
        /// 上页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (App_Code.Page.curPage > 1)
            {
                App_Code.Page.curPage--;
            }
            else if (App_Code.Page.curPage == 1)
            {
                App_Code.Message.InfoMsg("已经是'第一页'!请点击下一页");
                return;
            }
            else
            {
                App_Code.Page.curPage = 1;
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
            this.InitWageChangeInfo();
        }
        /// <summary>
        /// 下页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (App_Code.Page.curPage == GetCount())
            {
                App_Code.Message.InfoMsg("已经是'最后一页'!请点击上一页");
                return;
            }
            else if (App_Code.Page.curPage < GetCount())
            {
                App_Code.Page.curPage++;
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
            this.InitWageChangeInfo();
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (App_Code.Page.curPage == GetCount())
            {
                App_Code.Message.InfoMsg("已经是'最后一页'!请点击上一页");
                return;
            }
            else
            {
                App_Code.Page.curPage = GetCount();
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
            this.InitWageChangeInfo();
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
                int page = int.Parse(this.txtPage.Text.Trim());
                if (page > this.GetCount() || page < 1)
                {
                    App_Code.Message.ErrorMsg("没有您所要查询的页数。");
                    return;
                }
                else
                {
                    App_Code.Page.curPage = page;
                    this.lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
                    this.InitWageChangeInfo();
                }
            }
            catch (FormatException)
            {
                App_Code.Message.InfoMsg("所要查询的页数请输入数字。");
                return;
            }
        }

        private void toolbtnRefresh_Click(object sender, EventArgs e)
        {
            InitWageChangeInfo();   
        }
    }
}
