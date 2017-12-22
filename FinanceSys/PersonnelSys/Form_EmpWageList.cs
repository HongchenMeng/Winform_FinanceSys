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
    public partial class Form_EmpWageList : Form
    {
        public Form_EmpWageList()
        {
            InitializeComponent();
            this.lblTime.Text = DateTime.Now.ToShortDateString();
        }
        private FinanceManagerSys.BLL.Wage_BLL wagebll = new FinanceSys.FinanceManagerSys.BLL.Wage_BLL();
        private void Form_EmpWageList_Load(object sender, EventArgs e)
        {
            InitWageInfo();
            App_Code.Page.TotalPage = GetCount();
            this.lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";           
        }

        public void InitWageInfo()
        {
            App_Code.Page.curPage = 1;
            DataTable dt = wagebll.GetIList(App_Code.Page.curPage);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvWage.DataSource = null;
                dgvWage.DataSource = dt;
                dgvWage.Columns["编号"].Visible = false;
                dgvWage.Columns["月份"].Frozen = true;
                dgvWage.Columns["姓名"].Frozen = true;
                dgvWage.Columns["基本工资"].Frozen = true;
                dgvWage.ScrollBars = ScrollBars.Both;
                this.tsbtnDel.Enabled = true;
                this.tsbtnEdit.Enabled = true;
                this.toolbtnRefresh.Enabled = true;
                this.btnBack.Enabled = true;
                this.btnFind.Enabled = true;
                this.btnFirst.Enabled = true;
                this.btnLast.Enabled = true;
                this.btnNext.Enabled = true;
            }
            else
            {
                dgvWage.DataSource = null;
                this.tsbtnDel.Enabled = false;
                this.tsbtnEdit.Enabled = false;
                this.toolbtnRefresh.Enabled = false;
                this.btnBack.Enabled = false;
                this.btnFind.Enabled = false;
                this.btnFirst.Enabled = false;
                this.btnLast.Enabled = false;
                this.btnNext.Enabled = false;
            }
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
            lblCount.Text = dt.Rows.Count.ToString();
        }         
 
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            Form_EmpWageAdd wageadd = new Form_EmpWageAdd();
            if (wageadd.ShowDialog(this) == DialogResult.OK)
            {
                this.InitWageInfo();
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            PersonnelSys.Form_EmpWageAdd wage = new Form_EmpWageAdd();
            wage.name = dgvWage.SelectedRows[0].Cells[2].Value.ToString();
            if (wage.ShowDialog(this)== DialogResult.OK)
            {
                this.InitWageInfo();
            }
        }

        private void tsbtnDel_Click(object sender, EventArgs e)
        {
            if (App_Code.Message.QuestionMsg("确定删除吗"))
            {
                if (wagebll.Delete(int.Parse(dgvWage.SelectedRows[0].Cells[0].Value.ToString())) > 0)
                {
                    App_Code.Message.InfoMsg("删除成功");
                    this.InitWageInfo();                    
                }
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
            int result = wagebll.WageCount();
            int Total = 0;
            if (result != 0)
            {
                int count = wagebll.WageCount() % App_Code.Page.pageCount;
                if (count == 0)
                    Total = wagebll.WageCount() / App_Code.Page.pageCount;
                else
                    Total = wagebll.WageCount() / App_Code.Page.pageCount + 1;
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
            this.InitWageInfo();
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
            this.InitWageInfo();
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
            this.InitWageInfo();
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
            this.InitWageInfo();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    this.InitWageInfo();
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
            this.InitWageInfo();   
        }
    }
}
