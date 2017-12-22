using System;
using System.Collections.Generic;
using System.Text;


namespace FinanceSys.PersonnelSys.Model
{
    /// <summary>
    /// 实体类Stale_Employee 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Employee_Model
    {
        public Employee_Model() { }

        #region Model
        private int _id;
        private string _empname;
        private string _sex;
        private DateTime _entrytime;
        private int _departID;
        private string _job;
        private string _mobile;
        private string _officephone;
        private string _status;
        private string _remark;
        private int _code;

        public int Code
        {
            set { _code = value; }
            get { return _code; }
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
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EntryTime
        {
            set { _entrytime = value; }
            get { return _entrytime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepartID
        {
            set { _departID = value; }
            get { return _departID; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Job
        {
            set { _job = value; }
            get { return _job; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OfficePhone
        {
            set { _officephone = value; }
            get { return _officephone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Status
        {
            set { _status = value; }
            get { return _status; }
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
