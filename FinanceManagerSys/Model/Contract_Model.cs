using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_Contract 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Contract_Model
    {
        public Contract_Model()
		{}
		#region Model
		private int _contractid;
		private string _contractno;
        private string _party;
        private string _b;
		private string _demoname;
		private decimal _money;
		private string _payment;
		private string _schedule;
		private decimal _cost;
		private string _empName;
		private string _invoiceno;
		private DateTime _signedtime;
		private DateTime _addtime;
		private string _operperson;
		private string _remark;
		/// <summary>
		/// 合同表ID
		/// </summary>
		public int ContractID
		{
			set{ _contractid=value;}
			get{return _contractid;}
		}
		/// <summary>
		/// 合同编号(手动输入)
		/// </summary>
		public string ContractNo
		{
			set{ _contractno=value;}
			get{return _contractno;}
		}
		/// <summary>
		/// 甲方
		/// </summary>
        public string Party
		{
			set{ _party=value;}
            get { return _party; }
		}
        /// <summary>
        /// 已方
        /// </summary>
        public string B
        {
            set { _b = value; }
            get { return _b; }
        }
		/// <summary>
		/// 项目名称
		/// </summary>
		public string DemoName
		{
			set{ _demoname=value;}
			get{return _demoname;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 付款方式
		/// </summary>
		public string Payment
		{
			set{ _payment=value;}
			get{return _payment;}
		}
		/// <summary>
		/// 项目进度
		/// </summary>
		public string Schedule
		{
			set{ _schedule=value;}
			get{return _schedule;}
		}
		/// <summary>
		/// 项目成本
		/// </summary>
		public decimal Cost
		{
			set{ _cost=value;}
			get{return _cost;}
		}
		/// <summary>
		/// 业务员(外键)
		/// </summary>
		public string EmpName
		{
			set{ _empName=value;}
			get{return _empName;}
		}
		/// <summary>
		/// 发票编号
		/// </summary>
		public string InvoiceNo
		{
			set{ _invoiceno=value;}
			get{return _invoiceno;}
		}
		/// <summary>
		/// 合同签订时间
		/// </summary>
		public DateTime Signedtime
		{
			set{ _signedtime=value;}
			get{return _signedtime;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime Addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 操作员
		/// </summary>
		public string OperPerson
		{
			set{ _operperson=value;}
			get{return _operperson;}
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
