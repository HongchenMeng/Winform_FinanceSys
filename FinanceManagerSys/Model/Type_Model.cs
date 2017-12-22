using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类Stale_Type 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Type_Model
    {
        public Type_Model() { }
        private int _iD;
        private string _typeName;

        public int ID
        {
            set { _iD = value; }
            get { return _iD; }
        }

        public string TypeName
        {
            set { _typeName = value; }
            get { return _typeName; }
        }
    }
}
