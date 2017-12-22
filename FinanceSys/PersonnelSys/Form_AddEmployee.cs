using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_AddEmployee : Form
    {
        public Form_AddEmployee()
        {
            InitializeComponent();
        }

        private void Form_AddEmployee_Load(object sender, EventArgs e)
        {
            BuilTree();
            tvwEmp.Nodes[0].Expand();
            
        }

        private void BuilTree()
        {
            TreeNode nodeAll = new TreeNode();
            nodeAll.Text = "全部知道";
            nodeAll.ImageIndex = 0;
            nodeAll.SelectedImageIndex = 0;
            tvwEmp.Nodes.Add(nodeAll);

            this.BuilType(nodeAll);
        }
        //构造字节点
        private void BuilType(TreeNode parent)
        {
            TreeNode type = new TreeNode();
            AddNode(type, "人事管理", 2, parent);
            string[] str = new string[3];
            str[0] = "添加人员1";
            str[1] = "添加人员2";
            str[2] = "添加人员3";

            if (str.Length>0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    TreeNode Type = new TreeNode();
                    this.AddNode(Type, str[i].ToString(), 3, type);
                }
            }
        }

        private void AddNode(TreeNode node, string txt, int imageindex, TreeNode parent)
        {
            node.Text = txt;
            node.ImageIndex = imageindex;
            node.SelectedImageIndex = imageindex;//5-1-a-s-p-x
            parent.Nodes.Add(node);
        }

      
    }
}
