using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.PublicLibrary.Model
{
    /// <summary>
    /// 实体类Stale_Log 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Log_Model
    {
        #region Model
        private int _id;
        private DateTime _opertime;
        private string _type;
        private string _operperson;
        private string _state;
        private string _computername;
        private string _system;
        private int _code;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            set { _opertime = value; }
            get { return _opertime; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
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
        /// 状态
        /// </summary>
        public string State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 计算机名
        /// </summary>
        public string ComputerName
        {
            set { _computername = value; }
            get { return _computername; }
        }
        /// <summary>
        /// 操作系统
        /// </summary>
        public string System
        {
            set { _system = value; }
            get { return _system; }
        }
        /// <summary>
        /// 标识码  1：系统登录  2：员工添加  
        /// 3：员工修改  4：员工删除 5：工资添加  
        /// 6：工资调整  7：工资发放  8：收入 9：支出  
        /// 10：开发票  11：合同签订
        /// </summary>
        public int Code
        {
            set { _code = value; }
            get { return _code; }
        }
        #endregion Model
    }
}
