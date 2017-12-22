using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PublicLibrary;
using System.Net;
using FinanceSys.PublicLibrary.BLL;
using FinanceSys.FinanceManagerSys.Model;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_OpenInvoice : Form
    {
        public Form_OpenInvoice()
        {
            InitializeComponent();
            cbxPayment.Text = cbxPayment.Items[0].ToString();
            cbxStatus.Text = cbxStatus.Items[0].ToString();
        }
        
        #region
        public string canshu = string.Empty;
        private FinanceManagerSys.BLL.Income_BLL bll = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();
        private FinanceManagerSys.Model.Income_Model model = new FinanceSys.FinanceManagerSys.Model.Income_Model();
        private FinanceManagerSys.BLL.Invoice_BLL invoicebll = new FinanceSys.FinanceManagerSys.BLL.Invoice_BLL();
        private FinanceManagerSys.BLL.Contract_BLL contractbll = new FinanceSys.FinanceManagerSys.BLL.Contract_BLL();
        #endregion

        #region 分页的公有变量
        int pageSize = 15;     //每页显示行数 
        int nMax = 0;         //总记录数 
        int pageCount = 0;    //页数＝总记录数/每页显示行数 
        int pageCurrent = 1;   //当前页号 
        DataSet ds = new DataSet();
        DataTable dtInfo = new DataTable();
        #endregion       

        #region
        int wi = 5;
        int hei = 15;
        //传值参数
        public string pivalue = string.Empty;
        public string pi2value = string.Empty;
        public string pi3value = string.Empty;
        public static string strvalue = string.Empty;
        #endregion

        private void Form_OpenInvoice_Load(object sender, EventArgs e)
        {
            if (canshu.Equals("main"))
            {
                this.Size = new Size(this.Width, this.Height - 250);
                this.btnSave.Enabled = false;
            }
            else
            {
                if (App_Code.Canshu.Id != 0 && App_Code.Canshu.Id != -1)
                {
                    this.btnSave.Enabled = true;
                    this.ShowInvoice(App_Code.Canshu.Id);
                }
                if (!string.IsNullOrEmpty(canshu))
                {
                    this.gbmsg.Visible = false;
                    this.btnSave.Enabled = false;
                }
                
                IsBtnSave();
            }
            Load_PicLict();
        }
        /// <summary>
        /// 文本框验证
        /// </summary>
        /// <returns></returns>
        private bool InputCheck()
        {
            #region 文本框验证            
            if (this.txtInvoiceno.Text == "")
            {
                App_Code.Message.InfoMsg("发票编号不能为空！");
                return false;
            }
            else if (this.txtB.Text == "")
            {
                App_Code.Message.InfoMsg("公司名称不能为空！");
                return false;
            }
            else if (this.txtDemoname.Text == "")
            {
                App_Code.Message.InfoMsg("项目名称不能为空！");
                return false;
            }
            else if (this.txtInvoiceMoney.Text == "0.00")
            {
                App_Code.Message.InfoMsg("发票金额不能为空！");
                return false;
            }
            else if (this.txtHandling.Text == "")
            {
                App_Code.Message.InfoMsg("经办人不能为空！");
                return false;
            }
            else if (this.txtContractno.Text == "")
            {
                App_Code.Message.InfoMsg("合同编号不能为空！");
                return false;
            }
            else if (this.cbxPayment.Text == "")
            {
                App_Code.Message.InfoMsg("请选择付款方式！");
                return false;
            }
            else
            {
                return true;
            }
            #endregion
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        private bool AddInvoice()
        {
            FinanceManagerSys.Model.Invoice_Model model = new FinanceSys.FinanceManagerSys.Model.Invoice_Model();
            FinanceManagerSys.BLL.InvoiceMX_BLL mx = new FinanceSys.FinanceManagerSys.BLL.InvoiceMX_BLL();
            model.DemoName = this.txtDemoname.Text.Trim();
            model.EmpName = this.cbxEmp.Text;
            model.Handling = this.txtHandling.Text.Trim();
            model.InvoiceNo = this.txtInvoiceno.Text.Trim();
            model.ContractNo = this.txtContractno.Text.Trim();
            model.Invoicetime = DateTime.Now;
            model.LTDName = this.txtB.Text.Trim();
            model.Money = decimal.Parse(this.txtInvoiceMoney.Text.Trim());
            model.Payment = cbxPayment.Text;
            model.Remark = this.txtRemark.Text.Trim();
            model.Status = this.cbxStatus.Text;
            model.IsBank = "";
            int item = App_Code.Canshu.Id;
            if (invoicebll.GetIsCount(item))
            {   
                if (mx.Add(this.InvoiceMX()) > 0)
                {
                    UpdateInvoice();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                //根据状态画图标开始
                switch (cbxStatus.Text)
                {
                    #region 未付
                    case "未付":
                        PictureBox pi = new PictureBox();
                        pi.Image = global::FinanceSys.Properties.Resources.orange;
                        pi.Location = new System.Drawing.Point(wi, hei);

                        pi.Name = "pic1";
                        pi.Size = new System.Drawing.Size(35, 35);
                        pi.TabIndex = 11;
                        pi.TabStop = false;

                        Label lb1 = new Label();
                        lb1.Text = "名称：" + this.txtB.Text.Trim();
                        lb1.Size = new System.Drawing.Size(35, 15);
                        lb1.Location = new System.Drawing.Point(wi, hei + pi.Height + 3);


                        Label lbl1 = new Label();
                        lbl1.Text = "金额:";
                        lbl1.Text += this.txtInvoiceMoney.Text.Trim();
                        lbl1.Size = new System.Drawing.Size(115, 15);
                        lbl1.Location = new System.Drawing.Point(pi.Location.X, hei + pi.Height + 15 + lbl1.Height);

                        this.dgvInfo.Controls.Add(lb1);
                        this.dgvInfo.Controls.Add(lbl1);
                        this.dgvInfo.Controls.Add(pi);

                        if (wi + pi.Width >= this.groupBox2.Width - 100)
                        {
                            hei += 83;
                            wi = 5;
                        }
                        else
                        {
                            wi += 50;
                        }
                        break;
                    #endregion
                    #region 未付完
                    case "未付完":
                        PictureBox pi2 = new PictureBox();
                        pi2.Image = global::FinanceSys.Properties.Resources.yellow;
                        pi2.Location = new System.Drawing.Point(wi, hei);

                        pi2.Name = "pic2";
                        pi2.Size = new System.Drawing.Size(35, 35);
                        pi2.TabIndex = 11;
                        pi2.TabStop = false;


                        Label lb12 = new Label();
                        lb12.Text = "名称：" + this.txtB.Text.Trim();
                        lb12.Size = new System.Drawing.Size(35, 15);
                        lb12.Location = new System.Drawing.Point(wi, hei + pi2.Height + 3);


                        Label lb2 = new Label();
                        lb2.Text = "金额:";
                        lb2.Text += this.txtInvoiceMoney.Text.Trim();
                        lb2.Size = new System.Drawing.Size(115, 15);
                        lb2.Location = new System.Drawing.Point(pi2.Location.X, hei + pi2.Height + 15 + lb2.Height);

                        this.dgvInfo.Controls.Add(lb12);
                        this.dgvInfo.Controls.Add(lb2);
                        this.dgvInfo.Controls.Add(pi2);

                        if (wi + pi2.Width >= this.groupBox2.Width - 100)
                        {
                            hei += 83;
                            wi = 5;
                        }
                        else
                        {
                            wi += 50;
                        }
                        break;
                    #endregion
                    #region 已付完
                    case "已付完":
                        PictureBox pi3 = new PictureBox();
                        pi3.Image = (Image)global::FinanceSys.Properties.Resources.red;
                        pi3.Location = new System.Drawing.Point(wi, hei);

                        pi3.Name = "pic3";
                        pi3.Size = new System.Drawing.Size(35, 35);
                        pi3.TabIndex = 11;
                        pi3.TabStop = false;

                        Label lb13 = new Label();
                        lb13.Text = "名称：" + this.txtB.Text.Trim();
                        lb13.Size = new System.Drawing.Size(35, 15);
                        lb13.Location = new System.Drawing.Point(wi, hei + pi3.Height + 3);

                        Label lb4 = new Label();
                        lb4.Text = "金额:";
                        lb4.Text += this.txtInvoiceMoney.Text.Trim();
                        lb4.Size = new System.Drawing.Size(115, 15);
                        lb4.Location = new System.Drawing.Point(pi3.Location.X, hei + pi3.Height + 15 + lb4.Height);

                        this.dgvInfo.Controls.Add(lb13);
                        this.dgvInfo.Controls.Add(lb4);
                        this.dgvInfo.Controls.Add(pi3);

                        if (wi + pi3.Width >= this.groupBox2.Width - 100)
                        {
                            hei += 83;
                            wi = 5;
                        }
                        else
                        {
                            wi += 50;
                        }
                        break;
                    default:
                        break;
                    #endregion
                }
                if (invoicebll.Add(model) > 0)
                {
                    mx.Add(this.InvoiceMX());
                    return true; 
                }
                else 
                { 
                    return false; 
                }
            }
        }
        InvoiceMX_Model InvoiceMX()
        {
            FinanceManagerSys.BLL.InvoiceMX_BLL mx = new FinanceSys.FinanceManagerSys.BLL.InvoiceMX_BLL();
            FinanceManagerSys.Model.InvoiceMX_Model mxmodel = new FinanceSys.FinanceManagerSys.Model.InvoiceMX_Model();
            mxmodel.DemoName = this.txtDemoname.Text.Trim();
            mxmodel.EmpName = this.cbxEmp.Text;
            mxmodel.Handling = this.txtHandling.Text.Trim();
            mxmodel.InvoiceNo = this.txtInvoiceno.Text.Trim();
            mxmodel.ContractNo = this.txtContractno.Text.Trim();
            mxmodel.Invoicetime = DateTime.Now;
            mxmodel.LTDName = this.txtB.Text.Trim();
            mxmodel.Money = decimal.Parse(this.txtInvoiceMoney.Text.Trim());
            mxmodel.Payment = cbxPayment.Text;
            mxmodel.Remark = this.txtRemark.Text.Trim();
            mxmodel.Status = this.cbxStatus.Text;
            mxmodel.IsBank = "";
            return mxmodel;
        }
        /// <summary>
        /// 如果已开发票、再次开发票时将
        /// 信息插入发票明细表、并修改发票的
        /// 状态和发票金额
        /// </summary>
        public void UpdateInvoice()
        {
            decimal invoicemoney = decimal.Parse(this.txtInvoiceMoney.Text.Trim());//发票金额
            decimal openmoney = decimal.Parse(this.txtOpenMoney.Text.Trim());//已开发票金额
            decimal coutmoney = decimal.Parse(this.txtMoney.Text.Trim());//项目金额
            if (coutmoney > openmoney + invoicemoney)
            {
                invoicebll.UpdateInvoice(invoicemoney, "未付完", App_Code.Canshu.Id);
            }
            else if (coutmoney == openmoney + invoicemoney)
            {
                invoicebll.UpdateInvoice(invoicemoney, "已付完", App_Code.Canshu.Id);
            }
            else { }
        }
        /// <summary>
        /// 修改收入发表金额
        /// </summary>
        /// <returns></returns>
        private int UpIncomeMon(string contract,decimal money,string isbreak)
        {
            return bll.UpIncomeMon(contract, money, isbreak);
        }
        private bool AddInvoiceMx()
        {
            FinanceManagerSys.Model.InvoiceMX_Model model = new FinanceSys.FinanceManagerSys.Model.InvoiceMX_Model();
            FinanceManagerSys.BLL.InvoiceMX_BLL mxbll = new FinanceSys.FinanceManagerSys.BLL.InvoiceMX_BLL();
            model.DemoName = this.txtDemoname.Text.Trim();
            model.EmpName = this.cbxEmp.Text;
            model.Handling = this.txtHandling.Text.Trim();
            model.InvoiceNo = this.txtInvoiceno.Text.Trim();            
            model.Invoicetime = DateTime.Now;
            model.LTDName = this.txtB.Text.Trim();
            model.Money = decimal.Parse(this.txtMoney.Text.Trim());
            model.Payment = cbxPayment.Text;
            model.Remark = this.txtRemark.Text.Trim();
            model.Status = this.cbxStatus.Text;
            model.IsBank = "";

            if (mxbll.Add(model) > 0) return true; else return false;
        }
        /// <summary>
        /// 查询合同编号是否存在
        /// </summary>
        /// <returns></returns>
        private bool IsContract()
        {
            if (invoicebll.ExistsContract(this.txtContractno.Text.Trim())>0) return true; else return false;
        }

        /// <summary>
        /// 查询发票编号是否存在
        /// </summary>
        /// <param name="invoiceno"></param>
        /// <returns></returns>
        private bool SerachInvoiceNo(string invoiceno)
        {
            if (invoicebll.Exists(this.txtInvoiceno.Text.Trim()))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 查询信息
        /// </summary>
        /// <param name="id"></param>
        private void ShowInvoice(int id)
        {
           model = bll.GetModel(id);
           this.txtB.Text = model.B;
           this.txtContractno.Text = model.ContractNo;
           this.txtDemoname.Text = model.DemoName;
           if (!string.IsNullOrEmpty(model.EmpName))
               this.cbxEmp.Text = model.EmpName;
           else
               this.txtTic.ReadOnly = true;
           this.txtMoney.Text = model.Money.ToString();
           if (!string.IsNullOrEmpty(model.InvoiceMoney.ToString()) && model.InvoiceMoney > 0)
           {
               this.txtOpenMoney.Text = model.InvoiceMoney.ToString();
           }
        }

        private void IsBtnSave()
        {
            model = bll.GetModel(App_Code.Canshu.Id);
            if (model != null)
            {
               decimal money= model.Money;
               decimal invoicem = model.InvoiceMoney;
               if (money==invoicem)
               {
                   this.btnSave.Enabled = false;
                   this.txtInvoiceno.ReadOnly = true;
                   this.txtTic.ReadOnly = true;
                   this.cbxPayment.Enabled = false;
                   this.txtHandling.ReadOnly = true;
                   this.cbxStatus.Enabled = false;
                   this.txtRemark.ReadOnly = true;
                   this.txtInvoiceMoney.ReadOnly = true;
               }
            }
        }
        /// <summary>
        /// 员工业务提成
        /// </summary>
        /// <param name="name"></param>
        /// <param name="money"></param>
        private bool UpdateEmp(string name, decimal money)
        {
            FinanceManagerSys.BLL.Wage_BLL wagebll = new FinanceSys.FinanceManagerSys.BLL.Wage_BLL();
            if (wagebll.UpdateTic(name, money) == 1) return true; else return false;
        }
        /// <summary>
        /// 验证种种不同的情况
        /// </summary>
        /// <returns></returns>
        private bool CheckMonth()
        {
            bool bl = false;
            decimal invoiceM = decimal.Parse(this.txtInvoiceMoney.Text.Trim());//发票金额
            decimal demoMoney = decimal.Parse(this.txtMoney.Text.Trim());//项目金额
            decimal opemmoney = 0;
            if (!string.IsNullOrEmpty(this.txtOpenMoney.Text.Trim()))
                opemmoney = decimal.Parse(this.txtOpenMoney.Text.Trim());//已开发票金额

            //第一种 发票金额==项目金额时、所有状态值都必须正确       

            if (invoiceM == demoMoney)
            {
                if (!cbxPayment.Text.Equals("一次性付款") || cbxStatus.Text != "已付完")
                {
                    App_Code.Message.ErrorMsg("付款方式或者状态选择错误");
                    return bl;
                }
                else { bl = true; }
            }

            else if (demoMoney == opemmoney + invoiceM)
            {
                if (!cbxPayment.Text.Equals("分期付款") || !cbxStatus.Text.Equals("已付完"))
                {
                    App_Code.Message.ErrorMsg("付款方式或者状态选择错误");
                    return bl;
                }
                else { bl = true; }
            }
            else if (invoiceM > 0 && invoiceM < demoMoney)
            {
                if (cbxStatus.Text == "未付" || cbxStatus.Text == "已付完" || cbxPayment.Text == "一次性付款")
                {
                    App_Code.Message.ErrorMsg("付款方式或者状态选择错误");
                    return bl;
                }
                else
                {
                    bl = true;
                }
            }

            return bl;
        }
        /// <summary>
        /// 修改收入表中的发票金额
        /// </summary>
        /// <param name="money"></param>
        private void UpdateIncome(string contractno,decimal money)
        {
            FinanceManagerSys.BLL.Income_BLL incomebll = new FinanceSys.FinanceManagerSys.BLL.Income_BLL();
            incomebll.Update(contractno, money);
        }
        int id = 0;
        #region 加载信息
        public void Load_PicLict()
        {
            wi = 5;
            hei = 15;

            this.dgvInfo.Controls.Clear();
            this.dgvInfo.Refresh();
            try
            {
                dtInfo = invoicebll.GetInvoiceIList(pageCurrent);

                if (dtInfo != null && dtInfo.Rows.Count > 0)
                {
                    lblCount.Text = invoicebll.GetCount().ToString() + "张";
                    lblCountM.Text = invoicebll.GetCountM().ToString() + "元";
                    
                    for (int i = 0; i < dtInfo.Rows.Count; i++)
                    {
                        string states = dtInfo.Rows[i][7].ToString();
                        switch (states)
                        {
                            #region 判断状态 未付
                            case "未付":
                                #region PictureBox
                                PictureBox pi = new PictureBox();
                                pi.Image = global::FinanceSys.Properties.Resources.orange;
                                pi.Location = new System.Drawing.Point(wi, hei);

                                pi.Name = "pic1";
                                pi.Size = new System.Drawing.Size(40, 40);
                                pi.TabIndex = 11;
                                pi.TabStop = false;
                                pi.Text = dtInfo.Rows[i][12].ToString();
                                #endregion

                                #region 公司名称
                                LinkLabel lb1 = new LinkLabel();
                                lb1.LinkBehavior = LinkBehavior.AlwaysUnderline;
                                lb1.LinkBehavior = LinkBehavior.SystemDefault;
                                //lb1.Name = "lbl_1_" + i.ToString();
                                lb1.Text = "公司名称:";
                                lb1.Text += SubString(invoicebll.GetInvoiceLtdName(dtInfo.Rows[i][0].ToString()));
                                lb1.Name = dtInfo.Rows[i][0].ToString();
                                //id = Convert.ToInt16(dtInfo.Rows[i][0]);
                                lb1.Size = new System.Drawing.Size(185, 15);
                                lb1.Location = new System.Drawing.Point(wi, hei + pi.Height + 3);
                                lb1.Click += new EventHandler(lb13_Click);
                                #endregion

                                #region 金额
                                Label lbl1 = new Label();
                                lbl1.Name = "lbl_4_" + i.ToString();
                                lbl1.Text = "项目金额:";
                                lbl1.Text += invoicebll.GetInvoiceMoneyByContractNo(dtInfo.Rows[i][12].ToString()).ToString() + "元";
                                lbl1.Size = new System.Drawing.Size(165, 15);
                                lbl1.Location = new System.Drawing.Point(pi.Location.X, hei + pi.Height + 15 + lbl1.Height);

                                this.dgvInfo.Controls.Add(lb1);
                                this.dgvInfo.Controls.Add(lbl1);
                                this.dgvInfo.Controls.Add(pi);

                                if (wi + pi.Width >= this.dgvInfo.Width - 100)
                                {
                                    hei += 83;
                                    wi = 5;
                                }
                                else
                                {
                                    wi += 200;
                                }
                                break;
                                #endregion
                            #endregion
                            #region 判断状态 未付完
                            case "未付完":
                                #region PictureBox
                                PictureBox pi2 = new PictureBox();
                                pi2.Image = global::FinanceSys.Properties.Resources.yellow;
                                pi2.Location = new System.Drawing.Point(wi, hei);

                                pi2.Name = "pic2";
                                pi2.Size = new System.Drawing.Size(40, 40);
                                pi2.TabIndex = 11;
                                pi2.TabStop = false;
                                pi2.Text = dtInfo.Rows[i][12].ToString();
                                #endregion

                                #region 公司名称
                                LinkLabel lb12 = new LinkLabel();
                                lb12.LinkBehavior = LinkBehavior.AlwaysUnderline;
                                lb12.LinkBehavior = LinkBehavior.SystemDefault;
                                //lb12.Name = "lbl_1_" + i.ToString();
                                lb12.Text = "公司名称:";
                                lb12.Text += SubString(invoicebll.GetInvoiceLtdName(dtInfo.Rows[i][0].ToString()));
                                lb12.Name = dtInfo.Rows[i][0].ToString();
                                //id = Convert.ToInt16(dtInfo.Rows[i][0]);
                                lb12.Size = new System.Drawing.Size(185, 15);
                                lb12.Location = new System.Drawing.Point(wi, hei + pi2.Height + 3);
                                lb12.Click += new EventHandler(lb13_Click);
                                #endregion

                                #region 金额
                                Label lb2 = new Label();
                                lb2.Name = "lbl_4_" + i;
                                lb2.Text = "项目金额:";
                                lb2.Text += invoicebll.GetInvoiceMoneyByContractNo(dtInfo.Rows[i][12].ToString()).ToString() + "元";
                                lb2.Size = new System.Drawing.Size(165, 15);
                                lb2.Location = new System.Drawing.Point(pi2.Location.X, hei + pi2.Height + 15 + lb2.Height);

                                this.dgvInfo.Controls.Add(lb12);
                                this.dgvInfo.Controls.Add(lb2);
                                this.dgvInfo.Controls.Add(pi2);

                                if (wi + pi2.Width >= this.dgvInfo.Width - 100)
                                {
                                    hei += 83;
                                    wi = 5;
                                }
                                else
                                {
                                    wi += 200;
                                }
                                break;
                                #endregion
                            #endregion
                            #region 判断状态 已付完
                            case "已付完":
                                #region PictureBox
                                PictureBox pi3 = new PictureBox();
                                pi3.Image = global::FinanceSys.Properties.Resources.red;
                                pi3.Location = new System.Drawing.Point(wi, hei);

                                pi3.Name = "pic3";
                                pi3.Size = new System.Drawing.Size(40, 40);
                                pi3.TabIndex = 11;
                                pi3.TabStop = false;
                                pi3.Text = dtInfo.Rows[i][12].ToString();
                                #endregion

                                #region 公司名称
                                LinkLabel lb13 = new LinkLabel();
                                lb13.LinkBehavior = LinkBehavior.AlwaysUnderline;
                                lb13.LinkBehavior = LinkBehavior.SystemDefault;
                                //lb13.Name = "lbl_1_" + i.ToString();
                                lb13.Text = "公司名称:";
                                lb13.Text += SubString(invoicebll.GetInvoiceLtdName(dtInfo.Rows[i][0].ToString()));
                                lb13.Name = dtInfo.Rows[i][0].ToString();
                                //id = Convert.ToInt16(dtInfo.Rows[i][0]);
                                lb13.Size = new System.Drawing.Size(185, 15);
                                lb13.Location = new System.Drawing.Point(wi, hei + pi3.Height + 3);
                                lb13.Click += new EventHandler(lb13_Click);
                                #endregion

                                #region 金额
                                Label lb4 = new Label();
                                lb4.Name = "lbl_4_" + i.ToString();
                                lb4.Text = "项目金额:";
                                lb4.Text += invoicebll.GetInvoiceMoneyByContractNo(dtInfo.Rows[i][12].ToString()).ToString() + "元";
                                lb4.Size = new System.Drawing.Size(165, 15);
                                lb4.Location = new System.Drawing.Point(pi3.Location.X, hei + pi3.Height + 15 + lb4.Height);

                                this.dgvInfo.Controls.Add(lb13);
                                this.dgvInfo.Controls.Add(lb4);
                                this.dgvInfo.Controls.Add(pi3);

                                if (wi + pi3.Width >= this.dgvInfo.Width - 100)
                                {
                                    hei += 83;
                                    wi = 5;
                                }
                                else
                                {
                                    wi += 200;
                                }
                                break;
                            default:
                                break;
                            #endregion
                            #endregion
                        }
                    }
                    InitDataSet();//分页方法
                }
                else { IsEnable(); }

            }
            catch
            {
                App_Code.Message.ErrorMsg("数据加载失败");
                return;
            }
        }
        #endregion

        private void IsEnable()
        {
            this.btnBack.Enabled = false;
            this.btnFind.Enabled = false;
            this.btnFirst.Enabled = false;
            this.btnNext.Enabled = false;
            this.btnLast.Enabled = false;
            if (App_Code.Canshu.Id != 0 && App_Code.Canshu.Id != -1)
                this.btnSave.Enabled = true;
            else
                this.btnSave.Enabled = false;
            }

        //截取字符串
        private static string SubString(string str)
        {
            int i = str.Length;
            if (i > 5)
                return str.Substring(0, 4) + "...";
            else
                return str;
        }

        private void lb13_Click(Object sender, EventArgs e)
        { 
            LinkLabel lblvalue = (LinkLabel)sender;
            Form_InvoiceInfo info = new Form_InvoiceInfo(); 
            App_Code.Canshu.Id = int.Parse(lblvalue.Name);
            info.ShowDialog();
            info.TopMost = true;
            info.Location = new Point(this.PointToClient(MousePosition).X + 1, this.PointToClient(MousePosition).Y + 60);
        }

        #region 图标单击事件
        /// <summary>
        /// 这个是PictureBox.Click的事件函式，
        /// 所有动态产生的PictureBox在Click的时候，都会呼叫此事件
        /// </summary>
        /// <param name="sender">代表目前click的pictureBox对象</param>
        /// <param name="e"></param>
        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;// 将sender转型成PictureBox
            if (null == pic) return;
            string name = pic.Name;// 取出pictureBox的名称
            
            switch (name)
            {
                case "pic1":
                    //未付
                    strvalue = pivalue;
                    Form_InvoiceXX xx = new Form_InvoiceXX();
                    xx.Show();
                    xx.myevent += new Form_InvoiceXX.dg(my_event);
                    break;
                case "pic2":
                    //未付完
                    strvalue = pi2value;
                    Form_InvoiceXX xx2 = new Form_InvoiceXX();
                    xx2.Show();
                    xx2.myevent += new Form_InvoiceXX.dg(my_event);
                    break;
                case "pic3":
                    //已付完
                    strvalue = pi3value;
                    Form_InvoiceXX xx3 = new Form_InvoiceXX();
                    xx3.Show();
                    xx3.myevent += new Form_InvoiceXX.dg(my_event);
                    break;
                default:
                    break;
            }
        }
        void my_event(string str)
        {
            str = strvalue;
        }
        #endregion

        #region 分页
        private void InitDataSet()
        {           
            dtInfo = invoicebll.GetList("");
            nMax = dtInfo.Rows.Count;
            pageCount = (nMax / pageSize);

            if (pageCount == 0)
            {
                Enableds();
                this.lblTotalpage.Text = "共0页";
                lblCurPage.Text = "0";
            }
            else
            {
                lblCurPage.Text = "第" + pageCurrent.ToString() + "页";
                this.lblTotalpage.Text = "共" + getTotalPage().ToString() + "页";
                if ((nMax % pageSize) > 0) pageCount++;
            }
        }
        /// <summary>
        /// 得到信息的总页数
        /// </summary>
        /// <returns></returns>
        private int getTotalPage()
        {
            int result = invoicebll.GetCount();
            int Total;
            if (result != 0)
            {
                int count = invoicebll.GetCount() % pageSize;
                if (count == 0)
                    Total = invoicebll.GetCount() / pageSize;
                else
                    Total = invoicebll.GetCount() / pageSize + 1;
            }
            else
                Total = 0;
            return Total;

        }
        #endregion

        void Enableds()
        {
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnFind.Enabled = false;
            txtPage.ReadOnly = true;
        }
        /// <summary>
        /// 上页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {

            if (pageCurrent > 1)
            {
                pageCurrent--;
            }
            else if (pageCurrent == 1)
            {
                App_Code.Message.InfoMsg("已经是'第一页'!请点击下一页");
                return;
            }
            else
            {
                pageCurrent = 1;
            }
            this.lblCurPage.Text = "第" + pageCurrent.ToString() + "页";
            Load_PicLict();
        }
        /// <summary>
        /// 下页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageCurrent == pageCount)
            {
                App_Code.Message.InfoMsg("已经是'最后一页'!请点击上一页");
                return;
            }
            else if (pageCurrent < pageCount)
            {
                pageCurrent++;
            }

            this.lblCurPage.Text = "第" + pageCurrent.ToString() + "页";
            Load_PicLict();
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (pageCurrent == 1)
            {
                App_Code.Message.InfoMsg("已经是'第一页'!请点击下一页");
                return;
            }
            pageCurrent = 1;                       
            this.lblCurPage.Text = "第" + pageCurrent.ToString() + "页";
            Load_PicLict();
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (pageCurrent == pageCount)
            {
                App_Code.Message.InfoMsg("已经是'最后一页'!请点击上一页");
                return;
            }
            else
            {
                pageCurrent = pageCount;
            }
            this.lblCurPage.Text = "第" + pageCurrent.ToString() + "页";
            Load_PicLict();
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
                if (page > this.getTotalPage() || page < 1)
                {
                    App_Code.Message.ErrorMsg("没有您所要查询的页数。");
                    return;
                }
                else
                {
                    pageCurrent = page;
                    this.lblCurPage.Text = "第" + pageCurrent.ToString() + "页";
                    Load_PicLict();
                }
            }
            catch (FormatException)
            {
                App_Code.Message.InfoMsg("所要查询的页数请输入数字。");
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //文本框验证 必须返回True
            if (InputCheck())
            {
                //查询发票编号是否存在 
                if (SerachInvoiceNo(this.txtInvoiceno.Text.Trim()) == false)
                {
                    //if (IsContract() == true)
                    //{
                    //    AddInvoiceMx();
                    //}
                    //else
                    //{
                        if (CheckMonth() == true)
                        {
                            if (AddInvoice())
                            {
                                App_Code.Message.InfoMsg("发票开出成功");
                                this.DialogResult = DialogResult.OK;
                                this.UpIncomeMon(this.txtContractno.Text, Convert.ToDecimal(this.txtInvoiceMoney.Text.Trim()), this.cbxIsBank.Text);
                                Log_BLL.Add(DateTime.Now, "开发票", App_Code.Canshu.LoginName, "开发票", Dns.GetHostName().ToUpperInvariant(), Systems.GetOSNameByUserAgent(Environment.OSVersion.ToString()), 10);
                                canshu = "main";
                                Form_OpenInvoice_Load(sender, e);
                            }
                            else
                            {
                                App_Code.Message.ErrorMsg("发票开出失败");
                                return;
                            }
                        }
                        else
                        {
                            App_Code.Message.ErrorMsg("发票开出失败！请联系管理员。");
                            return;
                        }
                    //}
                }
                else
                {
                    App_Code.Message.ErrorMsg("发票编号出现重复");
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtTic.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值");
                        this.txtTic.Clear();
                        return;
                    }
                    else
                    {
                        Convert.ToDecimal(this.txtTic.Text.Trim());
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                this.txtTic.Clear();
                return;
            }
        }

        private void txtInvoiceMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = this.txtInvoiceMoney.Text;
                if (!string.IsNullOrEmpty(txt))
                {
                    if (txt.Contains("-"))
                    {
                        App_Code.Message.ErrorMsg("输入正确的数值");
                        this.txtInvoiceMoney.Clear();
                        return;
                    }
                    else
                    {
                       decimal mon = Convert.ToDecimal(this.txtInvoiceMoney.Text.Trim());//发票金额  
                    }
                }
            }
            catch
            {
                App_Code.Message.ErrorMsg("输入正确的数值");
                this.txtInvoiceMoney.Clear();
                return;
            }
        }
        private void txtInvoiceMoney_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtInvoiceMoney.Clear();
        }

        private void txtTic_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtTic.Clear();
        }
    }
}
