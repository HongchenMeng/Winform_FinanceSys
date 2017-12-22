using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model = FinanceSys.PersonnelSys.Model;
using FinanceSys.PublicLibrary.BLL;
using System.Net;
using FinanceSys.PublicLibrary;

namespace FinanceSys
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            //this.skinEngine2.SkinFile = @"Vista2_color2.ssk";
            this.skinEngine2.SkinDialogs = false;
            this.txtusername.Focus();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = this.txtusername.Text.Trim().ToLower();
            string userpass = App_Code.Text.MD532(this.txtuserpwd.Text.Trim().ToLower());

            Model.Users_Model usersmodel;
            
            if (this.Check(username, userpass) == true)
            {
                FinanceSys.PersonnelSys.BLL.Users_BLL Manager = new FinanceSys.PersonnelSys.BLL.Users_BLL();
                if (Manager.Exists(username) == true)
                {
                    if (!Manager.GetUserState(username)) { App_Code.Message.InfoMsg("此用户不存在"); }
                    else
                    {
                        if (Manager.ValiedUser(username, userpass, out usersmodel) == true)
                        {
                            Form_Main main = new Form_Main();
                            main.LoginName = username;
                            App_Code.Canshu.LoginName = username;
                            App_Code.Canshu.Name = usersmodel.Name;
                            main.Show();
                            Log_BLL.Add(DateTime.Now, "登录系统", username, "登录成功", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 1);
                            this.Hide();
                        }
                        else
                        {
                            App_Code.Message.InfoMsg("用户名或密码错误!");
                            this.txtuserpwd.Focus();
                        }
                    }
                }
                else
                {
                    App_Code.Message.InfoMsg("用户名或密码错误");
                    this.txtusername.Clear();
                    this.txtusername.Focus();
                }
            }
        }

        private bool Check(string username, string userpass)
        {
            bool result = false;
            if (string.IsNullOrEmpty(username))
            {
                App_Code.Message.InfoMsg("输入账号!");
                this.txtusername.Focus();
                
                return result;
            }
            else if (string.IsNullOrEmpty(userpass))
            {
                App_Code.Message.InfoMsg("输入密码!");
                this.txtuserpwd.Focus();
                return result;
            }
            else
            {
                return result = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
