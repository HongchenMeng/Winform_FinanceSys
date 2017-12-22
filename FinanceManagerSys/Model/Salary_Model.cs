using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_Salary 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Salary_Model
    {
        public Salary_Model()
		{}
		#region Model
		private int _salaryid;
		private decimal _newsalary;
		private decimal _oldsalary;
		private string _reason;
		private DateTime _pubdate;
        private string _empName;
		private string _operperson;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int SalaryID
		{
			set{ _salaryid=value;}
			get{return _salaryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal NewSalary
		{
			set{ _newsalary=value;}
			get{return _newsalary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OldSalary
		{
			set{ _oldsalary=value;}
			get{return _oldsalary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reason
		{
			set{ _reason=value;}
			get{return _reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PubDate
		{
			set{ _pubdate=value;}
			get{return _pubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmpName
		{
			set{ _empName=value;}
            get { return _empName; }
		}
		/// <summary>
		/// 
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
