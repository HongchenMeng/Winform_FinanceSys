using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_Outlay 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Outlay_Model
    {
        public Outlay_Model() { }
        #region Model
        private int _id;
        private string _empname;
        private string _party;
        private string _b;
        private string _demoname;
        private string _type;
        private string _contractno;
        private DateTime _outlayetime;
        private string _operperson;
        private decimal _money;
        private string _remark;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmpName
        {
            set { _empname = value; }
            get { return _empname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Party
        {
            set { _party = value; }
            get { return _party; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string B
        {
            set { _b = value; }
            get { return _b; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DemoName
        {
            set { _demoname = value; }
            get { return _demoname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ContractNo
        {
            set { _contractno = value; }
            get { return _contractno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Outlayetime
        {
            set { _outlayetime = value; }
            get { return _outlayetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OperPerson
        {
            set { _operperson = value; }
            get { return _operperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money
        {
            set { _money = value; }
            get { return _money; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model
    }
}
