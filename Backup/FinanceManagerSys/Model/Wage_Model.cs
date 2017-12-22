using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_Wage 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Wage_Model
    {
        public Wage_Model() { }
        #region Model
        private int _id;
        private DateTime _month;
        private string _empname;
        private decimal _basicwage;
        private decimal _jobsubsidies;
        private decimal _allowance;
        private decimal _overtimepay;
        private decimal _bonus;
        private decimal _businesscommission;
        private decimal _personalincometax;
        private decimal _socialsecurity;
        private decimal _other;
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
        /// 月份
        /// </summary>
        public DateTime Month
        {
            set { _month = value; }
            get { return _month; }
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
        /// 基本工资
        /// </summary>
        public decimal BasicWage
        {
            set { _basicwage = value; }
            get { return _basicwage; }
        }
        /// <summary>
        /// 岗位补贴
        /// </summary>
        public decimal Jobsubsidies
        {
            set { _jobsubsidies = value; }
            get { return _jobsubsidies; }
        }
        /// <summary>
        /// 津贴
        /// </summary>
        public decimal Allowance
        {
            set { _allowance = value; }
            get { return _allowance; }
        }
        /// <summary>
        /// 加班工资
        /// </summary>
        public decimal Overtimepay
        {
            set { _overtimepay = value; }
            get { return _overtimepay; }
        }
        /// <summary>
        /// 奖金
        /// </summary>
        public decimal Bonus
        {
            set { _bonus = value; }
            get { return _bonus; }
        }
        /// <summary>
        /// 业务提成
        /// </summary>
        public decimal Businesscommission
        {
            set { _businesscommission = value; }
            get { return _businesscommission; }
        }
        /// <summary>
        /// 个人所得税
        /// </summary>
        public decimal PersonalIncomeTax
        {
            set { _personalincometax = value; }
            get { return _personalincometax; }
        }
        /// <summary>
        /// 社保
        /// </summary>
        public decimal SocialSecurity
        {
            set { _socialsecurity = value; }
            get { return _socialsecurity; }
        }
        /// <summary>
        /// 其它
        /// </summary>
        public decimal Other
        {
            set { _other = value; }
            get { return _other; }
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
