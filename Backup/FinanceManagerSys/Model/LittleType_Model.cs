using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.FinanceManagerSys.Model
{
    /// <summary>
    /// 实体类LittleType_Model 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class LittleType_Model
    {
        public LittleType_Model() { }

        private int _iD;
        private string _littleName;
        private int _typeID;

        public int ID
        {
            set { _iD = value; }
            get { return _iD; }
        }

        public string LittleName
        {
            set { _littleName = value; }
            get { return _littleName; }
        }

        public int TypeID
        {
            set { _typeID = value; }
            get { return _typeID; }
        }

    }
}
