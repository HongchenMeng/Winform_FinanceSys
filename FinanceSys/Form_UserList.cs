using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys
{
    public partial class Form_UserList : Form
    {
        public Form_UserList()
        {
            InitializeComponent();
        }

        PersonnelSys.BLL.Users_BLL userbll = new FinanceSys.PersonnelSys.BLL.Users_BLL();
        private void Form_UserList_Load(object sender, EventArgs e)
        {
            this.Binds();
        }
        private void Binds()
        {
            DataTable dtInfo = userbll.GetUserList();
            if (dtInfo.Rows.Count > 0 && dtInfo != null)
            {
                dgvUserList.DataSource = dtInfo;
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_UserAdd useradd = new Form_UserAdd();
            if (useradd.ShowDialog(this) == DialogResult.OK)
            {
                this.Binds();
            }
        }
        //启用账户
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            object obj = dgvUserList.SelectedRows[0].Cells[1].Value;
            if (obj != null && obj != DBNull.Value)
            {
                string str = obj.ToString();
                if (str.Equals("admin"))
                {
                    App_Code.Message.InfoMsg("不能停用管理员账户");
                    return;
                }
                else
                {
                    object obj2 = dgvUserList.SelectedRows[0].Cells[0].Value;
                    if (obj2 != null && obj2 != DBNull.Value)
                    {
                        if (userbll.UpdateEnabled(Convert.ToInt32(obj2), "否")) { App_Code.Message.InfoMsg("操作成功"); }
                        this.Binds();
                    }
                }
            }
        }
        //停用账户
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            object obj = dgvUserList.SelectedRows[0].Cells[0].Value;
            if (obj != null && obj != DBNull.Value)
            {
                if (userbll.UpdateEnabled(Convert.ToInt32(obj), "是")) { App_Code.Message.InfoMsg("操作成功"); }
                this.Binds();
            }

        }
        //删除
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            object obj = dgvUserList.SelectedRows[0].Cells[1].Value;
            if (obj != null && obj != DBNull.Value)
            {
                string str = obj.ToString();
                if (str.Equals("admin"))
                {
                    App_Code.Message.InfoMsg("不能删除管理员账户");
                    return;
                }
                else
                {
                    object obj2 = dgvUserList.SelectedRows[0].Cells[0].Value;
                    if (obj2 != null && obj2 != DBNull.Value)
                    {
                        if (userbll.DelUser(Convert.ToInt32(obj2))) App_Code.Message.InfoMsg("操作成功");
                        this.Binds();
                    }
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
