using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FinanceSys.PublicLibrary;

namespace FinanceSys
{
    public partial class Form_Main : Form
    {
        Aptech.UI.SbGroup SbGroup = new Aptech.UI.SbGroup();
        public Form_Main()
        {
            InitializeComponent();
        }
        private string _user;
        private string _loginname;
        public string LoginName
        {
            set
            {
                this._loginname = value;
            }

        }

        public string User
        {
            set
            {
                this._user = value;

            }


        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

            IniBar();
          
        }

        private void IniBar()
        {
            #region
            this.sideBar1.AllowDrop = true;


            SbGroup.Text = "人事管理";

            this.sideBar1.AddGroup(SbGroup);
            this.sideBar1.AddGroup("工资管理");
            this.sideBar1.AddGroup("财务管理");
            this.sideBar1.AddGroup("系统设置");


            //添加系统管理
            this.sideBar1.Groups[0].Items.Add("员工管理", 0);
            this.sideBar1.Groups[0].Items.Add("员工添加", 1);
            this.sideBar1.Groups[0].Items.Add("部门管理", 2);
            this.sideBar1.Groups[0].Items.Add("离职管理", 3);


            //基本资料 
            this.sideBar1.Groups[1].Items.Add("工资管理", 4);
            this.sideBar1.Groups[1].Items.Add("工资发放", 5);
            this.sideBar1.Groups[1].Items.Add("调薪设置", 6);


            this.sideBar1.Groups[2].Items.Add("支出管理", 7);
            this.sideBar1.Groups[2].Items.Add("收入管理", 8);
            this.sideBar1.Groups[2].Items.Add("收入合同管理", 9);
            this.sideBar1.Groups[2].Items.Add("发票列表", 10);
            this.sideBar1.Groups[2].Items.Add("账户查询", 11);
            this.sideBar1.Groups[2].Items.Add("收入明细", 2);
            this.sideBar1.Groups[2].Items.Add("支出明细", 2);


            if (App_Code.Canshu.LoginName.Equals("admin") || App_Code.Canshu.LoginName.Equals("administrator"))
            {
                this.sideBar1.Groups[3].Items.Add("用户管理", 12);
                this.sideBar1.Groups[3].Items.Add("新增用户", 13);
            }
            if (App_Code.Canshu.LoginName.Equals("admin"))
            {
                this.sideBar1.Groups[3].Items.Add("系统初始化", 14);
            }
            this.sideBar1.Groups[3].Items.Add("密码修改", 15);

            this.RightToLeftLayout = true;
            #endregion
            this.InitStatusInfo();//加载状态栏
        
        }


        private void InitStatusInfo()
        {
            statusInfo.Items[0].Text = "当前系统操作员：" + this._loginname;
            statusInfo.Items[2].Text += "：江苏某某有限公司";
            statusInfo.Items[3].Text += "：";
            timer.Start();
        }
         
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdatePwd pwd = new Form_UpdatePwd();
           
            pwd.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.statusInfo.Items[1].Text = DateTime.Now.ToString();
        }  
          
        private void menu_Emp_depart_Click(object sender, EventArgs e)
        {
            PersonnelSys.Form_DepartmentList depart = new FinanceSys.PersonnelSys.Form_DepartmentList();
           
            depart.ShowDialog();
        }

        private void meun_emp_emp_Click(object sender, EventArgs e)
        {
            FinanceSys.PersonnelSys.Form_EmployeeList emp = new FinanceSys.PersonnelSys.Form_EmployeeList();
           
            emp.ShowDialog();
        }

        private void Menu_Sys_AppRestart_Click(object sender, EventArgs e)
        {
            if (App_Code.Message.QuestionMsg("您确定要注销系统？"))
                Application.Restart();
        }

        private void Menu_Exit_Exit_Click(object sender, EventArgs e)
        {
            if (App_Code.Message.QuestionMsg("您确定要退出系统？"))
            {
                Process pro = Process.GetCurrentProcess();
                if (pro != null)
                    pro.Kill();
            }
        }

        private void Menu_Tool_Notepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void Menu_Tool_Calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void Menu_Eq_Add_Click(object sender, EventArgs e)
        {
            FinanceManagerSys.Form_IncomeType type = new FinanceSys.FinanceManagerSys.Form_IncomeType();
           
            type.ShowDialog();
        }

        private void Menu_Eq_Boroow_Click(object sender, EventArgs e)
        {
            FinanceManagerSys.Form_OutlayList outlay = new FinanceSys.FinanceManagerSys.Form_OutlayList();
            
            outlay.ShowDialog();
        }

        private void Menu_Eq_Return_Click(object sender, EventArgs e)
        {
            PersonnelSys.Form_EmpWageList wagelist = new FinanceSys.PersonnelSys.Form_EmpWageList();
             
            wagelist.ShowDialog();
        }

        private void Menu_Eq_ReturnLook_Click(object sender, EventArgs e)
        {
            FinanceSys.PersonnelSys.Form_Syslog log = new FinanceSys.PersonnelSys.Form_Syslog();
             
            log.ShowDialog();
        }
         
        private void lbl_Account_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.BackColor = Color.LimeGreen;
        }

        private void sideBar1_ItemClick(Aptech.UI.SbItemEventArgs e)
        {
            switch (sideBar1.SeletedItem.Text)
            {
                case "员工管理":
                    PersonnelSys.Form_EmployeeList emplist = new FinanceSys.PersonnelSys.Form_EmployeeList();

                    emplist.ShowDialog();
                    break;
                case "员工添加":
                    PersonnelSys.Form_EmployeeAdd empadd = new FinanceSys.PersonnelSys.Form_EmployeeAdd();
                    empadd.canshu = "add";
                    empadd.ShowDialog();
                    break;
                case "部门管理":
                    PersonnelSys.Form_DepartmentList depart = new FinanceSys.PersonnelSys.Form_DepartmentList();

                    depart.ShowDialog();
                    break;
                case "离职管理":
                    PersonnelSys.Form_LeaveList leave = new FinanceSys.PersonnelSys.Form_LeaveList();

                    leave.ShowDialog();
                    break;
                case "工资管理":
                    PersonnelSys.Form_EmpWageList wage = new FinanceSys.PersonnelSys.Form_EmpWageList();

                    wage.ShowDialog();
                    break;
                case "工资发放":
                    PersonnelSys.Form_PayMonth pay = new FinanceSys.PersonnelSys.Form_PayMonth();

                    pay.ShowDialog();
                    break;
                case "调薪设置":
                    PersonnelSys.Form_WageChangeList salary = new FinanceSys.PersonnelSys.Form_WageChangeList();

                    salary.ShowDialog();
                    break;
                case "支出管理":
                    FinanceManagerSys.Form_OutlayList outlay = new FinanceSys.FinanceManagerSys.Form_OutlayList();

                    outlay.ShowDialog();
                    break;
                case "收入管理":
                    FinanceManagerSys.Form_IncomeList type = new FinanceSys.FinanceManagerSys.Form_IncomeList();

                    type.ShowDialog();
                    break;
                case "发票列表":
                    FinanceManagerSys.Form_OpenInvoice openinvoice = new FinanceSys.FinanceManagerSys.Form_OpenInvoice();

                    openinvoice.canshu = "main";
                    openinvoice.Show();
                    break;
                case "收入合同管理":
                    FinanceManagerSys.Form_ContractList contract = new FinanceSys.FinanceManagerSys.Form_ContractList();

                    contract.ShowDialog();
                    break;
                case "账户查询":
                    FinanceManagerSys.Form_Money money = new FinanceSys.FinanceManagerSys.Form_Money();

                    money.ShowDialog();
                    break;
                case "收入明细":
                    FinanceManagerSys.Form_IncomeList incomelist = new FinanceSys.FinanceManagerSys.Form_IncomeList();

                    incomelist.ShowDialog();
                    break;
                case "支出明细":
                    FinanceManagerSys.Form_OutlayList outlaylist = new FinanceSys.FinanceManagerSys.Form_OutlayList();

                    outlaylist.ShowDialog();
                    break;
                case "密码修改":
                    Form_UpdatePwd pwd = new Form_UpdatePwd();

                    pwd.ShowDialog();
                    break;
                case "系统初始化":
                    if (MessageBox.Show("警告：数据初始化会造成数据丢失，您确定要初始化吗？？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (Systems.SysInit())
                        {
                            App_Code.Message.InfoMsg("系统初始化成功。");
                        }
                        else
                        {

                            App_Code.Message.InfoMsg("系统初始化失败。");
                        }
                    }
                    break;
                case "用户管理":
                    Form_UserList userlist = new Form_UserList();
                    userlist.ShowDialog();
                    break;
                case "新增用户":
                    Form_UserAdd useradd = new Form_UserAdd();

                    useradd.Show();
                    break;
                default:
                    return;
                    break;
            }
        }

        private void tsbtnForegrounding_Click(object sender, EventArgs e)
        {
            PersonnelSys.Form_EmployeeList emplist = new FinanceSys.PersonnelSys.Form_EmployeeList();

            emplist.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiBookManage_Click(object sender, EventArgs e)
        {
            PersonnelSys.Form_EmpWageList wage = new FinanceSys.PersonnelSys.Form_EmpWageList();

            wage.ShowDialog();
        }

        private void tsmiCashierManage_Click(object sender, EventArgs e)
        {
            FinanceManagerSys.Form_IncomeList type = new FinanceSys.FinanceManagerSys.Form_IncomeList();

            type.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FinanceManagerSys.Form_OutlayList outlay = new FinanceSys.FinanceManagerSys.Form_OutlayList();

            outlay.ShowDialog();
        }

        private void tsbtnSoftSet_Click(object sender, EventArgs e)
        {
            Form_UserList userlist = new Form_UserList();
            userlist.ShowDialog();
        }
    }
}
