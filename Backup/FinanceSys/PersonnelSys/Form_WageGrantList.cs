using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PublicLibrary;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_WageGrantList : Form
    {
        public string times = string.Empty;
        private FinanceManagerSys.BLL.Wage_BLL wagebll = new FinanceSys.FinanceManagerSys.BLL.Wage_BLL();
        public Form_WageGrantList()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(times)) dtptime.Text = times;
        }



        private void Form_WageGrantList_Load(object sender, EventArgs e)
        {
            this.ShowDialogShuJu(times);
        }
        void ShowDialogShuJu(string timee)
        {
            try
            {
                string time2 = Convert.ToDateTime(timee).ToString("yyyy-MM", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                IList<FinanceManagerSys.Model.Wage_Model> ilist = wagebll.GetListWage(time2);
                if (ilist.Count > 0 && ilist != null)
                {
                    this.btnExcel.Enabled = true;
                    decimal cou = 0;
                    int xh = 0;
                    decimal madewage = 0;
                    decimal deduction = 0;
                    decimal actualwage = 0;
                    decimal basicwagecount = 0;
                    decimal yfhj = 0;
                    decimal kchj = 0;
                    decimal zhj = 0;

                    #region 循环加载数据
                    for (int i = 0; i < ilist.Count; i++)
                    {
                        int t = dgvWageCount.Rows.Add();
                        DateTime time = ilist[i].Month;
                        if (xh == 0)
                        {
                            xh = xh + 1;
                            dgvWageCount.Rows[t].Cells["xuhao"].Value = xh.ToString();
                        }
                        else
                        {
                            xh = xh + 1;
                            dgvWageCount.Rows[t].Cells["xuhao"].Value = xh.ToString();
                        }
                        string month = time.ToString();
                        string[] arrAy = month.Split('-');
                        dgvWageCount.Rows[t].Cells["month"].Value = arrAy[0].ToString() + "-" +arrAy[1].ToString();
                        dgvWageCount.Rows[t].Cells["empname"].Value = ilist[i].EmpName;
                        dgvWageCount.Rows[t].Cells["basicwage"].Value = ilist[i].BasicWage;//基本工资
                        basicwagecount += ilist[i].BasicWage;
                        dgvWageCount.Rows[t].Cells["tic"].Value = ilist[i].Businesscommission;//销售提成
                        dgvWageCount.Rows[t].Cells["award"].Value = ilist[i].Bonus;//奖金
                        dgvWageCount.Rows[t].Cells["lv"].Value = ilist[i].PersonalIncomeTax;//个人所得税
                        dgvWageCount.Rows[t].Cells["jintie"].Value = ilist[i].Allowance;//津贴
                        dgvWageCount.Rows[t].Cells["jiaban"].Value = ilist[i].Overtimepay;//加班工资
                        dgvWageCount.Rows[t].Cells["traffic"].Value = ilist[i].Jobsubsidies;//岗位补贴
                        dgvWageCount.Rows[t].Cells["shebao"].Value = ilist[i].SocialSecurity;//社保
                        dgvWageCount.Rows[t].Cells["other"].Value = ilist[i].Other;//其它

                        //总合计
                        madewage = ilist[i].BasicWage + ilist[i].Businesscommission + ilist[i].Bonus + ilist[i].Overtimepay + ilist[i].Allowance + ilist[i].Jobsubsidies;
                        //扣除合计
                        deduction = ilist[i].PersonalIncomeTax + ilist[i].Other + ilist[i].SocialSecurity;

                        //应发合计
                        dgvWageCount.Rows[t].Cells["madewage"].Value = madewage;
                        yfhj += madewage;
                        //扣款合计
                        dgvWageCount.Rows[t].Cells["deduction"].Value = deduction;
                        kchj += deduction;
                        actualwage = madewage - deduction;
                        //实发合计
                        dgvWageCount.Rows[t].Cells["actualwage"].Value = actualwage;
                        zhj += actualwage;
                        cou = cou + actualwage;
                    }
                    #endregion


                    lblCountFooting.Text = ilist.Count.ToString();
                    lblCountFooting.Text = cou.ToString() + "元";
                    lblCount.Text = dgvWageCount.Rows.Count.ToString();
                    #region 添加最后一行
                    int rows = dgvWageCount.Rows.Add();
                    dgvWageCount.Rows[rows].Cells["xuhao"].Value = "合计";
                    dgvWageCount.Rows[rows].Cells["month"].Value = "--";
                    dgvWageCount.Rows[rows].Cells["empname"].Value = "--";
                    dgvWageCount.Rows[rows].Cells["basicwage"].Value = basicwagecount;//基本工资
                    dgvWageCount.Rows[rows].Cells["tic"].Value = "--";//销售提成
                    dgvWageCount.Rows[rows].Cells["award"].Value = "--";//奖金
                    dgvWageCount.Rows[rows].Cells["lv"].Value = "--";//个人所得税
                    dgvWageCount.Rows[rows].Cells["jintie"].Value = "--";//津贴
                    dgvWageCount.Rows[rows].Cells["jiaban"].Value = "--";//加班工资
                    dgvWageCount.Rows[rows].Cells["traffic"].Value = "--";//岗位补贴
                    dgvWageCount.Rows[rows].Cells["shebao"].Value = "--";//社保
                    dgvWageCount.Rows[rows].Cells["other"].Value = "--";//其它
                    dgvWageCount.Rows[rows].Cells["madewage"].Value = yfhj;
                    dgvWageCount.Rows[rows].Cells["deduction"].Value = kchj;
                    dgvWageCount.Rows[rows].Cells["actualwage"].Value = zhj;
                    #endregion
                }
                else
                {
                    lblCountFooting.Text = "0";
                    lblCount.Text = "0";
                    btnExcel.Enabled = false;
                }
            }
            catch
            {
                App_Code.Message.InfoMsg("数据读取失败");
                return;
            }
        }

        
        private void dtptime_ValueChanged(object sender, EventArgs e)
        {
            dgvWageCount.Rows.Clear();
            ShowDialogShuJu(dtptime.Text);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        { 
            //Excels.Input_Excel(dgvWageCount);
            Excels.Input_Excel(dgvWageCount);
        } 
    }
}
