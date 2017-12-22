using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PersonnelSys;
using FinanceSys.PublicLibrary;
namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_OutlayList : Form
    {
        public Form_OutlayList()
        {
            InitializeComponent();
        }
        private FinanceManagerSys.BLL.Outlay_BLL outlaybll = new FinanceSys.FinanceManagerSys.BLL.Outlay_BLL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FinanceManagerSys.Form_OutlayAdd outlay = new Form_OutlayAdd();
            outlay.ShowDialog();
        }

        private void Form_OutlayList_Load(object sender, EventArgs e)
        {
            this.InitOutlay();
            App_Code.Page.TotalPage = GetCount();
            this.lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
        }


        private void btnOut_Click(object sender, EventArgs e)
        {
            Form_OutlayAdd add = new Form_OutlayAdd();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                this.InitOutlay();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excels.Input_Excel(dgvOutlay);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 获取分页总数
        /// </summary>
        /// <returns></returns>
        private int GetCount()
        {
            int result = outlaybll.OutlayCount();
            int Total = 0;
            if (result != 0)
            {
                int count = outlaybll.OutlayCount() % App_Code.Page.pageCount;
                if (count == 0)
                    Total = outlaybll.OutlayCount() / App_Code.Page.pageCount;
                else
                    Total = outlaybll.OutlayCount() / App_Code.Page.pageCount + 1;
            }
            else
                Total = 0;

            return Total;
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (App_Code.Page.curPage == 1)
            {
                App_Code.Message.InfoMsg("已经是'第一页'!请点击下一页");
                return;
            }
            App_Code.Page.curPage = 1;
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
            this.InitOutlay();
        }

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
            this.InitOutlay();
        }

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
            this.InitOutlay();
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
            this.InitOutlay();
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
                    this.InitOutlay();
                }
            }
            catch (FormatException)
            {
                App_Code.Message.InfoMsg("所要查询的页数请输入数字。");
                return;
            }
        }

        private void InitOutlay()
        {
            App_Code.Page.curPage = 1;
            DataTable dt = outlaybll.GetIList(App_Code.Page.curPage);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvOutlay.DataSource = null;                
                dgvOutlay.DataSource = dt;
                dgvOutlay.Columns["编号"].Visible = false;
                dgvOutlay.ScrollBars = ScrollBars.Both;
                this.NotEnabled();
            }
            else { this.IsEnabled(); }
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
        }
        private void IsEnabled()
        {
            toolbtnRefresh.Enabled = false;
            btnExcel.Enabled = false;
            btnBack.Enabled = false;
            btnFind.Enabled = false;
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }
        private void NotEnabled()
        {
            toolbtnRefresh.Enabled = true;
            btnExcel.Enabled = true;
            btnBack.Enabled = true;
            btnFind.Enabled = true;
            btnFirst.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
        }
        private void toolbtnRefresh_Click_1(object sender, EventArgs e)
        {
            this.InitOutlay();
        }
    }
}
