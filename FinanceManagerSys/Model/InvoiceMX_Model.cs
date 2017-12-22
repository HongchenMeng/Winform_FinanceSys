using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_InvoiceMX 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class InvoiceMX_Model
    {
        public InvoiceMX_Model()
		{}
		#region Model
		private int _id;
		private string _invoiceno;
		private string _ltdname;
		private string _demoname;
		private decimal _money;
		private DateTime _invoicetime;
		private string _payment;
		private string _status;
		private string _handling;
		private string _empname;
		private string _isbank;
		private string _remark;
        private string _contractNo;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoiceNo
		{
			set{ _invoiceno=value;}
			get{return _invoiceno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LTDName
		{
			set{ _ltdname=value;}
			get{return _ltdname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DemoName
		{
			set{ _demoname=value;}
			get{return _demoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Invoicetime
		{
			set{ _invoicetime=value;}
			get{return _invoicetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Payment
		{
			set{ _payment=value;}
			get{return _payment;}
		}
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractNo
        {
            get { return _contractNo; }
            set { _contractNo = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Handling
		{
			set{ _handling=value;}
			get{return _handling;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmpName
		{
			set{ _empname=value;}
			get{return _empname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsBank
		{
			set{ _isbank=value;}
			get{return _isbank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model
    }
}
