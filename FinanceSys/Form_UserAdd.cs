using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys
{
    public partial class Form_UserAdd : Form
    {
        public Form_UserAdd()
        {
            InitializeComponent();
            this.txtLoginname.Focus();
        }

        private PersonnelSys.BLL.Users_BLL bll = new FinanceSys.PersonnelSys.BLL.Users_BLL();

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (InputCheck())
            {
                if (!CheckUserName())
                {
                    if (AddUser())
                    {
                        this.DialogResult = DialogResult.OK;
                        App_Code.Message.InfoMsg("用户添加成功。");
                        this.Close();
                    }
                }
                else {
                    App_Code.Message.InfoMsg("用户名已存在。");
                    return;
                }
            }
        }

        private bool InputCheck()
        {
            if (string.IsNullOrEmpty(this.txtLoginname.Text))
            {
                App_Code.Message.InfoMsg("输入用户登录名");
                this.txtLoginname.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtNewPass.Text))
            {
                App_Code.Message.InfoMsg("输入用户登录密码");
                this.txtNewPass.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtPassAgain.Text))
            {
                App_Code.Message.InfoMsg("输入用户登录密码");
                this.txtPassAgain.Focus();
                return false;
            }
            else if (this.txtNewPass.Text != this.txtPassAgain.Text)
            {
                App_Code.Message.InfoMsg("确认密码输入错误");
                this.txtPassAgain.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool AddUser()
        {           
            return bll.AddUser(this.txtLoginname.Text.ToLower(), App_Code.Text.MD532(this.txtNewPass.Text.ToLower()), this.txtName.Text);
        }

        private bool CheckUserName()
        {
            return bll.Exists(this.txtLoginname.Text.Trim().ToLower());  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

