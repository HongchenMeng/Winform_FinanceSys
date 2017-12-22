using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_Income 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Income_Model
    {
        public Income_Model() { }
        #region Model
        private int _id;
        private string _party;
        private string _b;
        private string _demoname;
        private decimal _money;
        private decimal _democost;
        private string _contractno;
        private DateTime _incometime;
        private string _empname;
        private decimal _deductap;
        private string _operperson;
        private string _isbank;
        private decimal _invoicemoney;
        private decimal _breakmoney;
        private string _remark;
        private string _type;

        /// <summary>
        /// 收入类别
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 甲方
        /// </summary>
        public string Party
        {
            set { _party = value; }
            get { return _party; }
        }
        /// <summary>
        /// 乙方
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
            set { _demoname = value; }
            get { return _demoname; }
        }
        /// <summary>
        /// 项目金额
        /// </summary>
        public decimal Money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 项目成本
        /// </summary>
        public decimal DemoCost
        {
            set { _democost = value; }
            get { return _democost; }
        }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractNo
        {
            set { _contractno = value; }
            get { return _contractno; }
        }
        /// <summary>
        /// 收入时间
        /// </summary>
        public DateTime Incometime
        {
            set { _incometime = value; }
            get { return _incometime; }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName
        {
            set { _empname = value; }
            get { return _empname; }
        }
        /// <summary>
        /// 提成
        /// </summary>
        public decimal Deductap
        {
            set { _deductap = value; }
            get { return _deductap; }
        }
        /// <summary>
        /// 操作员
        /// </summary>
        public string OperPerson
        {
            set { _operperson = value; }
            get { return _operperson; }
        }
        /// <summary>
        /// 是否回款
        /// </summary>
        public string IsBank
        {
            set { _isbank = value; }
            get { return _isbank; }
        }
        /// <summary>
        /// 发票金额
        /// </summary>
        public decimal InvoiceMoney
        {
            set { _invoicemoney = value; }
            get { return _invoicemoney; }
        }
        /// <summary>
        /// 回款金额
        /// </summary>
        public decimal BreakMoney
        {
            set { _breakmoney = value; }
            get { return _breakmoney; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}
