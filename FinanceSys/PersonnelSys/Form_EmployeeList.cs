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
    public partial class Form_EmployeeList : Form
    {
        private FinanceSys.PublicLibrary.BLL.CompanyInfo_BLL publicbll = new CompanyInfo_BLL();
        private FinanceSys.PersonnelSys.BLL.Department_BLL personnelbll = new FinanceSys.PersonnelSys.BLL.Department_BLL();
        private FinanceSys.PersonnelSys.BLL.Employee_BLL empbll = new FinanceSys.PersonnelSys.BLL.Employee_BLL();

        private TreeNode Root;
        DataTable dat = new DataTable("emp");//用来接受查询结果
        public Form_EmployeeList()
        {
            InitializeComponent();
            this.IsNull();
        }

        private void Form_AddEmployee_Load(object sender, EventArgs e)
        {           
            this.InitTree(); //初始化员工树
            this.InitDbgEmp();//初始化员工信息           
        }

      
         /// <summary>
        /// 构造员工树
        /// </summary>
        private void InitTree()
        {
            DataTable dt = publicbll.GetList();
            if (dt != null)
            {
                tvwEmp.Nodes.Clear();
                Root = new TreeNode();
                Root.Text = dt.Rows[0][1].ToString();
                Root.ImageIndex = 4;
                Root.SelectedImageIndex = 4;
                this.tvwEmp.Nodes.Add(Root);
                this.InitTreeDepart(Root);//加载树的部门节点
                Root.Expand();

            }
        }
         /// <summary>
        /// 出示化部门节点
        /// </summary>
        /// <param name="parent">父节点</param>
        private void InitTreeDepart(TreeNode parent)
        {
            DataTable dt = personnelbll.GetList("");

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode deprt = new TreeNode();
                    deprt.Text = dt.Rows[i][1].ToString();
                    deprt.Tag = dt.Rows[i][0].ToString();
                    deprt.ImageIndex = 1;
                    deprt.SelectedImageIndex = 1;
                    parent.Nodes.Add(deprt);
                    this.InitEmp(int.Parse(deprt.Tag.ToString()), deprt);//加载树员工节点
                }
            }
        }

        /// <summary>
        /// 初始化员工节点
        /// </summary>
        /// <param name="departid">部门id</param>
        /// <param name="parent">父节点</param>
        private void InitEmp(int departid, TreeNode parent)
        {
            DataTable dt = empbll.GetEmpByDepart(departid);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode emp = new TreeNode();
                    emp.Text = dt.Rows[i][1].ToString();
                    emp.Tag = dt.Rows[i][0].ToString();
                    emp.ImageIndex = 2;
                    emp.SelectedImageIndex = 2;
                    parent.Nodes.Add(emp);

                }
            }
        }
        /// <summary>
        /// 初始化员工表
        /// </summary>
        private void InitDbgEmp()
        {
            dat = empbll.GetList("","");
            if (dat != null && dat.Rows.Count > 0)
            {
                this.dbgEmp.DataSource = null;
                this.dbgEmp.DataSource = dat;
            }
            else {
                toolbtnAll.Enabled = false;
                toolbtnRefresh.Enabled = false;
                toolbtnSearch.Enabled = false;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                btnLeave.Enabled = false;

            }

        }
        /// <summary>
        /// 根据点击树上的不同节点对员工表进行过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwEmp_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataView dv = new DataView(dat);
            if (e.Node.Parent == null && e.Node != null)
            {
                this.InitDbgEmp();
            }
            if (e.Node.Parent != null)
            {
                //如果点击的是部门节点则按部门过滤
                if (e.Node.Parent.Parent == null && e.Node != null)
                {
                    dv.RowFilter = "所在部门='" + tvwEmp.SelectedNode.Text + "'";
                    this.dbgEmp.DataSource = dv;
                    return;

                }
                //如果点击的是员工节点则按工号过滤
                if (e.Node.Parent.Parent.Parent == null && e.Node != null)
                {
                    string filterstr = string.Format("工号={0}", tvwEmp.SelectedNode.Tag);
                    dv.RowFilter = filterstr;

                    this.dbgEmp.DataSource = dv;
                    return;
                }
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonnelSys.Form_EmployeeAdd add = new Form_EmployeeAdd();
            add.canshu = "empadd";
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                this.InitDbgEmp();//初始化员工信息
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dbgEmp.Rows.Count == 0)
            { return; }
            else
            {
                DataTable dt = IsNull();
                if (dat != null && dat.Rows.Count != 0)
                {
                    PersonnelSys.Form_EmployeeAdd add = new Form_EmployeeAdd();
                    add.id = int.Parse(dbgEmp.SelectedRows[0].Cells[0].Value.ToString());
                    if (add.ShowDialog(this) == DialogResult.OK)
                    {
                        this.InitDbgEmp();
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dbgEmp.Rows.Count == 0)
            { return; }
            else
            {
                DataTable dt = IsNull();
                if (dat != null && dat.Rows.Count > 0)
                {
                    if (App_Code.Message.QuestionMsg("确定删除吗"))
                    {
                        if (empbll.Delete(int.Parse(dbgEmp.SelectedRows[0].Cells[0].Value.ToString())) > 0)
                        {
                            App_Code.Message.InfoMsg("删除成功");
                            Log_BLL.Add(DateTime.Now, "员工删除", App_Code.Canshu.LoginName, "员工删除", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 4);
                            this.InitTree();
                            this.InitDbgEmp();
                        }
                    }
                }
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (dbgEmp.Rows.Count == 0)
            { return; }
            else
            {
                DataTable dt = IsNull();
                if (dat != null && dat.Rows.Count > 0)
                {
                    if (int.Parse(dbgEmp.SelectedRows[0].Cells[0].Value.ToString()) > 0)
                    {
                        PersonnelSys.Form_LeaveAdd add = new Form_LeaveAdd();
                        App_Code.Canshu.Id = int.Parse(dbgEmp.SelectedRows[0].Cells[0].Value.ToString());
                        add.ShowDialog();
                        this.InitDbgEmp();
                    }
                }
            }
        }

        private DataTable IsNull()
        { 
            dat = empbll.GetList("","");
            if (dat != null && dat.Rows.Count > 0)
                return dat;
            else
                return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolbtnRefresh_Click(object sender, EventArgs e)
        {
            this.InitDbgEmp();
        }

        private void toolbtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtInfo = new DataTable();
            if (string.IsNullOrEmpty(this.tooltxtContaint.Text))
            {
                App_Code.Message.InfoMsg("输入查询的内容。");
                return;
            }
            else
            {
                if (dat != null && dat.Rows.Count != 0)
                {
                    switch (toolcbxSearchtype.Text)
                    {
                        case "工号":
                            dtInfo = empbll.GetList("ID", this.tooltxtContaint.Text.Trim());
                            if (dtInfo == null || dtInfo.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dbgEmp.DataSource = dtInfo;
                            }
                            break;
                        case "姓名":
                            dtInfo = empbll.GetList("EmpName", this.tooltxtContaint.Text.Trim());
                            if (dtInfo == null || dtInfo.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dbgEmp.DataSource = dtInfo;
                            }

                            break;
                        case "性别":
                            dtInfo = empbll.GetList("Sex", this.tooltxtContaint.Text.Trim());
                            if (dtInfo == null || dtInfo.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dbgEmp.DataSource = dtInfo;
                            }
                            break;
                        default:
                            dtInfo = empbll.GetList("DepartID", this.tooltxtContaint.Text.Trim());
                            if (dtInfo == null || dtInfo.Rows.Count == 0)
                            {
                                App_Code.Message.InfoMsg("没有您所要查找的记录。");
                                return;
                            }
                            else
                            {
                                dbgEmp.DataSource = dtInfo;
                            }
                            break;
                    }
                }
            }
        }

        private void toolbtnAll_Click(object sender, EventArgs e)
        {
            this.InitDbgEmp();
            this.tooltxtContaint.Clear();
        }
    }
}
