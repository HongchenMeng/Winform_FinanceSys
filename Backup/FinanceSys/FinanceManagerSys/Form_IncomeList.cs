using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_IncomeList : Form
    {
        public Form_IncomeList()
        {
            InitializeComponent();
        }
        private FinanceManagerSys.BLL.Income_BLL incomebll = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();
       
        private void Form_IncomeList_Load(object sender, EventArgs e)
        {
            App_Code.Page.TotalPage = GetCount();
            this.lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
            this.InitIncome();
        }

        public void InitIncome()
        {
            App_Code.Page.curPage = 1;
            DataTable dt = incomebll.GetIList(App_Code.Page.curPage);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvIncome.DataSource = null;
                dgvIncome.DataSource = dt;
                dgvIncome.Columns["编号"].Visible = false;
                dgvIncome.ScrollBars = ScrollBars.Both;
                lblCount.Text = incomebll.GetCountM().ToString() + "$";
                lblCountNum.Text = incomebll.GetList("").Rows.Count.ToString();
                dgvIncome.Columns["编号"].Frozen = true;
                dgvIncome.Columns["项目名称"].Frozen = true;
                dgvIncome.Columns["甲方"].Frozen = true;
                dgvIncome.Columns["乙方"].Frozen = true;
                dgvIncome.Columns["收入金额"].Frozen = true;
                        
                this.IsEnabled();
                this.NotEnabled();
            }
            else { this.NEnabled(); lblCount.Text = "0"; lblCountNum.Text = "0"; }
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
        }
        /// <summary>
        /// 显示与隐藏
        /// </summary>
        private void NEnabled()
        {
             
            //tsbtnOpeninvoice.Enabled = false;
            //tsbtnBreak.Enabled = false;            
            btnBack.Enabled = false;
            btnFind.Enabled = false;
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }
        /// <summary>
        /// 显示与隐藏
        /// </summary>
        private void NotEnabled()
        { 
            //tsbtnOpeninvoice.Enabled = true;
            //tsbtnBreak.Enabled = true;
            btnBack.Enabled = true;
            btnFind.Enabled = true;
            btnFirst.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
        }

        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IsEnabled();
        }
        /// <summary>
        /// 判断收入类型
        /// </summary>
        private void IsEnabled()
        {
            string contract = dgvIncome.SelectedRows[0].Cells["合同编号"].Value.ToString();
            if (contract.Equals("非合同收入"))
            {

                tsbtnBreak.Enabled = false;
                tsbtnOpeninvoice.Enabled = false;
            }
            else
            {
                decimal money = Convert.ToDecimal(dgvIncome.SelectedRows[0].Cells["收入金额"].Value);
                decimal openfmoney = Convert.ToDecimal(dgvIncome.SelectedRows[0].Cells["发票金额"].Value);
                decimal breaks = Convert.ToDecimal(dgvIncome.SelectedRows[0].Cells["回款金额"].Value);
                if (breaks == money && openfmoney == money)
                {
                    tsbtnBreak.Enabled = false;
                    tsbtnOpeninvoice.Enabled = false;
                }
                else
                {
                    tsbtnBreak.Enabled = true;
                    tsbtnOpeninvoice.Enabled = true;
                }
            }
        }
 
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            Form_IncomeType type = new Form_IncomeType();
            if (type.ShowDialog() == DialogResult.OK)
            {
                this.InitIncome();
                dgvIncome.Refresh();
            }
        }

        private void tsbtnBreak_Click(object sender, EventArgs e)
        {
            if (dgvIncome.Rows.Count == 0) { return; }
            else
            {
                string contract = dgvIncome.SelectedRows[0].Cells[6].Value.ToString();
                if (contract.Equals("非合同收入"))
                {
                    return;
                }
                else
                {
                    Form_Break breaks = new Form_Break();
                    App_Code.Canshu.Id = int.Parse(dgvIncome.SelectedRows[0].Cells[0].Value.ToString());
                    if (breaks.ShowDialog() == DialogResult.OK)
                    {
                        this.InitIncome();
                    }
                }
            }
        }

        private void tsbtnOpeninvoice_Click(object sender, EventArgs e)
        {
            if (dgvIncome.Rows.Count == 0) { return; }
            else
            {
                string contract = dgvIncome.SelectedRows[0].Cells[6].Value.ToString();
                if (contract.Equals("非合同收入"))
                {
                    return;
                }
                else
                {
                    Form_OpenInvoice invoice = new Form_OpenInvoice();
                    App_Code.Canshu.Id = int.Parse(dgvIncome.SelectedRows[0].Cells[0].Value.ToString());
                    if (invoice.ShowDialog(this) == DialogResult.OK)
                    {
                        this.InitIncome();
                    }
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
            int result = incomebll.IncomeCount();
            int Total = 0;
            if (result != 0)
            {
                int count = incomebll.IncomeCount() % App_Code.Page.pageCount;
                if (count == 0)
                    Total = incomebll.IncomeCount() / App_Code.Page.pageCount;
                else
                    Total = incomebll.IncomeCount() / App_Code.Page.pageCount + 1;
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
            this.InitIncome();
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
            this.InitIncome();
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
            this.InitIncome();
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
            this.InitIncome();
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
                else if (dgvIncome.Rows.Count == 0 && page == 1)
                {
                    App_Code.Message.ErrorMsg("没有您所要查询的页数。");
                    return;
                }
                else
                {
                    App_Code.Page.curPage = page;
                    this.lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
                    this.InitIncome();
                }
            }
            catch (FormatException)
            {
                App_Code.Message.InfoMsg("所要查询的页数请输入数字。");
                return;
            }
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolbtnRefresh_Click(object sender, EventArgs e)
        {
            if (dgvIncome.Rows.Count == 0) return;
            else
                this.InitIncome();
        }
    }
}
