using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_InvoiceXX : Form
    {
        public Form_InvoiceXX()
        {
            InitializeComponent();
        }
        public delegate void dg(string str);//定义委托
        public event dg myevent;//事件变量
        /// <summary>
        /// 合同编号(局部变量)
        /// </summary>
        public string contractno = string.Empty;

        private void Form_InvoiceXX_Load(object sender, EventArgs e)
        {
            Load_InvoiceXX(Form_OpenInvoice.strvalue);
        }
        public void Load_InvoiceXX(string contractno)
        {
            FinanceManagerSys.BLL.InvoiceMX_BLL mxbll = new FinanceSys.FinanceManagerSys.BLL.InvoiceMX_BLL();
            DataTable dt = mxbll.GetList(contractno);

            dgvInvoiceMX.AutoGenerateColumns = false;
           dgvInvoiceMX.DataSource = dt;           
        }
    }
}
