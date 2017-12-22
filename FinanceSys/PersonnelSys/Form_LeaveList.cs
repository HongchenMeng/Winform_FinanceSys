using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebService1;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_LeaveList : Form
    {
        public Form_LeaveList()
        {
            InitializeComponent();
        }
        PersonnelSys.BLL.Left_BLL bll = new FinanceSys.PersonnelSys.BLL.Left_BLL();
        PersonnelSys.Model.Left_Model model = new FinanceSys.PersonnelSys.Model.Left_Model();
        DataTable dt = new DataTable();
        private void Form_LeaveList_Load(object sender, EventArgs e)
        {
            App_Code.Page.TotalPage = GetCount();
            this.lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
            this.InitLeftInto();
        }
        /// <summary>
        /// 信息绑定
        /// </summary>
        private void InitLeftInto()
        {            
            dt = bll.GetList(App_Code.Page.curPage);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvLeave.DataSource = dt;
                dgvLeave.ScrollBars = ScrollBars.Both; 
            }
            else
            {
                btnBack.Enabled = false;
                btnFind.Enabled = false;
                btnFirst.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                toolbtnAll.Enabled = false;
                toolbtnDel.Enabled = false;
                toolbtnSearch.Enabled = false;
                txtPage.ReadOnly = true;
            }
            lblTotalpage.Text = "共" + App_Code.Page.TotalPage.ToString() + "页";
           
        }
        /// <summary>
        /// 获取分页总数
        /// </summary>
        /// <returns></returns>
        private int GetCount()
        {
            int result = bll.LeftCount();
            int Total = 0;
            if (result != 0)
            {
                int count = bll.LeftCount() % App_Code.Page.pageCount;
                if (count == 0)
                    Total = bll.LeftCount() / App_Code.Page.pageCount;
                else
                    Total = bll.LeftCount() / App_Code.Page.pageCount + 1;
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
            this.InitLeftInto();
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
            this.InitLeftInto();
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
            this.InitLeftInto();
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            
            if (App_Code.Page.curPage==GetCount())
            {
                App_Code.Message.InfoMsg("已经是'最后一页'!请点击上一页");
                return;
            }
            else
            {
                App_Code.Page.curPage = GetCount();
            }
            lblCurPage.Text = "第" + App_Code.Page.curPage.ToString() + "页";
            this.InitLeftInto();
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
                    this.InitLeftInto();
                }
            }
            catch (FormatException)
            {
                App_Code.Message.InfoMsg("所要查询的页数请输入数字。");
                return;
            }
        }

        private void toolbtnSearch_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(this.tooltxtContaint.Text))
            {
                App_Code.Message.InfoMsg("输入查询的内容。");
                return;
            }
            else
            {
                if (dt != null)
                {
                    switch (toolcbxSearchtype.Text)
                    {
                        case "姓名":
                            dt = bll.GetList("EmpName", this.tooltxtContaint.Text.Trim());
                            if (dt == null || dt.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dgvLeave.DataSource = dt;
                            }

                            break;
                        case "性别":
                            dt = bll.GetList("Sex", this.tooltxtContaint.Text.Trim());
                            if (dt == null || dt.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dgvLeave.DataSource = dt;
                            }
                            break;
                        default:
                            dt = bll.GetList("DepartName", this.tooltxtContaint.Text.Trim());
                            if (dt == null || dt.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dgvLeave.DataSource = dt;
                            }
                            break;
                    }
                }
            }
        }

        private void toolbtnAll_Click(object sender, EventArgs e)
        {
            this.InitLeftInto();
        }

        private void toolbtnDel_Click(object sender, EventArgs e)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                if (App_Code.Message.QuestionMsg("确定删除吗。删除之后数据无法恢复。"))
                {
                    int item = int.Parse(dgvLeave.SelectedRows[0].Cells[0].Value.ToString());
                    if (item > 0)
                    {
                        if (bll.Delete(item) > 0)
                        {
                            App_Code.Message.InfoMsg("删除成功。");
                            dgvLeave.Refresh();
                            this.InitLeftInto();
                        }
                    }
                    else
                    {
                        App_Code.Message.InfoMsg("删除失败！请联系管理员。");
                        return;
                    }
                }
            }
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
