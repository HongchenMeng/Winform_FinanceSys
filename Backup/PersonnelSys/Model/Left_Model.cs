using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.PersonnelSys.Model
{
    /// <summary>
    /// 实体类Stale_Left 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Left_Model
    {
        #region Model
        private int _id;
        private int _eid;
        private string _empname;
        private string _sex;
        private string _departname;
        private DateTime _lefttime;
        private string _lefttype;
        private string _leftreason;
        private string _approvalperson;
        private string _approvaldempart;
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
        public int EID
        {
            set { _eid = value; }
            get { return _eid; }
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
        public string DepartName
        {
            set { _departname = value; }
            get { return _departname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LeftTime
        {
            set { _lefttime = value; }
            get { return _lefttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LeftType
        {
            set { _lefttype = value; }
            get { return _lefttype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LeftReason
        {
            set { _leftreason = value; }
            get { return _leftreason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ApprovalPerson
        {
            set { _approvalperson = value; }
            get { return _approvalperson; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ApprovalDempart
        {
            set { _approvaldempart = value; }
            get { return _approvaldempart; }
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
