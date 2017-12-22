using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.PersonnelSys.Model
{
    public class Department_Model
    {
        #region Model
        private int _id;
        private string _departname;
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
        public string DepartName
        {
            set { _departname = value; }
            get { return _departname; }
        }
       
        #endregion Model

    }
}
