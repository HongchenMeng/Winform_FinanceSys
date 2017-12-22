using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.PersonnelSys.Model
{
    /// <summary>
    /// 实体类Stale_Users 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Users_Model
    {
        public Users_Model() { }
        #region Model
        private int _id;
        private string _username;
        private string _userpwd;
        private string _name;
        private string _isEnabled;

        /// <summary>
        /// 是否启用账户 0:启用账户 1:停用账户
        /// </summary>
        public string IsEnabled
        {
            set { _isEnabled = value; }
            get { return _isEnabled; }
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
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        #endregion Model   
    }
}
