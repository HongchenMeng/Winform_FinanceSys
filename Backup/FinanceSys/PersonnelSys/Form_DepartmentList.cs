using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using FinanceSys.PublicLibrary.BLL;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_DepartmentList : Form
    {
        private FinanceSys.PublicLibrary.BLL.CompanyInfo_BLL ConpanyInfo = new CompanyInfo_BLL();
        private FinanceSys.PersonnelSys.BLL.Department_BLL Depart = new FinanceSys.PersonnelSys.BLL.Department_BLL();
        public Form_DepartmentList()
        {
            InitializeComponent();
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);// 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            UpdateStyles();
        }
        static string selecttxt = "";
        static bool isAdd = false;

        private void Form_DepartmentList_Load(object sender, EventArgs e)
        {
            BuidTree();
        }
        /// <summary>
        /// 构造树
        /// </summary>  
        /// 
        TreeNode RootNode = null;
        ArrayList newdepartlist = new ArrayList();

        private void BuidTree()
        {
            tvwDeparts.Nodes.Clear();
            DataTable dt = ConpanyInfo.GetList();
            if (dt != null && dt.Rows.Count > 0)
            {
                tvwDeparts.Nodes.Clear();
                RootNode = new TreeNode();
                RootNode.Text = dt.Rows[0][1].ToString();//跟节点的文本为本单位的名称
                RootNode.ImageIndex = 0;
                RootNode.SelectedImageIndex = 0;
                tvwDeparts.Nodes.Add(RootNode);

                this.BuildNodesDepart(RootNode);//加载部门节点


            }

        }
        /// <summary>
        /// 构造本单位树的部门节点
        /// </summary>
        /// <param name="parent"></param>
        ///   
        private void BuildNodesDepart(TreeNode parent)
        {
            DataTable dt = Depart.GetList("");
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode depart = new TreeNode();
                    depart.Text = dt.Rows[i][1].ToString();
                    depart.Tag = dt.Rows[i][0].ToString();
                    depart.ImageIndex = 1;
                    depart.SelectedImageIndex = 1;
                    parent.Nodes.Add(depart);

                }
                tvwDeparts.ExpandAll();
            }
        }
        /// <summary>
        /// 添加默认节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnnAddNode_Click(object sender, EventArgs e)
        {
            this.AddNodes();
        }
        /// <summary>
        /// 添加节点
        /// </summary>
        private void AddNodes()
        {
            isAdd = true;

            tvwDeparts.LabelEdit = true;//开启节点编辑
            btnSaves.Enabled = true;
            btnCancels.Enabled = true;
            btnUpdates.Enabled = false;
            btnDels.Enabled = false;

            TreeNode newdepart = new TreeNode();
            newdepart.Text = "请输入新部门名称";
            newdepart.ImageIndex = 1;
            newdepart.SelectedImageIndex = 1;
            newdepart.Tag = "new";
            RootNode.Nodes.Add(newdepart);

            newdepart.BeginEdit();

        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancels_Click(object sender, EventArgs e)
        {
            this.CancelAdd();

        }
        /// <summary>
        ///  取消添加
        /// </summary>
        private void CancelAdd()
        {
            for (int i = tvwDeparts.Nodes[0].Nodes.Count - 1; i >= 0; i--)
            {
                if (this.tvwDeparts.Nodes[0].Nodes[i].Tag.ToString() == "new")
                {
                    this.tvwDeparts.Nodes.Remove(tvwDeparts.Nodes[0].Nodes[i]);

                }
            }


            this.btnUpdates.Enabled = true;
            
            this.btnSaves.Enabled = false;
            btnDels.Enabled = true;
            this.tvwDeparts.LabelEdit = false;

            isAdd = false;
        }

        private void btnSaves_Click(object sender, EventArgs e)
        {
            if (isAdd)//如果是添加
            {
                this.AddDepart();

            }
            else
            {
                this.Updatedepart();//是修改
            }


        }

        private void AddDepart()
        {
            int flag = 0;
            GetNodes(RootNode);
            for (int i = 0; i < newdepartlist.Count; i++)
            {
                if (newdepartlist[i].ToString() == "请输入新部门名称")
                {
                    flag++;

                }
            }
            if (flag > 0)
            {
                App_Code.Message.ErrorMsg("添加失败，请输入合法的部门名称。");
                return;
            }
            else
            {

                for (int i = 0; i < newdepartlist.Count; i++)
                {


                    //循环向数据库中添加
                    if (Depart.Add(newdepartlist[i].ToString())>0)
                    {
                        flag = 0;
                        tvwDeparts.LabelEdit = false;//关闭节点编辑
                        tvwDeparts.Nodes.Clear();
                        btnCancels.Enabled = false;
                        btnSaves.Enabled = false;
                        btnUpdates.Enabled = true;
                        btnDels.Enabled = true;
                        this.BuidTree();

                    }
                    else
                    {
                        App_Code.Message.InfoMsg(newdepartlist[i].ToString() + "  添加失败。");
                    }

                }
            }

        } /// <summary>
        /// 向数据库中跟新数据
        /// </summary>
        private void Updatedepart()
        {

            selecttxt = tvwDeparts.SelectedNode.Text;
            if (Depart.Update(tvwDeparts.SelectedNode.Text, int.Parse(tvwDeparts.SelectedNode.Tag.ToString())))
            {
                App_Code.Message.InfoMsg("修改成功。");
                btnSaves.Enabled = false;
                btnUpdates.Enabled = true;
                btnnAddNode.Enabled = true;
                tvwDeparts.LabelEdit = false;
                btnDels.Enabled = true;
            }
            else
            {
                App_Code.Message.InfoMsg("修改失败。");
                tvwDeparts.SelectedNode.Text = selecttxt;
                tvwDeparts.SelectedNode.BeginEdit();

            }

        }

        /// <summary>
        /// 遍历部门树，得到新添加的项
        /// </summary>
        /// <param name="tnParent"></param>
        private void GetNodes(TreeNode tnParent)
        {
            if (tnParent != null)
            {
                foreach (TreeNode tn in tnParent.Nodes)
                {
                    //如果发现新添加的部门就将新部门放到arrylist 中
                    if (tn.Tag.ToString() == "new")
                    {
                        newdepartlist.Add(tn.Text);
                    }
                    GetNodes(tn);
                }
            }
        }

        private void btnDels_Click(object sender, EventArgs e)
        {
            this.Del();
          
       
        
        
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        private void Del()
        {
            if (tvwDeparts.SelectedNode == null)
            {
                App_Code.Message.InfoMsg("请选择所要删除的部门");
                return;
            }
            if (tvwDeparts.SelectedNode.Parent == null)
            {
                App_Code.Message.InfoMsg("您不能删除该节点");
                return;

            }
            if (App_Code.Message.QuestionMsg("您确定要删除该部门吗？"))
            {

                if (Depart.Delete(int.Parse(tvwDeparts.SelectedNode.Tag.ToString()))>0)
                {
                    this.tvwDeparts.SelectedNode.Remove();
                    this.BuidTree();
                }
                else
                {
                    App_Code.Message.ErrorMsg("删除失败。");

                }

            }
        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            this.updatedtree();


        }
        /// <summary>
        /// 修改树的部门节点
        /// </summary>
        private void updatedtree()
        {
            if (tvwDeparts.SelectedNode == null)
            {
                App_Code.Message.InfoMsg("请选择部门。");
                return;
            }
            if (tvwDeparts.SelectedNode.Parent == null)
            {
                App_Code.Message.InfoMsg("您不能修改该节点。");
                return;
            }
            isAdd = false;

            tvwDeparts.LabelEdit = true;
            tvwDeparts.SelectedNode.BeginEdit();
            btnSaves.Enabled = true;
            btnUpdates.Enabled = false;
            btnnAddNode.Enabled = false;
            btnDels.Enabled = false;
            
        }
    }
}
