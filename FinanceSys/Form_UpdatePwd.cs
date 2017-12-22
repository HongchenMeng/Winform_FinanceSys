using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PersonnelSys.BLL;
using System.Web.Security;

namespace FinanceSys
{
    public partial class Form_UpdatePwd : Form
    {
        public Form_UpdatePwd()
        {
            InitializeComponent();
        }
        
        private FinanceSys.PersonnelSys.BLL.Users_BLL userbll = new Users_BLL();
        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            Eneble();
            Cleartxt();
        }
        /// <summary>
        /// 设置修改密码相关控件的启用状态
        /// </summary>
        private void Eneble()
        {
            this.lblOldPass.Enabled = !this.lblOldPass.Enabled;
            this.lblNewPass.Enabled = !this.lblNewPass.Enabled;
            this.lblNewPassAgain.Enabled = !this.lblNewPassAgain.Enabled;
            this.txtOldPass.Enabled = !this.txtOldPass.Enabled;
            this.txtNewPass.Enabled = !this.txtNewPass.Enabled;
            this.txtPassAgain.Enabled = !this.txtPassAgain.Enabled;

        }
        /// <summary>
        /// 清理个密码框内的字符
        /// </summary>
        private void Cleartxt()
        {
            this.txtOldPass.Clear();
            this.txtNewPass.Clear();
            this.txtPassAgain.Clear();
        }

        private void Form_UpdatePwd_Load(object sender, EventArgs e)
        {
            this.txtLoginname.Text = App_Code.Canshu.LoginName;
            this.txtName.Text = App_Code.Canshu.Name;
        }

        /// <summary>
        /// 检查输入是否合法
        /// </summary>
        /// <returns></returns>
        private bool checkInput()
        {
            if (this.txtName.Text.Trim() == "")
            {
                App_Code.Message.InfoMsg("请输入真实姓名。");
                return false;
            }
            if (this.txtOldPass.Text.Trim() == "")
            {
                App_Code.Message.InfoMsg("请输入原密码。");
                return false;
            }
            if (this.txtNewPass.Text.Trim() == "")
            {
                App_Code.Message.InfoMsg("请输入新密码。");
                return false;
            }
            if (this.txtPassAgain.Text.Trim() == "")
            {
                App_Code.Message.InfoMsg("请输入确认密码。");
                return false;
            }
            if (this.txtNewPass.Text != this.txtPassAgain.Text)
            {
                App_Code.Message.InfoMsg("两次输入的密码不一致");
                this.txtNewPass.Text = "";
                this.txtPassAgain.Text = "";//5|1|a|s|p|x
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //修改资料（不修改密码）
            if (this.chkPass.Checked == false)
            {
                if (this.txtName.Text.Trim() == "")
                {
                    App_Code.Message.InfoMsg("请输入真实姓名。");
                    return;
                }
                if (userbll.UpdateUname(this.txtLoginname.Text, this.txtName.Text))
                {
                    App_Code.Message.InfoMsg("修改成功。");
                    this.Close();
                }
                else
                {
                    App_Code.Message.InfoMsg("修改失败");
                }

            }
            else
            {
                if (this.checkInput())//修改密码
                {
                    if (userbll.CheckPwd(MD532(this.txtOldPass.Text.Trim())))
                    {
                        bool result = userbll.UpdatePwd(this.txtLoginname.Text.Trim(), MD532(this.txtPassAgain.Text.Trim()));
                        if (result)
                        {
                            App_Code.Message.InfoMsg("修改成功。");
                            this.Cleartxt(); this.Close();
                            this.chkPass.Checked = false;
                        }
                    }
                    else
                    {

                        App_Code.Message.InfoMsg("原密码错误，请确认后在输入。修改失败。");
                        this.Cleartxt();
                        return;
                    }
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //加密方法16位
        public static string MD516(string str)
        {
            return MD5(str, 16);
        }
        //加密方法32位
        public static string MD532(string str)
        {
            return MD5(str, 32);
        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密的字符</param>
        /// <param name="dig">位数,16、32可选</param>
        /// <returns></returns>
        private static string MD5(string str, int dig)
        {
            if (dig == 32)
            {

                return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower();
            }
            else
            {
                return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower().Substring(8, 16);
            }
        }
    }
}
